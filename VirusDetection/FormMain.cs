
using Accord.MachineLearning;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using VirusDetection.Clustering;
using VirusDetection.Detector;
using VirusDetection.FileClassifier;
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

        private TrainingData VirusFragments;
        private TrainingData BenignFragments;

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
        }

        #region Form Event
        private void btnStart_Click(object sender, EventArgs e)
        {
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
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    txtVirusDirection.Text = fbd.SelectedPath;
                }
            }
        }

        private void btnBegin_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    txtBegin.Text = fbd.SelectedPath;
                }
            }
        }

        private void btnDetect_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                txtDetectorFile.Text = openFileDialog1.FileName;
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

        private void btnSaveDetector_Click(object sender, EventArgs e)
        {
            String savePath = txtDetectorFile.Text;
            Utils.Utils.saveDetector(_detectorData, savePath);
            MessageBox.Show("Successful!");
        }

        private void btnLoadDetector_Click(object sender, EventArgs e)
        {
            String fileName = txtDetectorFile.Text;
            _detectorData = Utils.Utils.loadDetector(fileName);
            MessageBox.Show("Successful!");
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
            progressBar2.Value = 0;
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
            this.VirusFragments = datageneration.trainingData;
            this.BenignFragments = datageneration.FileFragment;
            ShowDataGenerationProcess(70, "Starting clustering process...");
            //GroupData = Group(VirusFragments, 0, numberOfCluster);
            ShowDataGenerationProcess(90, "Data generation process has ended");

            _correctDetectorData();
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
            //this.Run();
            worker = new Thread(Run);
            worker.Start();
        }

        private void GetInputDirectory()
        {
            VirusDirectory = txtVirusDirection.Text;
            BenignDirectory = txtBegin.Text;
        }


        private void ShowDataGenerationProcess(int step, string discripts)
        {
            this.progressBar2.BeginInvoke((MethodInvoker)delegate() { this.progressBar2.Value = step; this.progressBar2.Refresh(); });
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
            try
            {
                numberOfCluster = Math.Max(2, Math.Min(50, int.Parse(txtNumberofCluster.Text)));
            }
            catch { Length = 4; }
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
            GetgroupingData(datageneration.VirusFragment, datageneration.state);
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
            dtGroupView.DataSource = view;
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
            ShowDataGenerationProcess(100, string.Format("Number of virus fragments: {0}      Number of benign fragments : {1}", VirusFragments.Count, BenignFragments.Count));
        }



        private void _correctDetectorData()
        {
            _detectorData = Utils.Utils.correctDetectorData(VirusFragments);
        }


        #endregion

        #region Clustering Method

        public void initClustering()
        {
            _clusteringManager = new ClusteringManager(_detectorData, 255, 10, 10);
        }
        public void startClustering()
        {
            _clusteringManager.trainNetwork();
        }

        public void saveClusteringOutput(String fileName_)
        {
            _clusteringManager.saveNetwork(fileName_);
        }

        public void loadClusteringOutput(String fileName_)
        {
            _clusteringManager.loadNetwork(fileName_);
        }

        #endregion

        private void btnClassifier_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.RestoreDirectory = true;
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                txtClusteringFile.Text = openFileDialog1.FileName;
            }

        }

        private void btnSaveClustering_Click(object sender, EventArgs e)
        {
            String fileName = txtClusteringFile.Text;
            _clusteringManager.saveNetwork(fileName);
            MessageBox.Show("Successful!");
        }

        

        private void btnLoad_Click(object sender, EventArgs e)
        {
            String fileName = txtClusteringFile.Text;
            if (_clusteringManager == null)
                initClustering();
            _clusteringManager.loadNetwork(fileName);
            MessageBox.Show("Successful!");
        }


        private void initDemo()
        {
            txtVirusDirection.Text = @"D:\TestVirus\Virus";
            txtBegin.Text = @"D:\TestVirus\Benign";
            txtDetectorFile.Text = @"D:\TestVirus\Detector.txt";
            txtClusteringFile.Text = @"D:\TestVirus\Clustering.txt";
        }


        

        #endregion

        private void btnStartClustering_Click(object sender, EventArgs e)
        {
            if (_clusteringManager == null)
                initClustering();
            _clusteringManager.trainNetwork();
            MessageBox.Show("Successful!");
        }

        private void btnPrintNeuron_Click(object sender, EventArgs e)
        {
            _clusteringManager.printlnNeuron();
        }

        private void btnBuildFileClassifier_Click(object sender, EventArgs e)
        {
            _fileClassifierManager = new FileClassifierManager(txtVirusDirection.Text, txtBegin.Text, _clusteringManager.DistanceNetwork);
            _fileClassifierManager.train(500, 0.2);
        }

        private void btnSaveFileClassifier_Click(object sender, EventArgs e)
        {
            String fileName = @"D:\TestVirus\FileClassifier.txt";
            _fileClassifierManager.saveClassifierNetwork(fileName);
        }

        private void btnLoadFileClassifier_Click(object sender, EventArgs e)
        {
            if (_fileClassifierManager == null)
                _fileClassifierManager = new FileClassifierManager(txtVirusDirection.Text, txtBegin.Text, _clusteringManager.DistanceNetwork);
            String fileName = @"D:\TestVirus\FileClassifier.txt";
            _fileClassifierManager.loadClassifierNetwork(fileName);
        }

        private void btnScanVirus_Click(object sender, EventArgs e)
        {
            _virusScannerManager = new VirusScannerManager(_fileClassifierManager.DistanceNetwork, _fileClassifierManager.ActivationNetwork);

            String[] virusFile = Directory.GetFiles(txtVirusDirection.Text, "*.*", SearchOption.AllDirectories);

            foreach (String file in virusFile)
            {
                int result = _virusScannerManager.scanFile(file);
                Console.WriteLine(result);
            }
        }
    }
}
