
using Accord.MachineLearning;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using VirusDetection.Clustering;
using VirusDetection.Detector;
using VirusDetection.FileClassifier;
using VirusDetection.FormCustomize;
using VirusDetection.Utils;
using VirusDetection.VirusScanner;

namespace VirusDetection
{
    enum PROGRESSSTATE
    {
        DATAGENERATION,
        LEARNING,
        AFFINITYGENERATION,
        DETECTING
    };

    enum EScanVirusType
    {
        StringCompare,
        AIS
    };

    enum EDetectorType
    {
        BuildDetector,
        AdditionNegative
    };

    public partial class FormMain : Form
    {
        // Declare variable
        private bool isWorking;
        private DateTime startTime;
        private ManualResetEvent stopEvent;
        private Thread worker;

        private string VirusDirectory;
        private string BenignDirectory;

        // Data generation
        private int Length;
        private int stepsize;
        private bool UseHamming;
        private bool UseR;
        private int d;
        private int r;
        private DataGeneration datageneration;

        private TrainingData _virusFragments;
        private TrainingData _benignFragments;

        private double[][] _detectorData;

        private int[] Label;
        private List<byte[][]> GroupData;
        private List<Cluster> groups;

        private DataTable NegativeSelectionData;
        private DataTable groupshowingDataTable;

        //represetation
        private DataSet dataSet;


        // LK Custom code
        ClusteringManager _clusteringManager;
        FileClassifierManager _fileClassifierManager;
        VirusScannerManager _virusScannerManager;

        // For scan vr stop button
        Boolean _doneScan;


        public FormMain()
        {
            InitializeComponent();
            initDemo();
            _lkPatch();
            _initialize();
        }

        private void _initialize()
        {
            isWorking = false;
            stopEvent = null;
            Length = 0;
            stepsize = 0;
            UseHamming = false;
            UseR = false;
            d = 0;
            r = 0;

            GroupData = new List<byte[][]>();
            groups = new List<Cluster>();

            NegativeSelectionData = new DataTable();
            groupshowingDataTable = new DataTable();

            //represetation
            dataSet = new DataSet();

            _doneScan = false;
        }


        #region Form Event

        #region Detector Event
        private void btnDVirusFolder_Click(object sender, EventArgs e)
        {
            FolderSelectDialog folderSelectDialog = new FolderSelectDialog();
            folderSelectDialog.Title = "Select Folder";
            bool result = folderSelectDialog.ShowDialog();
            if (result)
            {
                txtbDVirusFolder.Text = folderSelectDialog.FileName;
            }

        }

        private void btnDBenignFolder_Click(object sender, EventArgs e)
        {
            FolderSelectDialog folderSelectDialog = new FolderSelectDialog();
            folderSelectDialog.Title = "Select Folder";
            bool result = folderSelectDialog.ShowDialog();
            if (result)
            {
                txtbDBenignFolder.Text = folderSelectDialog.FileName;
            }

        }

        private void btnDDetectorFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                txtbDDetectorFile.Text = openFileDialog1.FileName;
            }
        }

        private void btnDAdditionFolder_Click(object sender, EventArgs e)
        {
            FolderSelectDialog folderSelectDialog = new FolderSelectDialog();
            folderSelectDialog.Title = "Select Folder";
            bool result = folderSelectDialog.ShowDialog();
            if (result)
            {
                txtbDAdditionFolder.Text = folderSelectDialog.FileName;
            }
        }

        private void btnDStart_Click(object sender, EventArgs e)
        {
            try
            {
                _startDetector();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void _startDetector()
        {
            Boolean isOk = _checkForStartDetector();
            if (!isOk)
            {
                MessageBox.Show("Please check input!");
                return;
            }

            if (isWorking)
                return;

            // Reset value
            _resetFormStatus();

            DataGenerationStart();
        }

        private void _resetFormStatus()
        {
            progressBar.Value = 0;
            txtbVirusFragmentsCount.Text = "0";
        }

        private bool _checkForStartDetector()
        {
            if (rbtnDBuildDetector.Checked)
            {
                if (String.IsNullOrEmpty(txtbDVirusFolder.Text) || String.IsNullOrEmpty(txtbDBenignFolder.Text))
                    return false;
                return true;
            }

            if (String.IsNullOrEmpty(txtbDAdditionFolder.Text))
                return false;
            return true;
        }
        private void btnDStop_Click(object sender, EventArgs e)
        {
            try
            {
                _stopDetector();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void _stopDetector()
        {
            worker.Abort();
            datageneration.stopBuildDetector();
            isWorking = false;
        }


        private void btnDSaveDetector_Click(object sender, EventArgs e)
        {
            try
            {
                _saveDetector();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void _saveDetector()
        {
            Boolean isOk = _checkForSaveDetector();
            if (!isOk)
            {
                MessageBox.Show("Empty input or data!");
                return;
            }

            String virusSavePath = txtbDDetectorFile.Text;
            String benignSavePath = txtbDBenignFile.Text;
            Utils.Utils.saveDetector(_virusFragments, virusSavePath, _benignFragments, benignSavePath);
            MessageBox.Show("Successful!");
        }

        private bool _checkForSaveDetector()
        {
            if (String.IsNullOrEmpty(txtbDDetectorFile.Text) || _virusFragments == null || _benignFragments == null || _virusFragments.Count + _benignFragments.Count == 0)
                return false;
            return true;
        }

        private void btnDLoadDetector_Click(object sender, EventArgs e)
        {
            try
            {
                _loadDetection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void _loadDetection()
        {

            Boolean isOk = _checkForLoadDetector();
            if (!isOk)
            {
                MessageBox.Show("Empty input!");
                return;
            }
            String virusSavePath = txtbDDetectorFile.Text;
            String benignSavePath = txtbDBenignFile.Text;
            Utils.Utils.loadDetector(ref _virusFragments, virusSavePath, ref _benignFragments, benignSavePath);

            ShowingData();
            MessageBox.Show("Successful!");
        }

        private bool _checkForLoadDetector()
        {
            if (String.IsNullOrEmpty(txtbDDetectorFile.Text))
                return false;
            return true;
        }

        #endregion

        #region Clustering Event
        private void btnCSaveMixDetector_Click(object sender, EventArgs e)
        {

            try
            {
                _saveMixDetector();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void _saveMixDetector()
        {
            String savePath = txtbCMixDetectorFile.Text;
            Utils.Utils.saveMixDetector(_detectorData, savePath);
            MessageBox.Show("Successful!");
        }

        private void btnCLoadMixDetector_Click(object sender, EventArgs e)
        {
            try
            {
                _loadMixDetector();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void _loadMixDetector()
        {
            String fileName = txtbCMixDetectorFile.Text;
            _detectorData = Utils.Utils.loadMixDetector(fileName);
            _calcNumOfDetector();
            MessageBox.Show("Successful!");
        }

        private void _calcNumOfDetector()
        {
            int[] detectorCount = Utils.Utils.calcNumOfDetector(_detectorData);
            txtbCVirusSize.Text = detectorCount[0].ToString();
            txtbCBenignSize.Text = detectorCount[1].ToString();
        }

        private void btnCStartClustering_Click(object sender, EventArgs e)
        {
            try
            {
                _startClustering();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void _startClustering()
        {
            isWorking = true;
            worker = new Thread(clusteringThread);
            worker.Start();
        }

        private void clusteringThread()
        {
            int inputCount = int.Parse(txtbCNumInputNeuron.Text);
            int maxInputRange = (inputCount == 4 ? 255 : 1);
            int numNeuronX = int.Parse(txtbCNumNeuronX.Text);
            int numNeuronY = int.Parse(txtbCNumNeuronY.Text);
            double learningRate = double.Parse(txtbCLearningRate.Text);
            double learningRadius = double.Parse(txtbCLearningRadius.Text);
            int numOfIterator = int.Parse(txtbCNumIterator.Text);
            double errorThresold = double.Parse(txtbCErrorThresold.Text);

            _clusteringManager = new ClusteringManager(
                inputCount,
                numNeuronX,
                numNeuronY,
                learningRate,
                learningRadius,
                numOfIterator,
                errorThresold,
                _detectorData,
                maxInputRange
                );

            _clusteringManager.trainDistanceNetwork();

            LoadDangerLevel();

            _clusteringManager.Test_PrintlnNeuron();

            isWorking = false;
            MessageBox.Show("Successful!");
            
        }

        private void btnCStop_Click(object sender, EventArgs e)
        {

            try
            {
                _clusteringManager.stopTrainDistanceNetwork();
                
                isWorking = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void cbxCUseRate_CheckedChanged(object sender, EventArgs e)
        {
            txtbCBenignVirusRate.ReadOnly = !txtbCBenignVirusRate.ReadOnly;

            txtbCVirusSize.ReadOnly = !txtbCVirusSize.ReadOnly;
            txtbCBenignSize.ReadOnly = !txtbCBenignSize.ReadOnly;
        }

        private void btnCMixDetector_Click(object sender, EventArgs e)
        {
            try
            {
                _mixDetector();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void _mixDetector()
        {
            _correctDetectorData();
            _calcNumOfDetector();
            MessageBox.Show("Successful!");
        }


        private void btnCClusteringFile_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.RestoreDirectory = true;
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                txtbCClusteringFile.Text = openFileDialog1.FileName;
            }

        }

        private void btnCSave_Click(object sender, EventArgs e)
        {
            try
            {
                _saveClustering();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void _saveClustering()
        {
            String fileName = txtbCClusteringFile.Text;
            _clusteringManager.saveDistanceNetwork(fileName);
            MessageBox.Show("Successful!");
        }


        private void btnCLoad_Click(object sender, EventArgs e)
        {
            try
            {
                _loadClustering();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void _loadClustering()
        {
            String fileName = txtbCClusteringFile.Text;

            if (_clusteringManager == null)
                _clusteringManager = new ClusteringManager();

            _clusteringManager.loadDistanceNetwork(fileName);
            txtbCNumInputNeuron.Text = _clusteringManager.NumInputNeuron.ToString();


            MessageBox.Show("Successful!");
        }


        private void btnCMixDetectorFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                txtbCMixDetectorFile.Text = openFileDialog1.FileName;
            }
        }


        #endregion

        #region File Classifier Event


        private void btnFCVirusFolder_Click(object sender, EventArgs e)
        {
            FolderSelectDialog folderSelectDialog = new FolderSelectDialog();
            folderSelectDialog.Title = "Select Folder";
            bool result = folderSelectDialog.ShowDialog();
            if (result)
            {
                txtbFCVirusFolder.Text = folderSelectDialog.FileName;
            }
        }

        private void btnFCBenignFolder_Click(object sender, EventArgs e)
        {
            FolderSelectDialog folderSelectDialog = new FolderSelectDialog();
            folderSelectDialog.Title = "Select Folder";
            bool result = folderSelectDialog.ShowDialog();
            if (result)
            {
                txtbFCBenignFolder.Text = folderSelectDialog.FileName;
            }

        }

        private void btnFCPreprocesser_Click(object sender, EventArgs e)
        {
            try
            {
                _preprocesserFileClassifier();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void _preprocesserFileClassifier()
        {

            String virusFolder = txtbFCVirusFolder.Text;
            String benignFolder = txtbFCBenignFolder.Text;
            String formatRange = txtbCFFormatRange.Text;

            _fileClassifierManager = new FileClassifierManager(
                virusFolder,
                benignFolder,
                _clusteringManager.DistanceNetwork,
                formatRange
                );
            _fileClassifierManager.buildTrainingSet();
            LoadStyleChart();
        }

        private void btnFCStop_Click(object sender, EventArgs e)
        {
            try
            {
                _fileClassifierManager.stopTrainActiveNetwork();
                isWorking = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnFCStartFileClassifier_Click(object sender, EventArgs e)
        {
            try
            {
                _startFileClassifier();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void _startFileClassifier()
        {
            isWorking = true;
            worker = new Thread(_fileClassifierThread);
            worker.Start();
        }

        private void _fileClassifierThread()
        {
            int numOfHiddenNeuron = int.Parse(txtbFCNumHiddenNeuron.Text);
            int numOfOutputNeuron = int.Parse(txtbCFNumOutputNeuron.Text);
            int numOfIterator = int.Parse(txtbCFNumIterator.Text);
            double errorThresold = double.Parse(txtbCFErrorThresold.Text);


            _fileClassifierManager.trainActiveNetwork(numOfHiddenNeuron,
                numOfOutputNeuron,
                numOfIterator,
                errorThresold);

            isWorking = false;
            MessageBox.Show("Successful!");
        }

        private void btnFCSave_Click(object sender, EventArgs e)
        {
            try
            {
                _saveFileClassifier();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void _saveFileClassifier()
        {
            String fileName = txtbFCFileClassifierFile.Text;
            _fileClassifierManager.saveActiveNetwork(fileName);
            MessageBox.Show("Successful!");
        }

        private void btnFCLoad_Click(object sender, EventArgs e)
        {
            try
            {
                _loadFileClassifier();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void _loadFileClassifier()
        {
            if (_fileClassifierManager == null)
            {
                String virusFolder = txtbDVirusFolder.Text;
                String benignFolder = txtbDBenignFolder.Text;
                String formatRange = txtbCFFormatRange.Text;

                _fileClassifierManager = new FileClassifierManager(
                    virusFolder,
                    benignFolder,
                    _clusteringManager.DistanceNetwork,
                    formatRange
                    );
            }

            String fileName = txtbFCFileClassifierFile.Text;
            _fileClassifierManager.loadActiveNetwork(fileName);

            MessageBox.Show("Successful!");
        }


        private void btnFCFileClassifierFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.RestoreDirectory = true;
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                txtbFCFileClassifierFile.Text = openFileDialog1.FileName;
            }
        }


        #endregion

        #region Virus Scan Event

        private void btnScanVirus_Click(object sender, EventArgs e)
        {
            try
            {
                _startScanVirus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void _startScanVirus()
        {
            _virusScannerManager = new VirusScannerManager(
                _fileClassifierManager.DistanceNetwork,
                _fileClassifierManager.ActivationNetwork,
                txtbCFFormatRange.Text
                );

            isWorking = true;
            worker = new Thread(_scanVirusThread);
            worker.Start();
        }

        private void _scanVirusThread()
        {
            if (InvokeRequired)
            {
                MethodInvoker method = new MethodInvoker(_scanVirusThread);
                Invoke(method);
                return;
            }
            __scanVirus();
            isWorking = false;
        }

        private void __scanVirus()
        {
            String testFileFolder = txtbVSTestFileFolder.Text;
            String[] testFile = Directory.GetFiles(testFileFolder, "*.*", SearchOption.AllDirectories);

            int numOfVirus = 0;
            int numOfBenign = 0;

            DataColumn column;
            DataRow row;
            DataView view;
            DataTable virusList = new DataTable();
            virusList.Columns.Clear();

            // Create new DataColumn, set DataType, ColumnName and add to DataTable.    
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "File";
            virusList.Columns.Add(column);

            // Create second column.
            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "Status";
            virusList.Columns.Add(column);
            virusList.Rows.Clear();

            Boolean done = false;
            foreach (String file in testFile)
            {
                Boolean result = _virusScannerManager.scanFile(file);
                if (result)
                {
                    row = virusList.NewRow();
                    row["File"] = file.ToString();
                    row["Status"] = "Virus";
                    virusList.Rows.Add(row);
                    numOfVirus++;
                }
                else
                {
                    row = virusList.NewRow();
                    row["File"] = file.ToString();
                    row["Status"] = "Benign";
                    virusList.Rows.Add(row);
                    numOfBenign++;
                }
                if (done)
                    break;
            }

            txtbFCNumVirus.Text = numOfVirus.ToString();
            txtbFCNumBenign.Text = numOfBenign.ToString();
            Console.WriteLine("Virus: " + numOfVirus);
            Console.WriteLine("Benign: " + numOfBenign);
            view = new DataView(virusList);
            dgvVirus.DataSource = view;
        }


        private void btnTestFileFolder_Click(object sender, EventArgs e)
        {
            FolderSelectDialog folderSelectDialog = new FolderSelectDialog();
            folderSelectDialog.Title = "Select Folder";
            bool result = folderSelectDialog.ShowDialog();
            if (result)
            {
                txtbVSTestFileFolder.Text = folderSelectDialog.FileName;
            }

        }


        private void btnVSStop_Click(object sender, EventArgs e)
        {
            try
            {
                _stopScanVirus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void _stopScanVirus()
        {
            worker.Abort();
            isWorking = false;
        }


        #endregion




        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!worker.IsAlive)
            {
                StopWork();
                isWorking = false;

                this._virusFragments = datageneration.trainingDataOutput;
                this._benignFragments = datageneration.FileFragmentInput;

                PrepareShowingDataGeneration();
            }
        }


        public void LoadStyleChart()
        {
            chart1.Series.Clear();

            chart1.Series.Add("Benign");
            chart1.Series["Benign"].ChartType = SeriesChartType.Point;
            chart1.Series.Add("Virus");
            chart1.Series["Virus"].ChartType = SeriesChartType.Point;
            chart1.ChartAreas["ChartArea1"].AxisX.MajorGrid.LineWidth = 0;
            chart1.ChartAreas["ChartArea1"].AxisY.MajorGrid.LineWidth = 0;
            for (int i = 0; i < _fileClassifierManager._graphMap.Length; i++)
            {
                if (_fileClassifierManager._graphMap[i][1] == Utils.Utils.BENIGN_MARK)
                    chart1.Series["Benign"].Points.AddXY(i, _fileClassifierManager._graphMap[i][0]);
                else if (_fileClassifierManager._graphMap[i][1] == Utils.Utils.VIRUS_MARK)
                    chart1.Series["Virus"].Points.AddXY(i, _fileClassifierManager._graphMap[i][0]);
            }
        }

        private void LoadDangerLevel()
        {
            if (InvokeRequired)
            {
                MethodInvoker method = new MethodInvoker(LoadDangerLevel);
                Invoke(method);
                return;
            }
            _loadDangerLevel();
        }

        private void _loadDangerLevel()
        {
            dangerLevel.Series.Clear();
            dangerLevel.Series.Add("Benign");
            dangerLevel.Series["Benign"].ChartType = SeriesChartType.Point;
            dangerLevel.Series.Add("Virus");
            dangerLevel.Series["Virus"].ChartType = SeriesChartType.Point;
            dangerLevel.ChartAreas["ChartArea1"].AxisX.MajorGrid.LineWidth = 0;
            dangerLevel.ChartAreas["ChartArea1"].AxisY.MajorGrid.LineWidth = 0;
            //dangerLevel.ChartAreas[0].Position.Y = 100;
            ////dangerLevel.ChartAreas[0].Position.Height = 60;
            //dangerLevel.ChartAreas[0].AxisX.Maximum = 500;
            //dangerLevel.ChartAreas[0].AxisX.Minimum = 0;
            //dangerLevel.ChartAreas[0].AxisY.Maximum = 500;
            //dangerLevel.ChartAreas[0].AxisY.Minimum = 0;
            double[][] cluster = _clusteringManager.DangerLevel();
            for (int i = 0; i < cluster.Length; i++)
            {
                if (cluster[i][1] == Utils.Utils.BENIGN_MARK)
                    dangerLevel.Series["Benign"].Points.AddXY(i, cluster[i][0]);
                else if (cluster[i][1] == Utils.Utils.VIRUS_MARK)
                    dangerLevel.Series["Virus"].Points.AddXY(i, cluster[i][0]);
            }
        }
        #endregion

        #region Utils Method

        #region Detecter Method
        private void StartWork(bool stopable)
        {
            // set busy cursor
            this.Cursor = Cursors.WaitCursor;
            //
            //btnStop.Enabled = stopable;
            progressBar.Value = 0;

            if (stopable)
            {
                // create events
                stopEvent = new ManualResetEvent(false);
            }
            else
            {
                this.Capture = true;
            }
            startTime = DateTime.Now;
            txtTimeBox.Text = "";
            txtStatusBar.Text = "";
            // start timer
            timer1.Start();
        }

        private void RunDetector()
        {
            datageneration.startBuildDetector();

            ShowDataGenerationProcess(90, "Data generation process has ended");
        }

        private void StopWork()
        {
            // Lvl1progressPanel.Visible = false;
            // set default cursor
            this.Cursor = Cursors.Default;

            // stop timer
            timer1.Stop();
            // release event
            if (stopEvent != null)
            {
                stopEvent.Close();
                stopEvent = null;
            }
            else
            {
                this.Capture = false;
            }
        }

        private List<byte[][]> Group(TrainingData TD, double _SelectionRate, int _numberOfCluster)
        {
            for (int i = 0; i < TD.Count; i++)
            {
                if (TD[i] == null) { TD.RemoveAt(i); i--; continue; }
            }
            double[][] temp = new double[TD.Count][];
            //double[][] temp = new double[TD.Count][];
            for (int i = 0; i < TD.Count; i++)
            {

                temp[i] = new double[TD[i].Length];
                for (int j = 0; j < temp[i].Length; j++)
                {
                    temp[i][j] = (double)TD[i][j];
                }
            }
            KMeans kmeans = new KMeans(_numberOfCluster);
            //KMeans kmeans = new KMeans(40);
            Label = kmeans.Compute(temp);
            List<int> label1 = new List<int>();
            for (int i = 0; i < Label.Length; i++)
            {
                bool flag = false;
                for (int j = 0; j < groups.Count; j++)
                {
                    if (groups[j].label == Label[i])
                    {
                        groups[j].Add(TD[i]);
                        flag = true;
                    }


                }
                if (!flag)
                {
                    Cluster s = new Cluster(Label[i]);
                    s.Add(TD[i]);
                    groups.Add(s);
                }

            }
            for (int i = 0; i < groups.Count; i++)
            {
                groups[i].rate = (double)groups[i].val.Count / TD.Count;
            }
            groups.Sort();
            List<byte[][]> tempnew = new List<byte[][]>();
            for (int i = 0; i < _SelectionRate * groups.Count; i++)
            {
                tempnew.Add(groups[i].val.ToArray());
            }
            return tempnew;

        }

        private void DataGenerationStart()
        {
            GetInputDirectory();
            NegativeSelectionData.Rows.Clear();
            groupshowingDataTable.Rows.Clear();
            ShowDataGenerationProcess(10, "Being update parameters...");
            GetDataGenerationParameter();
            datageneration = new DataGeneration(BenignDirectory, VirusDirectory, d, r, Length, stepsize, UseHamming, UseR);
            ShowDataGenerationProcess(20, "Starting Negative Selection process...");
            StartWork(false);
            isWorking = true;
            worker = new Thread(RunDetector);
            worker.Start();
        }

        private void GetInputDirectory()
        {
            VirusDirectory = txtbDVirusFolder.Text;
            BenignDirectory = txtbDBenignFolder.Text;
        }


        private void ShowDataGenerationProcess(int step, string discripts)
        {
            //this.progressBar2.BeginInvoke((MethodInvoker)delegate() { this.progressBar2.Value = step; this.progressBar2.Refresh(); });
            this.txtStatusBar.BeginInvoke((MethodInvoker)delegate() { txtStatusBar.Text = discripts; ; this.txtStatusBar.Refresh(); });
            TimeSpan elapsed = DateTime.Now.Subtract(startTime);
            txtTimeBox.BeginInvoke((MethodInvoker)delegate()
            {
                txtTimeBox.Text = "Elapsed time : " + string.Format("{0}:{1}:{2}",
                    elapsed.Hours.ToString("D2"),
                    elapsed.Minutes.ToString("D2"),
                    elapsed.Seconds.ToString("D2")); this.txtTimeBox.Refresh();
            });

            txtTimeBox.Invalidate();
        }

        private void GetDataGenerationParameter()
        {
            try
            {
                Length = Math.Max(2, Math.Min(8, int.Parse(txtDLength.Text)));
            }
            catch { Length = 4; }
            try
            {
                stepsize = Math.Max(2, Math.Min(8, int.Parse(txtDStepSize.Text)));
                if (stepsize != Length / 2)
                    stepsize = Length / 2;
            }
            catch { stepsize = stepsize / 2; }

            UseHamming = cbxDHamming.Checked;
            UseR = cbxDRContiguos.Checked;
            if (UseHamming)
            {
                try
                {
                    d = Math.Max(0, Math.Min(Length * 8, int.Parse(txtbDHamming.Text)));
                }
                catch { d = Length / 2; }
            }
            if (UseR)
            {
                try
                {
                    r = Math.Max(0, Math.Min(Length * 8, int.Parse(txtbDContiguos.Text)));
                }
                catch { r = Length / 2; }
            }
        }


        private void ShowingDataGenerationResults()
        {
            GetgroupingData(datageneration.VirusFragmentInput, datageneration.state);
            GetgroupShowing();
        }

        private void GetgroupingData(TrainingData TD, int[] state)
        {
            // Declare DataColumn and DataRow variables.
            DataColumn column;
            DataRow row;
            DataView view;
            NegativeSelectionData.Columns.Clear();

            // Create new DataColumn, set DataType, ColumnName and add to DataTable.    
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "Virus Data Fragments";
            NegativeSelectionData.Columns.Add(column);

            // Create second column.
            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "Status";
            NegativeSelectionData.Columns.Add(column);
            NegativeSelectionData.Rows.Clear();

            for (int i = 0; i < TD.Count; i++)
            {
                row = NegativeSelectionData.NewRow();
                row["Virus Data Fragments"] = ConvertByteArrayToString(TD[i]);
                //row[0] = ConvertByteArrayToString(TD[i]);
                if (state[i] == 0)
                {
                    row["Status"] = "Passed";
                }
                else
                { row["Status"] = "Failed"; }
                NegativeSelectionData.Rows.Add(row);

            }
            view = new DataView(NegativeSelectionData);

            // Set a DataGrid control's DataSource to the DataView.
            dtNegativeSelection.DataSource = view;
        }

        private void ShowingData()
        {
            DataColumn column;
            DataRow row;
            DataView view;
            NegativeSelectionData.Columns.Clear();

            // Create new DataColumn, set DataType, ColumnName and add to DataTable.    
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "Virus Data Fragments";
            NegativeSelectionData.Columns.Add(column);

            // Create second column.
            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "Status";
            NegativeSelectionData.Columns.Add(column);
            NegativeSelectionData.Rows.Clear();
            for (int i = 0; i < _virusFragments.Count; i++)
            {
                row = NegativeSelectionData.NewRow();
                row["Virus Data Fragments"] = ConvertByteArrayToString(_virusFragments[i]);
                row["Status"] = "Passed";
                NegativeSelectionData.Rows.Add(row);

            }
            for (int i = 0; i < _benignFragments.Count; i++)
            {
                row = NegativeSelectionData.NewRow();
                row["Virus Data Fragments"] = ConvertByteArrayToString(_benignFragments[i]);
                row["Status"] = "Fail";
                NegativeSelectionData.Rows.Add(row);

            }
            view = new DataView(NegativeSelectionData);

            // Set a DataGrid control's DataSource to the DataView.
            dtNegativeSelection.DataSource = view;


            // Show value to status
            String status = string.Format("Number of virus fragments: {0}      Number of benign fragments : {1}", _virusFragments.Count, _benignFragments.Count);

            this.txtStatusBar.BeginInvoke((MethodInvoker)delegate()
            {
                txtStatusBar.Text = status;
                this.txtStatusBar.Refresh();
            });

        }
        private void GetgroupShowing()
        {
            // Declare DataColumn and DataRow variables.
            DataColumn column;
            DataRow row;
            DataView view;
            groupshowingDataTable.Columns.Clear();

            // Create new DataColumn, set DataType, ColumnName and add to DataTable.    
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "Cluster Label";
            groupshowingDataTable.Columns.Add(column);

            // Create second column.
            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "Representive Data";
            groupshowingDataTable.Columns.Add(column);

            // Create third column.
            column = new DataColumn();
            column.DataType = Type.GetType("System.Double");
            column.ColumnName = "Rate";
            groupshowingDataTable.Columns.Add(column);

            groupshowingDataTable.Rows.Clear();
            for (int i = 0; i < groups.Count; i++)
            {
                row = groupshowingDataTable.NewRow();
                row["Cluster Label"] = groups[i].label;
                row["Representive Data"] = ConvertByteArrayToString(groups[i].val[0]);
                row["Rate"] = groups[i].rate;
                groupshowingDataTable.Rows.Add(row);
            }
            view = new DataView(groupshowingDataTable);

            // Set a DataGrid control's DataSource to the DataView.
            //  dtGroupView.DataSource = view;
        }


        private string ConvertByteArrayToString(byte[] bytes)
        {
            string s = "";
            for (int i = 0; i < bytes.Length; i++)
                s += bytes[i].ToString();
            return s;
        }
        private void PrepareShowingDataGeneration()
        {
            ShowDataGenerationProcess(95, "Preparing results...");
            ShowingDataGenerationResults();
            ShowDataGenerationProcess(100, "Finished!");

            // Test
            if (this._virusFragments == null)
                this._virusFragments = new TrainingData();
            if (this._benignFragments == null)
                this._benignFragments = new TrainingData();


            ShowDataGenerationProcess(100, string.Format("Number of virus fragments: {0}      Number of benign fragments : {1}", _virusFragments.Count, _benignFragments.Count));
        }



        private void _correctDetectorData()
        {

            int virusLen = 0;
            int benignLen = 0;

            if (cbCUseRate.Checked)
            {
                virusLen = _virusFragments.Count;

                String strRate = txtbCBenignVirusRate.Text;
                int rate = int.Parse(strRate);
                benignLen = virusLen * rate;
            }
            else
            {
                String strVirusLen = txtbCVirusSize.Text;
                virusLen = int.Parse(strVirusLen);

                String strBenignLen = txtbCBenignSize.Text;
                benignLen = int.Parse(strBenignLen);
            }

            // Select algorithm
            int inputCount = int.Parse(txtbCNumInputNeuron.Text);
            if (inputCount == 4)
            {
                _detectorData = Utils.Utils.mixDetectorBase10(_virusFragments, virusLen, _benignFragments, benignLen);
            }
            else
            {
                _detectorData = Utils.Utils.mixDetectorBase2(_virusFragments, virusLen, _benignFragments, benignLen);
            }

        }

        #endregion

        #region Clustering Method


        public void startClustering()
        {
            _clusteringManager.trainDistanceNetwork();
        }

        public void saveClusteringOutput(String fileName_)
        {
            _clusteringManager.saveDistanceNetwork(fileName_);
        }

        public void loadClusteringOutput(String fileName_)
        {
            _clusteringManager.loadDistanceNetwork(fileName_);
        }

        #endregion

        private void initDemo()
        {
            txtbDVirusFolder.Text = CustomSettings.DETECTOR_VIRUS_FOLDER;
            txtbDBenignFolder.Text = CustomSettings.DETECTOR_BENIGN_FOLDER;

            txtbVSTestFileFolder.Text = CustomSettings.TEST_VIRUS_FOLDER;

            txtbFCVirusFolder.Text = CustomSettings.FILE_CLASSIFIER_VIRUS_FOLDER;
            txtbFCBenignFolder.Text = CustomSettings.FILE_CLASSIFIER_BENIGN_FOLDER;

            txtbDDetectorFile.Text = CustomSettings.DETECTOR_FILE;
            txtbDBenignFile.Text = CustomSettings.BENIGN_FILE;
            txtbCMixDetectorFile.Text = CustomSettings.MIX_DETECTOR_FILE;
            txtbCClusteringFile.Text = CustomSettings.CLUSTERING_FILE;
            txtbFCFileClassifierFile.Text = CustomSettings.FILE_CLASSIFIER_FILE;

        }

        #endregion

        #region Gui Support Method

        // Add patch for gui to show the program is working
        private void _lkPatch()
        {
            Utils.Utils.GUI_SUPPORT = new GuiSupport(this);
        }

        private void _patchForProgressBar()
        {
            progressBar.Minimum = 0;
            progressBar.Maximum = Utils.Utils.GLOBAL_PROGRESSBAR_COUNT_MAX;
        }

        internal void updateProgressBarCallBack()
        {
            if (InvokeRequired)
            {
                MethodInvoker method = new MethodInvoker(updateProgressBarCallBack);
                Invoke(method);
                return;
            }
            progressBar.Value++;
        }

        internal void initProgressBarCallBack()
        {
            if (InvokeRequired)
            {
                MethodInvoker method = new MethodInvoker(initProgressBarCallBack);
                Invoke(method);
                return;
            }
            progressBar.Maximum = progressBar.Value + Utils.Utils.GLOBAL_PROGRESSBAR_COUNT_MAX;
            progressBar.Step = 1;
        }

        internal void updateVirusFragmentCallBack()
        {
            if (InvokeRequired)
            {
                MethodInvoker method = new MethodInvoker(updateVirusFragmentCallBack);
                Invoke(method);
                return;
            }
            txtbVirusFragmentsCount.Text = Utils.Utils.GLOBAL_VIRUS_COUNT.ToString();
        }
        #endregion

        private void rbtnDDetectorType_CheckedChanged(object sender, EventArgs e)
        {
            EDetectorType detectorType = EDetectorType.BuildDetector;
            if (rbtnDBuildDetector.Checked)
            {
                detectorType = EDetectorType.BuildDetector;
            }
            else
            {
                detectorType = EDetectorType.AdditionNegative;
            }

            _updateDetectorType(detectorType);

        }

        private void _updateDetectorType(EDetectorType detectorType)
        {
            switch (detectorType)
            {
                case EDetectorType.BuildDetector:
                    txtbDAdditionFolder.ReadOnly = true;
                    txtbDBenignFolder.ReadOnly = false;
                    txtbDVirusFolder.ReadOnly = false;
                    break;
                case EDetectorType.AdditionNegative:
                    txtbDAdditionFolder.ReadOnly = false;
                    txtbDBenignFolder.ReadOnly = true;
                    txtbDVirusFolder.ReadOnly = true;
                    break;
                default:
                    break;
            }
        }

        private void btnDBenignFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                txtbDBenignFile.Text = openFileDialog1.FileName;
            }
        }
    }
}
