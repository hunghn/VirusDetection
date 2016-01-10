
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
    enum PROGRESSSTATE { DATAGENERATION, LEARNING, AFFINITYGENERATION, DETECTING };
    public partial class FormMain : Form
    {
        // Declare variable
        private bool isWorking = false;
        private PROGRESSSTATE State;
        private DateTime startTime;
        private ManualResetEvent stopEvent = null;
        private Thread worker;

        private string VirusDirectory;
        private string BenignDirectory;

        // Data generation
        private int Length = 0;
        private int stepsize = 0;
        private int numberOfCluster = 0;
        private double ClusteringSelectionRate = 0.0;
        private bool UseHamming = false;
        private bool UseR = false;
        private int d = 0;
        private int r = 0;
        private DataGeneration datageneration;

        private TrainingData _virusFragments;
        private TrainingData _benignFragments;

        private double[][] _detectorData;

        private int[] Label;
        private List<byte[][]> GroupData = new List<byte[][]>();
        private List<Cluster> groups = new List<Cluster>();

        private DataTable NegativeSelectionData = new DataTable();
        private DataTable groupshowingDataTable = new DataTable();

        //represetation
        DataView dv, dv1;
        private DataSet dataSet = new DataSet();


        // LK Custom code
        ClusteringManager _clusteringManager;
        FileClassifierManager _fileClassifierManager;
        VirusScannerManager _virusScannerManager;


        public FormMain()
        {
            InitializeComponent();
            initDemo();
            _lkPatch();
        }

        
        #region Form Event
        private void btnBuildDetector_Click(object sender, EventArgs e)
        {
            // Reset value
            progressBar.Value = 0;
            txtbVirusFragmentsCount.Text = "0";

            if (isWorking)
                return;
            CheckState();
            switch (State)
            {
                case PROGRESSSTATE.DATAGENERATION:
                    DataGenerationStart();
                    pbStatus.Visible = false;
                    break;
                //case PROGRESSSTATE.LEARNING: DataLearningStart(); pbStatus.Visible = true; break;
                // case PROGRESSSTATE.AFFINITYGENERATION: ClassifierLearningStart(); pbStatus.Visible = false; break;
                //case PROGRESSSTATE.DETECTING: DetectingStart(); break;
            }
        }


        private void btnVirusDetect_Click(object sender, EventArgs e)
        {
            FolderSelectDialog folderSelectDialog = new FolderSelectDialog();
            folderSelectDialog.Title = "Select Folder";
            bool result = folderSelectDialog.ShowDialog();
            if (result)
            {
                txtbVirusFolder.Text = folderSelectDialog.FileName;
            }

        }

        private void btnBegin_Click(object sender, EventArgs e)
        {
            FolderSelectDialog folderSelectDialog = new FolderSelectDialog();
            folderSelectDialog.Title = "Select Folder";
            bool result = folderSelectDialog.ShowDialog();
            if (result)
            {
                txtbBenignFolder.Text = folderSelectDialog.FileName;
            }
            
        }

        private void btnDetect_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                txtbDetectorFile.Text = openFileDialog1.FileName;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!worker.IsAlive)
            {
                StopWork();
                isWorking = false;
                switch (State)
                {
                    case PROGRESSSTATE.DATAGENERATION:
                        PrepareShowingDataGeneration(); break;
                }
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {

        }

        private void btnCSaveMixDetector_Click(object sender, EventArgs e)
        {
            String savePath = txtbCMixDetectorFile.Text;
            Utils.Utils.saveMixDetector(_detectorData, savePath);
            MessageBox.Show("Successful!");
        }

        private void btnCLoadMixDetector_Click(object sender, EventArgs e)
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
            _initClustering();
            _clusteringManager.trainDistanceNetwork();
            LoadDangerLevel();
            MessageBox.Show("Successful!");

        }

        private void btnCPrintNeuron_Click(object sender, EventArgs e)
        {
            _clusteringManager.Test_PrintlnNeuron();
        }

        //hunghn
        public double GetIndexOfArray(double Element, double[][] Array)
        {
            for (int i = 0; i < Array.Length; i++)
            {
                if (Element == Array[i][1])
                {
                    return i;
                }
            }
            return -1;
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
                if(_fileClassifierManager._graphMap[i][1] == Utils.Utils.BENIGN_MARK)
                    chart1.Series["Benign"].Points.AddXY(i,_fileClassifierManager._graphMap[i][0]);
                else if (_fileClassifierManager._graphMap[i][1] == Utils.Utils.VIRUS_MARK)
                    chart1.Series["Virus"].Points.AddXY(i,_fileClassifierManager._graphMap[i][0]);
            }
        }

        private void LoadDangerLevel()
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
        private void btnBuildFileClassifier_Click(object sender, EventArgs e)
        {
            int numOfHiddenNeuron = int.Parse(txtbFCNumHiddenNeuron.Text);
            int numOfOutputNeuron = int.Parse(txtbCFNumOutputNeuron.Text);
            int numOfIterator = int.Parse(txtbCFNumIterator.Text);
            double errorThresold = double.Parse(txtbCFErrorThresold.Text);

            String virusFolder = txtbFCVirusFolder.Text;
            String benignFolder = txtbFCBenignFolder.Text;
            String formatRange = txtbCFFormatRange.Text;

            _fileClassifierManager = new FileClassifierManager(
                numOfHiddenNeuron,
                numOfOutputNeuron,
                numOfIterator,
                errorThresold,
                virusFolder,
                benignFolder,
                _clusteringManager.DistanceNetwork,
                formatRange
                );
            _fileClassifierManager.buildTrainingSet();
            LoadStyleChart();
            _fileClassifierManager.trainActiveNetwork1();
            MessageBox.Show("Successful!");
        }

        private void btnSaveFileClassifier_Click(object sender, EventArgs e)
        {
            String fileName = txtbFCFileClassifierFile.Text;
            _fileClassifierManager.saveActiveNetwork(fileName);
            MessageBox.Show("Successful!");
        }

        private void btnLoadFileClassifier_Click(object sender, EventArgs e)
        {
            if (_fileClassifierManager == null)
            {
                int numOfHiddenNeuron = int.Parse(txtbFCNumHiddenNeuron.Text);
                int numOfOutputNeuron = int.Parse(txtbCFNumOutputNeuron.Text);
                int numOfIterator = int.Parse(txtbCFNumIterator.Text);
                double errorThresold = double.Parse(txtbCFErrorThresold.Text);
                String virusFolder = txtbVirusFolder.Text;
                String benignFolder = txtbBenignFolder.Text;
                String formatRange = txtbCFFormatRange.Text;

                _fileClassifierManager = new FileClassifierManager(
                    numOfHiddenNeuron,
                    numOfOutputNeuron,
                    numOfIterator,
                    errorThresold,
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

        private void btnScanVirus_Click(object sender, EventArgs e)
        {
            _virusScannerManager = new VirusScannerManager(
                _fileClassifierManager.DistanceNetwork,
                _fileClassifierManager.ActivationNetwork,
                txtbCFFormatRange.Text
                );

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
            }

            txtbFCNumVirus.Text = numOfVirus.ToString();
            txtbFCNumBenign.Text = numOfBenign.ToString();
            Console.WriteLine("Virus: " + numOfVirus);
            Console.WriteLine("Benign: " + numOfBenign);
            view = new DataView(virusList);
            dgvVirus.DataSource = view;

        }

        private void btnFileClassifierFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.RestoreDirectory = true;
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                txtbFCFileClassifierFile.Text = openFileDialog1.FileName;
            }
        }

        private void cbxUseRate_CheckedChanged(object sender, EventArgs e)
        {
            txtbCBenignVirusRate.ReadOnly = !txtbCBenignVirusRate.ReadOnly;

            txtbCVirusSize.ReadOnly = !txtbCVirusSize.ReadOnly;
            txtbCBenignSize.ReadOnly = !txtbCBenignSize.ReadOnly;
        }

        private void btnCMixDetector_Click(object sender, EventArgs e)
        {
            _correctDetectorData();
            _calcNumOfDetector();
            MessageBox.Show("Successful!");
        }

        private void btnSaveDetector_Click(object sender, EventArgs e)
        {
            String virusSavePath = txtbDetectorFile.Text + "VR.txt";
            String benignSavePath = txtbDetectorFile.Text + "BN.txt";
            Utils.Utils.saveDetector(_virusFragments, virusSavePath, _benignFragments, benignSavePath);
            MessageBox.Show("Successful!");
        }

        private void btnLoadDetector_Click(object sender, EventArgs e)
        {
            String virusSavePath = txtbDetectorFile.Text + "VR.txt";
            String benignSavePath = txtbDetectorFile.Text + "BN.txt";
            Utils.Utils.loadDetector(ref _virusFragments, virusSavePath, ref _benignFragments, benignSavePath);
            ShowingData();
            MessageBox.Show("Successful!");
            btnLoadDetector.Enabled = false;
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


        #endregion

        #region Utils Method

        #region Detecter Method
        private void StartWork(bool stopable)
        {
            // set busy cursor
            this.Cursor = Cursors.WaitCursor;
            //
            btnStop.Enabled = stopable;
            progressBar.Value = 0;
            pbStatus.Value = 0;
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

        private void Run()
        {
            datageneration.run();
            this._virusFragments = datageneration.trainingDataOutput;
            this._benignFragments = datageneration.FileFragmentInput;
            ShowDataGenerationProcess(70, "Starting clustering process...");
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

        private void CheckState()
        {
            switch (tabMain.SelectedIndex)
            {
                case 0: State = PROGRESSSTATE.DATAGENERATION; break;
                case 1: State = PROGRESSSTATE.LEARNING; break;
                case 2: State = PROGRESSSTATE.AFFINITYGENERATION; break;
                case 3: State = PROGRESSSTATE.DETECTING; break;
            }
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
            worker = new Thread(Run);
            worker.Start();
        }

        private void GetInputDirectory()
        {
            VirusDirectory = txtbVirusFolder.Text;
            BenignDirectory = txtbBenignFolder.Text;
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
                Length = Math.Max(2, Math.Min(8, int.Parse(txtLength.Text)));
            }
            catch { Length = 4; }
            try
            {
                stepsize = Math.Max(2, Math.Min(8, int.Parse(txtStepSize.Text)));
                if (stepsize != Length / 2)
                    stepsize = Length / 2;
            }
            catch { stepsize = stepsize / 2; }
            //try
            //{
            //    numberOfCluster = Math.Max(2, Math.Min(50, int.Parse(txtNumberofCluster.Text)));
            //}
            //catch { Length = 4; }
            try
            {
                ClusteringSelectionRate = Math.Max(0.1, Math.Min(1.0, double.Parse(txtSelectionRate.Text)));
            }
            catch { ClusteringSelectionRate = 0.5; }
            UseHamming = ckbHamming.Checked;
            UseR = ckbRContiguos.Checked;
            if (UseHamming)
            {
                try
                {
                    d = Math.Max(0, Math.Min(Length * 8, int.Parse(txtHamming.Text)));
                }
                catch { d = Length / 2; }
            }
            if (UseR)
            {
                try
                {
                    r = Math.Max(0, Math.Min(Length * 8, int.Parse(txtContiguos.Text)));
                }
                catch { r = Length / 2; }
            }
        }


        private void ShowingDataGenerationResults()
        {
            GetgroupingData(datageneration.VirusFragmentInput, datageneration.state);
            GetgroupShowing();
            //dv = dataSet.Tables[0].DefaultView;
            //dtNegativeSelection.DataSource = dv;
            //dv1 = dataSet.Tables[1].DefaultView;
            //dtGroupView.DataSource = dv1;
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

        private void _initClustering()
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
        }

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
            String fileName = txtbCClusteringFile.Text;
            _clusteringManager.saveDistanceNetwork(fileName);
            MessageBox.Show("Successful!");
        }



        private void btnCLoad_Click(object sender, EventArgs e)
        {
            String fileName = txtbCClusteringFile.Text;

            if (_clusteringManager == null)
                _clusteringManager = new ClusteringManager();

            _clusteringManager.loadDistanceNetwork(fileName);
            txtbCNumInputNeuron.Text = _clusteringManager.NumInputNeuron.ToString();
           // txtbCNumOutputNeuron.Text = _clusteringManager.NumOutputNeron.ToString();
            
            
            MessageBox.Show("Successful!");
        }


        private void initDemo()
        {
            txtbVirusFolder.Text = CustomSettings.DETECTOR_VIRUS_FOLDER;
            txtbBenignFolder.Text = CustomSettings.DETECTOR_BENIGN_FOLDER;

            txtbVSTestFileFolder.Text = CustomSettings.TEST_VIRUS_FOLDER;

            txtbFCVirusFolder.Text = CustomSettings.FILE_CLASSIFIER_VIRUS_FOLDER;
            txtbFCBenignFolder.Text = CustomSettings.FILE_CLASSIFIER_BENIGN_FOLDER;

            txtbDetectorFile.Text = CustomSettings.DETECTOR_FILE;
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

        private void tabMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            int tabIndex = tabMain.SelectedIndex;
            if(tabIndex == 1) // Tab Clustering
            {
                
            }
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


    }
}
