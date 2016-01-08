namespace VirusDetection
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtbVirusFragmentsCount = new System.Windows.Forms.TextBox();
            this.txtStatusBar = new System.Windows.Forms.TextBox();
            this.txtTimeBox = new System.Windows.Forms.TextBox();
            this.pbStatus = new System.Windows.Forms.ProgressBar();
            this.panelRight = new System.Windows.Forms.Panel();
            this.grbOutput = new System.Windows.Forms.GroupBox();
            this.btnLoadDetector = new System.Windows.Forms.Button();
            this.btnSaveDetector = new System.Windows.Forms.Button();
            this.grbIO = new System.Windows.Forms.GroupBox();
            this.txtbDetectorFile = new System.Windows.Forms.TextBox();
            this.btnDetectorFile = new System.Windows.Forms.Button();
            this.txtbBenignFolder = new System.Windows.Forms.TextBox();
            this.btnBegin = new System.Windows.Forms.Button();
            this.txtbVirusFolder = new System.Windows.Forms.TextBox();
            this.btnVirusDetect = new System.Windows.Forms.Button();
            this.grbActions = new System.Windows.Forms.GroupBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnBuildDetector = new System.Windows.Forms.Button();
            this.txtbCMixDetectorFile = new System.Windows.Forms.TextBox();
            this.btnCMixDetectorFile = new System.Windows.Forms.Button();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabpgDetector = new System.Windows.Forms.TabPage();
            this.dtGroupView = new System.Windows.Forms.DataGridView();
            this.dtNegativeSelection = new System.Windows.Forms.DataGridView();
            this.panelTabRight = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtContiguos = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ckbRContiguos = new System.Windows.Forms.CheckBox();
            this.txtHamming = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ckbHamming = new System.Windows.Forms.CheckBox();
            this.txtSelectionRate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNumberofCluster = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtStepSize = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabpgClustering = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label32 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.txtbCTotalBenign = new System.Windows.Forms.TextBox();
            this.txtbCTotalVirus = new System.Windows.Forms.TextBox();
            this.btnCClusteringFile = new System.Windows.Forms.Button();
            this.btnCSave = new System.Windows.Forms.Button();
            this.btnCLoad = new System.Windows.Forms.Button();
            this.txtbCClusteringFile = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label31 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.btnCLoadMixDetector = new System.Windows.Forms.Button();
            this.txtbCLearningRadius = new System.Windows.Forms.TextBox();
            this.btnCSaveMixDetector = new System.Windows.Forms.Button();
            this.label28 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.txtbCLearningRate = new System.Windows.Forms.TextBox();
            this.txtbCNumOutputNeuron = new System.Windows.Forms.TextBox();
            this.btnCMixDetector = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtbCBenignSize = new System.Windows.Forms.TextBox();
            this.txtbCNumInputNeuron = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtbCVirusSize = new System.Windows.Forms.TextBox();
            this.txtbCErrorThresold = new System.Windows.Forms.TextBox();
            this.cbCUseRate = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtbCNumIterator = new System.Windows.Forms.TextBox();
            this.txtbCBenignVirusRate = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtbCNumNeuronY = new System.Windows.Forms.TextBox();
            this.txtbCNumNeuronX = new System.Windows.Forms.TextBox();
            this.btnCPrintNeuron = new System.Windows.Forms.Button();
            this.btnCStartClustering = new System.Windows.Forms.Button();
            this.tabpgFileClassifier = new System.Windows.Forms.TabPage();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.btnFCLoad = new System.Windows.Forms.Button();
            this.btnFCFileClassifierFile = new System.Windows.Forms.Button();
            this.btnFCSave = new System.Windows.Forms.Button();
            this.txtbFCFileClassifierFile = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.btnFCBenignFolder = new System.Windows.Forms.Button();
            this.txtbCFFormatRange = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtbCFErrorThresold = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.btnFCStartFileClassifier = new System.Windows.Forms.Button();
            this.txtbCFNumOutputNeuron = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txtbCFNumIterator = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtbFCBenignFolder = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.txtbFCVirusFolder = new System.Windows.Forms.TextBox();
            this.btnFCVirusFolder = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.txtbFCNumHiddenNeuron = new System.Windows.Forms.TextBox();
            this.tabPgVirusScanner = new System.Windows.Forms.TabPage();
            this.label30 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtbFCNumBenign = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtbFCNumVirus = new System.Windows.Forms.TextBox();
            this.txtbVSTestFileFolder = new System.Windows.Forms.TextBox();
            this.btnFCTestFileFolder = new System.Windows.Forms.Button();
            this.btnFCScanVirus = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelFooter.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelRight.SuspendLayout();
            this.grbOutput.SuspendLayout();
            this.grbIO.SuspendLayout();
            this.grbActions.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.tabpgDetector.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGroupView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNegativeSelection)).BeginInit();
            this.panelTabRight.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabpgClustering.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabpgFileClassifier.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel3.SuspendLayout();
            this.tabPgVirusScanner.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelFooter
            // 
            this.panelFooter.BackColor = System.Drawing.SystemColors.Control;
            this.panelFooter.Controls.Add(this.progressBar);
            this.panelFooter.Controls.Add(this.panel1);
            this.panelFooter.Controls.Add(this.pbStatus);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(5, 504);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Padding = new System.Windows.Forms.Padding(5);
            this.panelFooter.Size = new System.Drawing.Size(952, 84);
            this.panelFooter.TabIndex = 1;
            // 
            // progressBar
            // 
            this.progressBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.progressBar.Location = new System.Drawing.Point(5, 59);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(942, 23);
            this.progressBar.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtbVirusFragmentsCount);
            this.panel1.Controls.Add(this.txtStatusBar);
            this.panel1.Controls.Add(this.txtTimeBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(5, 28);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.panel1.Size = new System.Drawing.Size(942, 31);
            this.panel1.TabIndex = 1;
            // 
            // txtbVirusFragmentsCount
            // 
            this.txtbVirusFragmentsCount.Dock = System.Windows.Forms.DockStyle.Right;
            this.txtbVirusFragmentsCount.Location = new System.Drawing.Point(846, 5);
            this.txtbVirusFragmentsCount.Name = "txtbVirusFragmentsCount";
            this.txtbVirusFragmentsCount.ReadOnly = true;
            this.txtbVirusFragmentsCount.Size = new System.Drawing.Size(96, 20);
            this.txtbVirusFragmentsCount.TabIndex = 2;
            // 
            // txtStatusBar
            // 
            this.txtStatusBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtStatusBar.Location = new System.Drawing.Point(181, 5);
            this.txtStatusBar.Name = "txtStatusBar";
            this.txtStatusBar.ReadOnly = true;
            this.txtStatusBar.Size = new System.Drawing.Size(761, 20);
            this.txtStatusBar.TabIndex = 1;
            // 
            // txtTimeBox
            // 
            this.txtTimeBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtTimeBox.Location = new System.Drawing.Point(0, 5);
            this.txtTimeBox.Name = "txtTimeBox";
            this.txtTimeBox.ReadOnly = true;
            this.txtTimeBox.Size = new System.Drawing.Size(181, 20);
            this.txtTimeBox.TabIndex = 0;
            // 
            // pbStatus
            // 
            this.pbStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbStatus.Location = new System.Drawing.Point(5, 5);
            this.pbStatus.Name = "pbStatus";
            this.pbStatus.Size = new System.Drawing.Size(942, 23);
            this.pbStatus.TabIndex = 0;
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.SystemColors.Control;
            this.panelRight.Controls.Add(this.grbOutput);
            this.panelRight.Controls.Add(this.grbIO);
            this.panelRight.Controls.Add(this.grbActions);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelRight.Location = new System.Drawing.Point(5, 5);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(200, 499);
            this.panelRight.TabIndex = 2;
            // 
            // grbOutput
            // 
            this.grbOutput.Controls.Add(this.btnLoadDetector);
            this.grbOutput.Controls.Add(this.btnSaveDetector);
            this.grbOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbOutput.Location = new System.Drawing.Point(0, 408);
            this.grbOutput.Name = "grbOutput";
            this.grbOutput.Size = new System.Drawing.Size(200, 91);
            this.grbOutput.TabIndex = 2;
            this.grbOutput.TabStop = false;
            this.grbOutput.Text = "Output";
            // 
            // btnLoadDetector
            // 
            this.btnLoadDetector.Location = new System.Drawing.Point(15, 54);
            this.btnLoadDetector.Name = "btnLoadDetector";
            this.btnLoadDetector.Size = new System.Drawing.Size(171, 29);
            this.btnLoadDetector.TabIndex = 11;
            this.btnLoadDetector.Text = "Load Detector";
            this.btnLoadDetector.UseVisualStyleBackColor = true;
            this.btnLoadDetector.Click += new System.EventHandler(this.btnLoadDetector_Click);
            // 
            // btnSaveDetector
            // 
            this.btnSaveDetector.Location = new System.Drawing.Point(15, 19);
            this.btnSaveDetector.Name = "btnSaveDetector";
            this.btnSaveDetector.Size = new System.Drawing.Size(171, 29);
            this.btnSaveDetector.TabIndex = 10;
            this.btnSaveDetector.Text = "Save Detector";
            this.btnSaveDetector.UseVisualStyleBackColor = true;
            this.btnSaveDetector.Click += new System.EventHandler(this.btnSaveDetector_Click);
            // 
            // grbIO
            // 
            this.grbIO.Controls.Add(this.txtbDetectorFile);
            this.grbIO.Controls.Add(this.btnDetectorFile);
            this.grbIO.Controls.Add(this.txtbBenignFolder);
            this.grbIO.Controls.Add(this.btnBegin);
            this.grbIO.Controls.Add(this.txtbVirusFolder);
            this.grbIO.Controls.Add(this.btnVirusDetect);
            this.grbIO.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbIO.Location = new System.Drawing.Point(0, 145);
            this.grbIO.Name = "grbIO";
            this.grbIO.Size = new System.Drawing.Size(200, 263);
            this.grbIO.TabIndex = 1;
            this.grbIO.TabStop = false;
            this.grbIO.Text = "I/O";
            // 
            // txtbDetectorFile
            // 
            this.txtbDetectorFile.Location = new System.Drawing.Point(15, 175);
            this.txtbDetectorFile.Name = "txtbDetectorFile";
            this.txtbDetectorFile.Size = new System.Drawing.Size(171, 20);
            this.txtbDetectorFile.TabIndex = 7;
            // 
            // btnDetectorFile
            // 
            this.btnDetectorFile.Location = new System.Drawing.Point(15, 140);
            this.btnDetectorFile.Name = "btnDetectorFile";
            this.btnDetectorFile.Size = new System.Drawing.Size(171, 29);
            this.btnDetectorFile.TabIndex = 6;
            this.btnDetectorFile.Text = "Detector File";
            this.btnDetectorFile.UseVisualStyleBackColor = true;
            this.btnDetectorFile.Click += new System.EventHandler(this.btnDetect_Click);
            // 
            // txtbBenignFolder
            // 
            this.txtbBenignFolder.Location = new System.Drawing.Point(15, 114);
            this.txtbBenignFolder.Name = "txtbBenignFolder";
            this.txtbBenignFolder.Size = new System.Drawing.Size(171, 20);
            this.txtbBenignFolder.TabIndex = 5;
            // 
            // btnBegin
            // 
            this.btnBegin.Location = new System.Drawing.Point(15, 79);
            this.btnBegin.Name = "btnBegin";
            this.btnBegin.Size = new System.Drawing.Size(171, 29);
            this.btnBegin.TabIndex = 4;
            this.btnBegin.Text = "Begin Directory";
            this.btnBegin.UseVisualStyleBackColor = true;
            this.btnBegin.Click += new System.EventHandler(this.btnBegin_Click);
            // 
            // txtbVirusFolder
            // 
            this.txtbVirusFolder.Location = new System.Drawing.Point(15, 53);
            this.txtbVirusFolder.Name = "txtbVirusFolder";
            this.txtbVirusFolder.Size = new System.Drawing.Size(171, 20);
            this.txtbVirusFolder.TabIndex = 3;
            // 
            // btnVirusDetect
            // 
            this.btnVirusDetect.Location = new System.Drawing.Point(15, 17);
            this.btnVirusDetect.Name = "btnVirusDetect";
            this.btnVirusDetect.Size = new System.Drawing.Size(171, 29);
            this.btnVirusDetect.TabIndex = 2;
            this.btnVirusDetect.Text = "Virus Directory";
            this.btnVirusDetect.UseVisualStyleBackColor = true;
            this.btnVirusDetect.Click += new System.EventHandler(this.btnVirusDetect_Click);
            // 
            // grbActions
            // 
            this.grbActions.Controls.Add(this.btnStop);
            this.grbActions.Controls.Add(this.btnBuildDetector);
            this.grbActions.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbActions.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.grbActions.Location = new System.Drawing.Point(0, 0);
            this.grbActions.Name = "grbActions";
            this.grbActions.Size = new System.Drawing.Size(200, 145);
            this.grbActions.TabIndex = 0;
            this.grbActions.TabStop = false;
            this.grbActions.Text = "Actions";
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(15, 101);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(171, 29);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "Stop scan";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnBuildDetector
            // 
            this.btnBuildDetector.Location = new System.Drawing.Point(15, 36);
            this.btnBuildDetector.Name = "btnBuildDetector";
            this.btnBuildDetector.Size = new System.Drawing.Size(171, 29);
            this.btnBuildDetector.TabIndex = 0;
            this.btnBuildDetector.Text = "Build Detector";
            this.btnBuildDetector.UseVisualStyleBackColor = true;
            this.btnBuildDetector.Click += new System.EventHandler(this.btnBuildDetector_Click);
            // 
            // txtbCMixDetectorFile
            // 
            this.txtbCMixDetectorFile.Location = new System.Drawing.Point(153, 149);
            this.txtbCMixDetectorFile.Name = "txtbCMixDetectorFile";
            this.txtbCMixDetectorFile.Size = new System.Drawing.Size(207, 20);
            this.txtbCMixDetectorFile.TabIndex = 9;
            // 
            // btnCMixDetectorFile
            // 
            this.btnCMixDetectorFile.Location = new System.Drawing.Point(366, 149);
            this.btnCMixDetectorFile.Name = "btnCMixDetectorFile";
            this.btnCMixDetectorFile.Size = new System.Drawing.Size(32, 21);
            this.btnCMixDetectorFile.TabIndex = 8;
            this.btnCMixDetectorFile.Text = "...";
            this.btnCMixDetectorFile.UseVisualStyleBackColor = true;
            this.btnCMixDetectorFile.Click += new System.EventHandler(this.btnCMixDetectorFile_Click);
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabpgDetector);
            this.tabMain.Controls.Add(this.tabpgClustering);
            this.tabMain.Controls.Add(this.tabpgFileClassifier);
            this.tabMain.Controls.Add(this.tabPgVirusScanner);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Location = new System.Drawing.Point(205, 5);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(752, 499);
            this.tabMain.TabIndex = 3;
            this.tabMain.SelectedIndexChanged += new System.EventHandler(this.tabMain_SelectedIndexChanged);
            // 
            // tabpgDetector
            // 
            this.tabpgDetector.Controls.Add(this.dtGroupView);
            this.tabpgDetector.Controls.Add(this.dtNegativeSelection);
            this.tabpgDetector.Controls.Add(this.panelTabRight);
            this.tabpgDetector.Location = new System.Drawing.Point(4, 22);
            this.tabpgDetector.Name = "tabpgDetector";
            this.tabpgDetector.Padding = new System.Windows.Forms.Padding(3);
            this.tabpgDetector.Size = new System.Drawing.Size(744, 473);
            this.tabpgDetector.TabIndex = 0;
            this.tabpgDetector.Text = "Detector";
            this.tabpgDetector.UseVisualStyleBackColor = true;
            // 
            // dtGroupView
            // 
            this.dtGroupView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGroupView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGroupView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtGroupView.Location = new System.Drawing.Point(203, 279);
            this.dtGroupView.Name = "dtGroupView";
            this.dtGroupView.Size = new System.Drawing.Size(538, 191);
            this.dtGroupView.TabIndex = 4;
            // 
            // dtNegativeSelection
            // 
            this.dtNegativeSelection.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtNegativeSelection.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtNegativeSelection.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtNegativeSelection.Location = new System.Drawing.Point(203, 3);
            this.dtNegativeSelection.Name = "dtNegativeSelection";
            this.dtNegativeSelection.Size = new System.Drawing.Size(538, 276);
            this.dtNegativeSelection.TabIndex = 3;
            // 
            // panelTabRight
            // 
            this.panelTabRight.BackColor = System.Drawing.SystemColors.Control;
            this.panelTabRight.Controls.Add(this.groupBox1);
            this.panelTabRight.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelTabRight.Location = new System.Drawing.Point(3, 3);
            this.panelTabRight.Name = "panelTabRight";
            this.panelTabRight.Size = new System.Drawing.Size(200, 467);
            this.panelTabRight.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtContiguos);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.ckbRContiguos);
            this.groupBox1.Controls.Add(this.txtHamming);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.ckbHamming);
            this.groupBox1.Controls.Add(this.txtSelectionRate);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtNumberofCluster);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtStepSize);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtLength);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 467);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parameter";
            // 
            // txtContiguos
            // 
            this.txtContiguos.Location = new System.Drawing.Point(72, 256);
            this.txtContiguos.Name = "txtContiguos";
            this.txtContiguos.Size = new System.Drawing.Size(113, 20);
            this.txtContiguos.TabIndex = 14;
            this.txtContiguos.Text = "12";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 259);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(10, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "r";
            // 
            // ckbRContiguos
            // 
            this.ckbRContiguos.AutoSize = true;
            this.ckbRContiguos.Checked = true;
            this.ckbRContiguos.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbRContiguos.Location = new System.Drawing.Point(10, 231);
            this.ckbRContiguos.Name = "ckbRContiguos";
            this.ckbRContiguos.Size = new System.Drawing.Size(129, 17);
            this.ckbRContiguos.TabIndex = 12;
            this.ckbRContiguos.Text = "R Contiguos Distance";
            this.ckbRContiguos.UseVisualStyleBackColor = true;
            // 
            // txtHamming
            // 
            this.txtHamming.Location = new System.Drawing.Point(72, 197);
            this.txtHamming.Name = "txtHamming";
            this.txtHamming.Size = new System.Drawing.Size(113, 20);
            this.txtHamming.TabIndex = 11;
            this.txtHamming.Text = "10";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "d";
            // 
            // ckbHamming
            // 
            this.ckbHamming.AutoSize = true;
            this.ckbHamming.Checked = true;
            this.ckbHamming.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbHamming.Location = new System.Drawing.Point(10, 172);
            this.ckbHamming.Name = "ckbHamming";
            this.ckbHamming.Size = new System.Drawing.Size(115, 17);
            this.ckbHamming.TabIndex = 9;
            this.ckbHamming.Text = "Hamming Distance";
            this.ckbHamming.UseVisualStyleBackColor = true;
            // 
            // txtSelectionRate
            // 
            this.txtSelectionRate.Location = new System.Drawing.Point(72, 142);
            this.txtSelectionRate.Name = "txtSelectionRate";
            this.txtSelectionRate.Size = new System.Drawing.Size(113, 20);
            this.txtSelectionRate.TabIndex = 7;
            this.txtSelectionRate.Text = "0.5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Selection Rate";
            // 
            // txtNumberofCluster
            // 
            this.txtNumberofCluster.Location = new System.Drawing.Point(72, 100);
            this.txtNumberofCluster.Name = "txtNumberofCluster";
            this.txtNumberofCluster.Size = new System.Drawing.Size(113, 20);
            this.txtNumberofCluster.TabIndex = 5;
            this.txtNumberofCluster.Text = "50";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Number of cluster";
            // 
            // txtStepSize
            // 
            this.txtStepSize.Location = new System.Drawing.Point(72, 49);
            this.txtStepSize.Name = "txtStepSize";
            this.txtStepSize.Size = new System.Drawing.Size(113, 20);
            this.txtStepSize.TabIndex = 3;
            this.txtStepSize.Text = "2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Step Size";
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(72, 23);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(113, 20);
            this.txtLength.TabIndex = 1;
            this.txtLength.Text = "4";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Length";
            // 
            // tabpgClustering
            // 
            this.tabpgClustering.Controls.Add(this.panel2);
            this.tabpgClustering.Controls.Add(this.groupBox2);
            this.tabpgClustering.Location = new System.Drawing.Point(4, 22);
            this.tabpgClustering.Name = "tabpgClustering";
            this.tabpgClustering.Padding = new System.Windows.Forms.Padding(3);
            this.tabpgClustering.Size = new System.Drawing.Size(744, 473);
            this.tabpgClustering.TabIndex = 1;
            this.tabpgClustering.Text = "Clustering";
            this.tabpgClustering.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label32);
            this.panel2.Controls.Add(this.label26);
            this.panel2.Controls.Add(this.label25);
            this.panel2.Controls.Add(this.txtbCTotalBenign);
            this.panel2.Controls.Add(this.txtbCTotalVirus);
            this.panel2.Controls.Add(this.btnCClusteringFile);
            this.panel2.Controls.Add(this.btnCSave);
            this.panel2.Controls.Add(this.btnCLoad);
            this.panel2.Controls.Add(this.txtbCClusteringFile);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(413, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(328, 467);
            this.panel2.TabIndex = 1;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(20, 399);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(72, 13);
            this.label32.TabIndex = 30;
            this.label32.Text = "Clustering File";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(46, 155);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(57, 13);
            this.label26.TabIndex = 29;
            this.label26.Text = "Total Virus";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(46, 180);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(67, 13);
            this.label25.TabIndex = 28;
            this.label25.Text = "Total Benign";
            // 
            // txtbCTotalBenign
            // 
            this.txtbCTotalBenign.Location = new System.Drawing.Point(124, 177);
            this.txtbCTotalBenign.Name = "txtbCTotalBenign";
            this.txtbCTotalBenign.ReadOnly = true;
            this.txtbCTotalBenign.Size = new System.Drawing.Size(99, 20);
            this.txtbCTotalBenign.TabIndex = 9;
            // 
            // txtbCTotalVirus
            // 
            this.txtbCTotalVirus.Location = new System.Drawing.Point(124, 152);
            this.txtbCTotalVirus.Name = "txtbCTotalVirus";
            this.txtbCTotalVirus.ReadOnly = true;
            this.txtbCTotalVirus.Size = new System.Drawing.Size(99, 20);
            this.txtbCTotalVirus.TabIndex = 8;
            // 
            // btnCClusteringFile
            // 
            this.btnCClusteringFile.Location = new System.Drawing.Point(275, 394);
            this.btnCClusteringFile.Name = "btnCClusteringFile";
            this.btnCClusteringFile.Size = new System.Drawing.Size(32, 22);
            this.btnCClusteringFile.TabIndex = 2;
            this.btnCClusteringFile.Text = "...";
            this.btnCClusteringFile.UseVisualStyleBackColor = true;
            this.btnCClusteringFile.Click += new System.EventHandler(this.btnCClusteringFile_Click);
            // 
            // btnCSave
            // 
            this.btnCSave.Location = new System.Drawing.Point(64, 426);
            this.btnCSave.Name = "btnCSave";
            this.btnCSave.Size = new System.Drawing.Size(99, 22);
            this.btnCSave.TabIndex = 0;
            this.btnCSave.Text = "Save";
            this.btnCSave.UseVisualStyleBackColor = true;
            this.btnCSave.Click += new System.EventHandler(this.btnCSave_Click);
            // 
            // btnCLoad
            // 
            this.btnCLoad.Location = new System.Drawing.Point(170, 426);
            this.btnCLoad.Name = "btnCLoad";
            this.btnCLoad.Size = new System.Drawing.Size(99, 22);
            this.btnCLoad.TabIndex = 1;
            this.btnCLoad.Text = "Load";
            this.btnCLoad.UseVisualStyleBackColor = true;
            this.btnCLoad.Click += new System.EventHandler(this.btnCLoad_Click);
            // 
            // txtbCClusteringFile
            // 
            this.txtbCClusteringFile.Location = new System.Drawing.Point(101, 396);
            this.txtbCClusteringFile.Name = "txtbCClusteringFile";
            this.txtbCClusteringFile.Size = new System.Drawing.Size(168, 20);
            this.txtbCClusteringFile.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label31);
            this.groupBox2.Controls.Add(this.label27);
            this.groupBox2.Controls.Add(this.btnCLoadMixDetector);
            this.groupBox2.Controls.Add(this.txtbCLearningRadius);
            this.groupBox2.Controls.Add(this.btnCSaveMixDetector);
            this.groupBox2.Controls.Add(this.label28);
            this.groupBox2.Controls.Add(this.label23);
            this.groupBox2.Controls.Add(this.txtbCMixDetectorFile);
            this.groupBox2.Controls.Add(this.txtbCLearningRate);
            this.groupBox2.Controls.Add(this.txtbCNumOutputNeuron);
            this.groupBox2.Controls.Add(this.btnCMixDetectorFile);
            this.groupBox2.Controls.Add(this.btnCMixDetector);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.txtbCBenignSize);
            this.groupBox2.Controls.Add(this.txtbCNumInputNeuron);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.txtbCVirusSize);
            this.groupBox2.Controls.Add(this.txtbCErrorThresold);
            this.groupBox2.Controls.Add(this.cbCUseRate);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtbCNumIterator);
            this.groupBox2.Controls.Add(this.txtbCBenignVirusRate);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtbCNumNeuronY);
            this.groupBox2.Controls.Add(this.txtbCNumNeuronX);
            this.groupBox2.Controls.Add(this.btnCPrintNeuron);
            this.groupBox2.Controls.Add(this.btnCStartClustering);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(410, 467);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Function";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(25, 153);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(86, 13);
            this.label31.TabIndex = 37;
            this.label31.Text = "Mix Detector File";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(25, 354);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(84, 13);
            this.label27.TabIndex = 36;
            this.label27.Text = "Learning Radius";
            // 
            // btnCLoadMixDetector
            // 
            this.btnCLoadMixDetector.Location = new System.Drawing.Point(217, 180);
            this.btnCLoadMixDetector.Name = "btnCLoadMixDetector";
            this.btnCLoadMixDetector.Size = new System.Drawing.Size(104, 22);
            this.btnCLoadMixDetector.TabIndex = 11;
            this.btnCLoadMixDetector.Text = "Load Mix Detector";
            this.btnCLoadMixDetector.UseVisualStyleBackColor = true;
            this.btnCLoadMixDetector.Click += new System.EventHandler(this.btnCLoadMixDetector_Click);
            // 
            // txtbCLearningRadius
            // 
            this.txtbCLearningRadius.Location = new System.Drawing.Point(135, 347);
            this.txtbCLearningRadius.Name = "txtbCLearningRadius";
            this.txtbCLearningRadius.Size = new System.Drawing.Size(99, 20);
            this.txtbCLearningRadius.TabIndex = 35;
            this.txtbCLearningRadius.Text = "4";
            // 
            // btnCSaveMixDetector
            // 
            this.btnCSaveMixDetector.Location = new System.Drawing.Point(98, 180);
            this.btnCSaveMixDetector.Name = "btnCSaveMixDetector";
            this.btnCSaveMixDetector.Size = new System.Drawing.Size(113, 23);
            this.btnCSaveMixDetector.TabIndex = 10;
            this.btnCSaveMixDetector.Text = "Save Mix Detector";
            this.btnCSaveMixDetector.UseVisualStyleBackColor = true;
            this.btnCSaveMixDetector.Click += new System.EventHandler(this.btnCSaveMixDetector_Click);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(25, 330);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(74, 13);
            this.label28.TabIndex = 34;
            this.label28.Text = "Learning Rate";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(25, 253);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(102, 13);
            this.label23.TabIndex = 32;
            this.label23.Text = "Num Output Neuron";
            // 
            // txtbCLearningRate
            // 
            this.txtbCLearningRate.Location = new System.Drawing.Point(135, 323);
            this.txtbCLearningRate.Name = "txtbCLearningRate";
            this.txtbCLearningRate.Size = new System.Drawing.Size(99, 20);
            this.txtbCLearningRate.TabIndex = 33;
            this.txtbCLearningRate.Text = "0.3";
            // 
            // txtbCNumOutputNeuron
            // 
            this.txtbCNumOutputNeuron.Location = new System.Drawing.Point(135, 250);
            this.txtbCNumOutputNeuron.Name = "txtbCNumOutputNeuron";
            this.txtbCNumOutputNeuron.ReadOnly = true;
            this.txtbCNumOutputNeuron.Size = new System.Drawing.Size(99, 20);
            this.txtbCNumOutputNeuron.TabIndex = 31;
            // 
            // btnCMixDetector
            // 
            this.btnCMixDetector.Location = new System.Drawing.Point(98, 104);
            this.btnCMixDetector.Name = "btnCMixDetector";
            this.btnCMixDetector.Size = new System.Drawing.Size(92, 23);
            this.btnCMixDetector.TabIndex = 30;
            this.btnCMixDetector.Text = "Mix Detector";
            this.btnCMixDetector.UseVisualStyleBackColor = true;
            this.btnCMixDetector.Click += new System.EventHandler(this.btnCMixDetector_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(25, 75);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 13);
            this.label10.TabIndex = 29;
            this.label10.Text = "Benign Size";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(25, 229);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(94, 13);
            this.label15.TabIndex = 29;
            this.label15.Text = "Num Input Neuron";
            // 
            // txtbCBenignSize
            // 
            this.txtbCBenignSize.Location = new System.Drawing.Point(153, 72);
            this.txtbCBenignSize.Name = "txtbCBenignSize";
            this.txtbCBenignSize.ReadOnly = true;
            this.txtbCBenignSize.Size = new System.Drawing.Size(112, 20);
            this.txtbCBenignSize.TabIndex = 28;
            // 
            // txtbCNumInputNeuron
            // 
            this.txtbCNumInputNeuron.Location = new System.Drawing.Point(135, 226);
            this.txtbCNumInputNeuron.Name = "txtbCNumInputNeuron";
            this.txtbCNumInputNeuron.Size = new System.Drawing.Size(99, 20);
            this.txtbCNumInputNeuron.TabIndex = 28;
            this.txtbCNumInputNeuron.Text = "4";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "Virus Size";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(25, 403);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(73, 13);
            this.label14.TabIndex = 27;
            this.label14.Text = "Error Thresold";
            // 
            // txtbCVirusSize
            // 
            this.txtbCVirusSize.Location = new System.Drawing.Point(153, 46);
            this.txtbCVirusSize.Name = "txtbCVirusSize";
            this.txtbCVirusSize.ReadOnly = true;
            this.txtbCVirusSize.Size = new System.Drawing.Size(112, 20);
            this.txtbCVirusSize.TabIndex = 26;
            // 
            // txtbCErrorThresold
            // 
            this.txtbCErrorThresold.Location = new System.Drawing.Point(135, 396);
            this.txtbCErrorThresold.Name = "txtbCErrorThresold";
            this.txtbCErrorThresold.Size = new System.Drawing.Size(99, 20);
            this.txtbCErrorThresold.TabIndex = 26;
            this.txtbCErrorThresold.Text = "0.2";
            // 
            // cbCUseRate
            // 
            this.cbCUseRate.AutoSize = true;
            this.cbCUseRate.Checked = true;
            this.cbCUseRate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbCUseRate.Location = new System.Drawing.Point(28, 23);
            this.cbCUseRate.Name = "cbCUseRate";
            this.cbCUseRate.Size = new System.Drawing.Size(71, 17);
            this.cbCUseRate.TabIndex = 25;
            this.cbCUseRate.Text = "Use Rate";
            this.cbCUseRate.UseVisualStyleBackColor = true;
            this.cbCUseRate.CheckedChanged += new System.EventHandler(this.cbxUseRate_CheckedChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(25, 379);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 13);
            this.label13.TabIndex = 25;
            this.label13.Text = "Num Iterator";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(113, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Benign/Virus";
            // 
            // txtbCNumIterator
            // 
            this.txtbCNumIterator.Location = new System.Drawing.Point(135, 372);
            this.txtbCNumIterator.Name = "txtbCNumIterator";
            this.txtbCNumIterator.Size = new System.Drawing.Size(99, 20);
            this.txtbCNumIterator.TabIndex = 24;
            this.txtbCNumIterator.Text = "1000";
            // 
            // txtbCBenignVirusRate
            // 
            this.txtbCBenignVirusRate.Location = new System.Drawing.Point(187, 19);
            this.txtbCBenignVirusRate.Name = "txtbCBenignVirusRate";
            this.txtbCBenignVirusRate.Size = new System.Drawing.Size(62, 20);
            this.txtbCBenignVirusRate.TabIndex = 23;
            this.txtbCBenignVirusRate.Text = "2";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(25, 306);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "Num Neuron Y";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(25, 281);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Num Neuron X";
            // 
            // txtbCNumNeuronY
            // 
            this.txtbCNumNeuronY.Location = new System.Drawing.Point(135, 299);
            this.txtbCNumNeuronY.Name = "txtbCNumNeuronY";
            this.txtbCNumNeuronY.Size = new System.Drawing.Size(99, 20);
            this.txtbCNumNeuronY.TabIndex = 7;
            this.txtbCNumNeuronY.Text = "10";
            // 
            // txtbCNumNeuronX
            // 
            this.txtbCNumNeuronX.Location = new System.Drawing.Point(135, 274);
            this.txtbCNumNeuronX.Name = "txtbCNumNeuronX";
            this.txtbCNumNeuronX.Size = new System.Drawing.Size(99, 20);
            this.txtbCNumNeuronX.TabIndex = 6;
            this.txtbCNumNeuronX.Text = "10";
            // 
            // btnCPrintNeuron
            // 
            this.btnCPrintNeuron.Location = new System.Drawing.Point(187, 426);
            this.btnCPrintNeuron.Name = "btnCPrintNeuron";
            this.btnCPrintNeuron.Size = new System.Drawing.Size(99, 23);
            this.btnCPrintNeuron.TabIndex = 5;
            this.btnCPrintNeuron.Text = "Print Neuron";
            this.btnCPrintNeuron.UseVisualStyleBackColor = true;
            this.btnCPrintNeuron.Click += new System.EventHandler(this.btnCPrintNeuron_Click);
            // 
            // btnCStartClustering
            // 
            this.btnCStartClustering.Location = new System.Drawing.Point(82, 426);
            this.btnCStartClustering.Name = "btnCStartClustering";
            this.btnCStartClustering.Size = new System.Drawing.Size(99, 23);
            this.btnCStartClustering.TabIndex = 4;
            this.btnCStartClustering.Text = "Start Clustering";
            this.btnCStartClustering.UseVisualStyleBackColor = true;
            this.btnCStartClustering.Click += new System.EventHandler(this.btnCStartClustering_Click);
            // 
            // tabpgFileClassifier
            // 
            this.tabpgFileClassifier.Controls.Add(this.chart1);
            this.tabpgFileClassifier.Controls.Add(this.panel3);
            this.tabpgFileClassifier.Location = new System.Drawing.Point(4, 22);
            this.tabpgFileClassifier.Name = "tabpgFileClassifier";
            this.tabpgFileClassifier.Padding = new System.Windows.Forms.Padding(3);
            this.tabpgFileClassifier.Size = new System.Drawing.Size(744, 473);
            this.tabpgFileClassifier.TabIndex = 2;
            this.tabpgFileClassifier.Text = "File Classifier";
            this.tabpgFileClassifier.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(216, 3);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series1.Legend = "Legend1";
            series1.Name = "Benign";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series2.Legend = "Legend1";
            series2.Name = "Virus";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(525, 467);
            this.chart1.TabIndex = 48;
            this.chart1.Text = "chart1";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.label18);
            this.panel3.Controls.Add(this.btnFCLoad);
            this.panel3.Controls.Add(this.btnFCFileClassifierFile);
            this.panel3.Controls.Add(this.btnFCSave);
            this.panel3.Controls.Add(this.txtbFCFileClassifierFile);
            this.panel3.Controls.Add(this.label24);
            this.panel3.Controls.Add(this.btnFCBenignFolder);
            this.panel3.Controls.Add(this.txtbCFFormatRange);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.txtbCFErrorThresold);
            this.panel3.Controls.Add(this.label19);
            this.panel3.Controls.Add(this.btnFCStartFileClassifier);
            this.panel3.Controls.Add(this.txtbCFNumOutputNeuron);
            this.panel3.Controls.Add(this.label22);
            this.panel3.Controls.Add(this.txtbCFNumIterator);
            this.panel3.Controls.Add(this.label20);
            this.panel3.Controls.Add(this.txtbFCBenignFolder);
            this.panel3.Controls.Add(this.label29);
            this.panel3.Controls.Add(this.txtbFCVirusFolder);
            this.panel3.Controls.Add(this.btnFCVirusFolder);
            this.panel3.Controls.Add(this.label21);
            this.panel3.Controls.Add(this.txtbFCNumHiddenNeuron);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(213, 467);
            this.panel3.TabIndex = 47;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(3, 11);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(62, 13);
            this.label18.TabIndex = 45;
            this.label18.Text = "Virus Folder";
            // 
            // btnFCLoad
            // 
            this.btnFCLoad.Location = new System.Drawing.Point(121, 404);
            this.btnFCLoad.Name = "btnFCLoad";
            this.btnFCLoad.Size = new System.Drawing.Size(78, 27);
            this.btnFCLoad.TabIndex = 2;
            this.btnFCLoad.Text = "Load";
            this.btnFCLoad.UseVisualStyleBackColor = true;
            this.btnFCLoad.Click += new System.EventHandler(this.btnLoadFileClassifier_Click);
            // 
            // btnFCFileClassifierFile
            // 
            this.btnFCFileClassifierFile.Location = new System.Drawing.Point(163, 362);
            this.btnFCFileClassifierFile.Name = "btnFCFileClassifierFile";
            this.btnFCFileClassifierFile.Size = new System.Drawing.Size(36, 21);
            this.btnFCFileClassifierFile.TabIndex = 4;
            this.btnFCFileClassifierFile.Text = "...";
            this.btnFCFileClassifierFile.UseVisualStyleBackColor = true;
            this.btnFCFileClassifierFile.Click += new System.EventHandler(this.btnFileClassifierFile_Click);
            // 
            // btnFCSave
            // 
            this.btnFCSave.Location = new System.Drawing.Point(8, 404);
            this.btnFCSave.Name = "btnFCSave";
            this.btnFCSave.Size = new System.Drawing.Size(76, 27);
            this.btnFCSave.TabIndex = 1;
            this.btnFCSave.Text = "Save";
            this.btnFCSave.UseVisualStyleBackColor = true;
            this.btnFCSave.Click += new System.EventHandler(this.btnSaveFileClassifier_Click);
            // 
            // txtbFCFileClassifierFile
            // 
            this.txtbFCFileClassifierFile.Location = new System.Drawing.Point(8, 363);
            this.txtbFCFileClassifierFile.Name = "txtbFCFileClassifierFile";
            this.txtbFCFileClassifierFile.Size = new System.Drawing.Size(138, 20);
            this.txtbFCFileClassifierFile.TabIndex = 5;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(5, 331);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(86, 13);
            this.label24.TabIndex = 40;
            this.label24.Text = "File Classifier File";
            // 
            // btnFCBenignFolder
            // 
            this.btnFCBenignFolder.Location = new System.Drawing.Point(165, 81);
            this.btnFCBenignFolder.Name = "btnFCBenignFolder";
            this.btnFCBenignFolder.Size = new System.Drawing.Size(34, 20);
            this.btnFCBenignFolder.TabIndex = 43;
            this.btnFCBenignFolder.Text = "...";
            this.btnFCBenignFolder.UseVisualStyleBackColor = true;
            this.btnFCBenignFolder.Click += new System.EventHandler(this.btnFCBenignFolder_Click);
            // 
            // txtbCFFormatRange
            // 
            this.txtbCFFormatRange.Location = new System.Drawing.Point(59, 246);
            this.txtbCFFormatRange.Name = "txtbCFFormatRange";
            this.txtbCFFormatRange.Size = new System.Drawing.Size(140, 20);
            this.txtbCFFormatRange.TabIndex = 6;
            this.txtbCFFormatRange.Text = "0,3,5,7,10";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 225);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Format Range";
            // 
            // txtbCFErrorThresold
            // 
            this.txtbCFErrorThresold.Location = new System.Drawing.Point(138, 195);
            this.txtbCFErrorThresold.Name = "txtbCFErrorThresold";
            this.txtbCFErrorThresold.Size = new System.Drawing.Size(61, 20);
            this.txtbCFErrorThresold.TabIndex = 34;
            this.txtbCFErrorThresold.Text = "0.2";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(5, 198);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(73, 13);
            this.label19.TabIndex = 35;
            this.label19.Text = "Error Thresold";
            // 
            // btnFCStartFileClassifier
            // 
            this.btnFCStartFileClassifier.Location = new System.Drawing.Point(44, 288);
            this.btnFCStartFileClassifier.Name = "btnFCStartFileClassifier";
            this.btnFCStartFileClassifier.Size = new System.Drawing.Size(111, 27);
            this.btnFCStartFileClassifier.TabIndex = 0;
            this.btnFCStartFileClassifier.Text = "Start File Classifier";
            this.btnFCStartFileClassifier.UseVisualStyleBackColor = true;
            this.btnFCStartFileClassifier.Click += new System.EventHandler(this.btnBuildFileClassifier_Click);
            // 
            // txtbCFNumOutputNeuron
            // 
            this.txtbCFNumOutputNeuron.Location = new System.Drawing.Point(138, 143);
            this.txtbCFNumOutputNeuron.Name = "txtbCFNumOutputNeuron";
            this.txtbCFNumOutputNeuron.Size = new System.Drawing.Size(61, 20);
            this.txtbCFNumOutputNeuron.TabIndex = 38;
            this.txtbCFNumOutputNeuron.Text = "1";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(5, 146);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(102, 13);
            this.label22.TabIndex = 39;
            this.label22.Text = "Num Output Neuron";
            // 
            // txtbCFNumIterator
            // 
            this.txtbCFNumIterator.Location = new System.Drawing.Point(138, 169);
            this.txtbCFNumIterator.Name = "txtbCFNumIterator";
            this.txtbCFNumIterator.Size = new System.Drawing.Size(61, 20);
            this.txtbCFNumIterator.TabIndex = 32;
            this.txtbCFNumIterator.Text = "1000";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(5, 167);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(65, 13);
            this.label20.TabIndex = 33;
            this.label20.Text = "Num Iterator";
            // 
            // txtbFCBenignFolder
            // 
            this.txtbFCBenignFolder.Location = new System.Drawing.Point(6, 81);
            this.txtbFCBenignFolder.Name = "txtbFCBenignFolder";
            this.txtbFCBenignFolder.Size = new System.Drawing.Size(140, 20);
            this.txtbFCBenignFolder.TabIndex = 44;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(3, 62);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(72, 13);
            this.label29.TabIndex = 46;
            this.label29.Text = "Benign Folder";
            // 
            // txtbFCVirusFolder
            // 
            this.txtbFCVirusFolder.Location = new System.Drawing.Point(6, 28);
            this.txtbFCVirusFolder.Name = "txtbFCVirusFolder";
            this.txtbFCVirusFolder.Size = new System.Drawing.Size(140, 20);
            this.txtbFCVirusFolder.TabIndex = 42;
            // 
            // btnFCVirusFolder
            // 
            this.btnFCVirusFolder.Location = new System.Drawing.Point(165, 28);
            this.btnFCVirusFolder.Name = "btnFCVirusFolder";
            this.btnFCVirusFolder.Size = new System.Drawing.Size(34, 20);
            this.btnFCVirusFolder.TabIndex = 41;
            this.btnFCVirusFolder.Text = "...";
            this.btnFCVirusFolder.UseVisualStyleBackColor = true;
            this.btnFCVirusFolder.Click += new System.EventHandler(this.btnFCVirusFolder_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(3, 120);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(104, 13);
            this.label21.TabIndex = 31;
            this.label21.Text = "Num Hidden Neuron";
            // 
            // txtbFCNumHiddenNeuron
            // 
            this.txtbFCNumHiddenNeuron.Location = new System.Drawing.Point(138, 117);
            this.txtbFCNumHiddenNeuron.Name = "txtbFCNumHiddenNeuron";
            this.txtbFCNumHiddenNeuron.Size = new System.Drawing.Size(61, 20);
            this.txtbFCNumHiddenNeuron.TabIndex = 30;
            this.txtbFCNumHiddenNeuron.Text = "5";
            // 
            // tabPgVirusScanner
            // 
            this.tabPgVirusScanner.Controls.Add(this.label30);
            this.tabPgVirusScanner.Controls.Add(this.label17);
            this.tabPgVirusScanner.Controls.Add(this.txtbFCNumBenign);
            this.tabPgVirusScanner.Controls.Add(this.label16);
            this.tabPgVirusScanner.Controls.Add(this.txtbFCNumVirus);
            this.tabPgVirusScanner.Controls.Add(this.txtbVSTestFileFolder);
            this.tabPgVirusScanner.Controls.Add(this.btnFCTestFileFolder);
            this.tabPgVirusScanner.Controls.Add(this.btnFCScanVirus);
            this.tabPgVirusScanner.Location = new System.Drawing.Point(4, 22);
            this.tabPgVirusScanner.Name = "tabPgVirusScanner";
            this.tabPgVirusScanner.Padding = new System.Windows.Forms.Padding(3);
            this.tabPgVirusScanner.Size = new System.Drawing.Size(744, 473);
            this.tabPgVirusScanner.TabIndex = 3;
            this.tabPgVirusScanner.Text = "Virus Scanner";
            this.tabPgVirusScanner.UseVisualStyleBackColor = true;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(52, 79);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(79, 13);
            this.label30.TabIndex = 34;
            this.label30.Text = "Test File Folder";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(52, 279);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(65, 13);
            this.label17.TabIndex = 33;
            this.label17.Text = "Num Benign";
            // 
            // txtbFCNumBenign
            // 
            this.txtbFCNumBenign.Location = new System.Drawing.Point(141, 276);
            this.txtbFCNumBenign.Name = "txtbFCNumBenign";
            this.txtbFCNumBenign.ReadOnly = true;
            this.txtbFCNumBenign.Size = new System.Drawing.Size(85, 20);
            this.txtbFCNumBenign.TabIndex = 32;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(52, 253);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(55, 13);
            this.label16.TabIndex = 31;
            this.label16.Text = "Num Virus";
            // 
            // txtbFCNumVirus
            // 
            this.txtbFCNumVirus.Location = new System.Drawing.Point(141, 250);
            this.txtbFCNumVirus.Name = "txtbFCNumVirus";
            this.txtbFCNumVirus.ReadOnly = true;
            this.txtbFCNumVirus.Size = new System.Drawing.Size(85, 20);
            this.txtbFCNumVirus.TabIndex = 30;
            // 
            // txtbVSTestFileFolder
            // 
            this.txtbVSTestFileFolder.Location = new System.Drawing.Point(151, 76);
            this.txtbVSTestFileFolder.Name = "txtbVSTestFileFolder";
            this.txtbVSTestFileFolder.Size = new System.Drawing.Size(199, 20);
            this.txtbVSTestFileFolder.TabIndex = 7;
            // 
            // btnFCTestFileFolder
            // 
            this.btnFCTestFileFolder.Location = new System.Drawing.Point(356, 75);
            this.btnFCTestFileFolder.Name = "btnFCTestFileFolder";
            this.btnFCTestFileFolder.Size = new System.Drawing.Size(45, 22);
            this.btnFCTestFileFolder.TabIndex = 6;
            this.btnFCTestFileFolder.Text = "...";
            this.btnFCTestFileFolder.UseVisualStyleBackColor = true;
            this.btnFCTestFileFolder.Click += new System.EventHandler(this.btnTestFileFolder_Click);
            // 
            // btnFCScanVirus
            // 
            this.btnFCScanVirus.Location = new System.Drawing.Point(108, 140);
            this.btnFCScanVirus.Name = "btnFCScanVirus";
            this.btnFCScanVirus.Size = new System.Drawing.Size(96, 26);
            this.btnFCScanVirus.TabIndex = 0;
            this.btnFCScanVirus.Text = "Scan Virus";
            this.btnFCScanVirus.UseVisualStyleBackColor = true;
            this.btnFCScanVirus.Click += new System.EventHandler(this.btnScanVirus_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(962, 593);
            this.Controls.Add(this.tabMain);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelFooter);
            this.Name = "FormMain";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "Virus Detection";
            this.panelFooter.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelRight.ResumeLayout(false);
            this.grbOutput.ResumeLayout(false);
            this.grbIO.ResumeLayout(false);
            this.grbIO.PerformLayout();
            this.grbActions.ResumeLayout(false);
            this.tabMain.ResumeLayout(false);
            this.tabpgDetector.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGroupView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNegativeSelection)).EndInit();
            this.panelTabRight.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabpgClustering.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabpgFileClassifier.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tabPgVirusScanner.ResumeLayout(false);
            this.tabPgVirusScanner.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.GroupBox grbOutput;
        private System.Windows.Forms.GroupBox grbIO;
        private System.Windows.Forms.TextBox txtbDetectorFile;
        private System.Windows.Forms.Button btnDetectorFile;
        private System.Windows.Forms.TextBox txtbBenignFolder;
        private System.Windows.Forms.Button btnBegin;
        private System.Windows.Forms.TextBox txtbVirusFolder;
        private System.Windows.Forms.Button btnVirusDetect;
        private System.Windows.Forms.GroupBox grbActions;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnBuildDetector;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabpgDetector;
        private System.Windows.Forms.TabPage tabpgClustering;
        private System.Windows.Forms.TabPage tabpgFileClassifier;
        private System.Windows.Forms.TabPage tabPgVirusScanner;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtStatusBar;
        private System.Windows.Forms.TextBox txtTimeBox;
        private System.Windows.Forms.ProgressBar pbStatus;
        private System.Windows.Forms.DataGridView dtNegativeSelection;
        private System.Windows.Forms.Panel panelTabRight;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSelectionRate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNumberofCluster;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtStepSize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtContiguos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox ckbRContiguos;
        private System.Windows.Forms.TextBox txtHamming;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox ckbHamming;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView dtGroupView;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCLoad;
        private System.Windows.Forms.Button btnCSave;
        private System.Windows.Forms.TextBox txtbCClusteringFile;
        private System.Windows.Forms.Button btnCClusteringFile;
        private System.Windows.Forms.Button btnCStartClustering;
        private System.Windows.Forms.Button btnCPrintNeuron;
        private System.Windows.Forms.Button btnFCLoad;
        private System.Windows.Forms.Button btnFCSave;
        private System.Windows.Forms.Button btnFCStartFileClassifier;
        private System.Windows.Forms.Button btnFCScanVirus;
        private System.Windows.Forms.TextBox txtbFCFileClassifierFile;
        private System.Windows.Forms.Button btnFCFileClassifierFile;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtbCFFormatRange;
        private System.Windows.Forms.TextBox txtbVirusFragmentsCount;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtbCErrorThresold;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtbCNumIterator;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtbCNumNeuronY;
        private System.Windows.Forms.TextBox txtbCNumNeuronX;
        private System.Windows.Forms.Button btnLoadDetector;
        private System.Windows.Forms.Button btnSaveDetector;
        private System.Windows.Forms.TextBox txtbCMixDetectorFile;
        private System.Windows.Forms.Button btnCMixDetectorFile;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtbCNumInputNeuron;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtbFCNumBenign;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtbFCNumVirus;
        private System.Windows.Forms.TextBox txtbVSTestFileFolder;
        private System.Windows.Forms.Button btnFCTestFileFolder;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtbCFNumOutputNeuron;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtbCFErrorThresold;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtbCFNumIterator;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtbFCNumHiddenNeuron;
        private System.Windows.Forms.Button btnCMixDetector;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtbCBenignSize;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtbCVirusSize;
        private System.Windows.Forms.CheckBox cbCUseRate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtbCBenignVirusRate;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtbCNumOutputNeuron;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Button btnCLoadMixDetector;
        private System.Windows.Forms.Button btnCSaveMixDetector;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txtbCTotalBenign;
        private System.Windows.Forms.TextBox txtbCTotalVirus;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox txtbCLearningRadius;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox txtbCLearningRate;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtbFCBenignFolder;
        private System.Windows.Forms.Button btnFCBenignFolder;
        private System.Windows.Forms.TextBox txtbFCVirusFolder;
        private System.Windows.Forms.Button btnFCVirusFolder;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Panel panel3;
    }
}

