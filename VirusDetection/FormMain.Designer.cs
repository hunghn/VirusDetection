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
            this.txtbMixDetectorFile = new System.Windows.Forms.TextBox();
            this.btnMixDetectorFile = new System.Windows.Forms.Button();
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
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.txtbClusteringTotalBenign = new System.Windows.Forms.TextBox();
            this.txtbClusteringTotalVirus = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label27 = new System.Windows.Forms.Label();
            this.btnLoadMixDetector = new System.Windows.Forms.Button();
            this.txtbClusteringLearningRadius = new System.Windows.Forms.TextBox();
            this.btnSaveMixDetector = new System.Windows.Forms.Button();
            this.label28 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.txtbClusteringLearningRate = new System.Windows.Forms.TextBox();
            this.txtbClusteringNumOutputNeuron = new System.Windows.Forms.TextBox();
            this.btnClustering = new System.Windows.Forms.Button();
            this.btnMixDetector = new System.Windows.Forms.Button();
            this.txtbClusteringFile = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtbBenignSize = new System.Windows.Forms.TextBox();
            this.txtbClusteringNumInputNeuron = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtbVirusSize = new System.Windows.Forms.TextBox();
            this.txtbClusteringErrorThresold = new System.Windows.Forms.TextBox();
            this.cbxUseRate = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtbClusteringNumIterator = new System.Windows.Forms.TextBox();
            this.txtbBenignVirusRate = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtbNumNeuronY = new System.Windows.Forms.TextBox();
            this.txtbNumNeuronX = new System.Windows.Forms.TextBox();
            this.btnPrintNeuron = new System.Windows.Forms.Button();
            this.btnStartClustering = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnSaveClustering = new System.Windows.Forms.Button();
            this.tabpgFileClassifier = new System.Windows.Forms.TabPage();
            this.label24 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.txtbClassifierNumOutputNeuron = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtbClassifierErrorThresold = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtbClassifierNumIterator = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtbClassifierNumHiddenNeuron = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtbFormatRange = new System.Windows.Forms.TextBox();
            this.txtbFileClassifierFile = new System.Windows.Forms.TextBox();
            this.btnFileClassifierFile = new System.Windows.Forms.Button();
            this.btnFileClassifierLoad = new System.Windows.Forms.Button();
            this.btnFileClassifierSave = new System.Windows.Forms.Button();
            this.btnStartFileClassifier = new System.Windows.Forms.Button();
            this.tabPgVirusScanner = new System.Windows.Forms.TabPage();
            this.label17 = new System.Windows.Forms.Label();
            this.txtbNumOfBenign = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtbNumOfVirus = new System.Windows.Forms.TextBox();
            this.txtbVirusScannerTestFileFolder = new System.Windows.Forms.TextBox();
            this.btnTestFileFolder = new System.Windows.Forms.Button();
            this.btnScanVirus = new System.Windows.Forms.Button();
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
            // txtbMixDetectorFile
            // 
            this.txtbMixDetectorFile.Location = new System.Drawing.Point(18, 108);
            this.txtbMixDetectorFile.Name = "txtbMixDetectorFile";
            this.txtbMixDetectorFile.Size = new System.Drawing.Size(171, 20);
            this.txtbMixDetectorFile.TabIndex = 9;
            // 
            // btnMixDetectorFile
            // 
            this.btnMixDetectorFile.Location = new System.Drawing.Point(195, 108);
            this.btnMixDetectorFile.Name = "btnMixDetectorFile";
            this.btnMixDetectorFile.Size = new System.Drawing.Size(115, 21);
            this.btnMixDetectorFile.TabIndex = 8;
            this.btnMixDetectorFile.Text = "Mix Detector File";
            this.btnMixDetectorFile.UseVisualStyleBackColor = true;
            this.btnMixDetectorFile.Click += new System.EventHandler(this.btnMixDetectorFile_Click);
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
            this.panel2.Controls.Add(this.label26);
            this.panel2.Controls.Add(this.label25);
            this.panel2.Controls.Add(this.txtbClusteringTotalBenign);
            this.panel2.Controls.Add(this.txtbClusteringTotalVirus);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(358, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(383, 467);
            this.panel2.TabIndex = 1;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(36, 195);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(57, 13);
            this.label26.TabIndex = 29;
            this.label26.Text = "Total Virus";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(36, 220);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(67, 13);
            this.label25.TabIndex = 28;
            this.label25.Text = "Total Benign";
            // 
            // txtbClusteringTotalBenign
            // 
            this.txtbClusteringTotalBenign.Location = new System.Drawing.Point(114, 217);
            this.txtbClusteringTotalBenign.Name = "txtbClusteringTotalBenign";
            this.txtbClusteringTotalBenign.ReadOnly = true;
            this.txtbClusteringTotalBenign.Size = new System.Drawing.Size(99, 20);
            this.txtbClusteringTotalBenign.TabIndex = 9;
            // 
            // txtbClusteringTotalVirus
            // 
            this.txtbClusteringTotalVirus.Location = new System.Drawing.Point(114, 192);
            this.txtbClusteringTotalVirus.Name = "txtbClusteringTotalVirus";
            this.txtbClusteringTotalVirus.ReadOnly = true;
            this.txtbClusteringTotalVirus.Size = new System.Drawing.Size(99, 20);
            this.txtbClusteringTotalVirus.TabIndex = 8;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label27);
            this.groupBox2.Controls.Add(this.btnLoadMixDetector);
            this.groupBox2.Controls.Add(this.txtbClusteringLearningRadius);
            this.groupBox2.Controls.Add(this.btnSaveMixDetector);
            this.groupBox2.Controls.Add(this.label28);
            this.groupBox2.Controls.Add(this.label23);
            this.groupBox2.Controls.Add(this.txtbMixDetectorFile);
            this.groupBox2.Controls.Add(this.txtbClusteringLearningRate);
            this.groupBox2.Controls.Add(this.txtbClusteringNumOutputNeuron);
            this.groupBox2.Controls.Add(this.btnMixDetectorFile);
            this.groupBox2.Controls.Add(this.btnClustering);
            this.groupBox2.Controls.Add(this.btnMixDetector);
            this.groupBox2.Controls.Add(this.txtbClusteringFile);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.txtbBenignSize);
            this.groupBox2.Controls.Add(this.txtbClusteringNumInputNeuron);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.txtbVirusSize);
            this.groupBox2.Controls.Add(this.txtbClusteringErrorThresold);
            this.groupBox2.Controls.Add(this.cbxUseRate);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtbClusteringNumIterator);
            this.groupBox2.Controls.Add(this.txtbBenignVirusRate);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtbNumNeuronY);
            this.groupBox2.Controls.Add(this.txtbNumNeuronX);
            this.groupBox2.Controls.Add(this.btnPrintNeuron);
            this.groupBox2.Controls.Add(this.btnStartClustering);
            this.groupBox2.Controls.Add(this.btnLoad);
            this.groupBox2.Controls.Add(this.btnSaveClustering);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(355, 467);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Function";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(47, 294);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(84, 13);
            this.label27.TabIndex = 36;
            this.label27.Text = "Learning Radius";
            // 
            // btnLoadMixDetector
            // 
            this.btnLoadMixDetector.Location = new System.Drawing.Point(178, 136);
            this.btnLoadMixDetector.Name = "btnLoadMixDetector";
            this.btnLoadMixDetector.Size = new System.Drawing.Size(104, 22);
            this.btnLoadMixDetector.TabIndex = 11;
            this.btnLoadMixDetector.Text = "Load Mix Detector";
            this.btnLoadMixDetector.UseVisualStyleBackColor = true;
            this.btnLoadMixDetector.Click += new System.EventHandler(this.btnLoadMixDetector_Click);
            // 
            // txtbClusteringLearningRadius
            // 
            this.txtbClusteringLearningRadius.Location = new System.Drawing.Point(157, 287);
            this.txtbClusteringLearningRadius.Name = "txtbClusteringLearningRadius";
            this.txtbClusteringLearningRadius.Size = new System.Drawing.Size(99, 20);
            this.txtbClusteringLearningRadius.TabIndex = 35;
            this.txtbClusteringLearningRadius.Text = "4";
            // 
            // btnSaveMixDetector
            // 
            this.btnSaveMixDetector.Location = new System.Drawing.Point(59, 136);
            this.btnSaveMixDetector.Name = "btnSaveMixDetector";
            this.btnSaveMixDetector.Size = new System.Drawing.Size(113, 23);
            this.btnSaveMixDetector.TabIndex = 10;
            this.btnSaveMixDetector.Text = "Save Mix Detector";
            this.btnSaveMixDetector.UseVisualStyleBackColor = true;
            this.btnSaveMixDetector.Click += new System.EventHandler(this.btnSaveMixDetector_Click);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(47, 270);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(74, 13);
            this.label28.TabIndex = 34;
            this.label28.Text = "Learning Rate";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(47, 193);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(102, 13);
            this.label23.TabIndex = 32;
            this.label23.Text = "Num Output Neuron";
            // 
            // txtbClusteringLearningRate
            // 
            this.txtbClusteringLearningRate.Location = new System.Drawing.Point(157, 263);
            this.txtbClusteringLearningRate.Name = "txtbClusteringLearningRate";
            this.txtbClusteringLearningRate.Size = new System.Drawing.Size(99, 20);
            this.txtbClusteringLearningRate.TabIndex = 33;
            this.txtbClusteringLearningRate.Text = "0.3";
            // 
            // txtbClusteringNumOutputNeuron
            // 
            this.txtbClusteringNumOutputNeuron.Location = new System.Drawing.Point(157, 190);
            this.txtbClusteringNumOutputNeuron.Name = "txtbClusteringNumOutputNeuron";
            this.txtbClusteringNumOutputNeuron.ReadOnly = true;
            this.txtbClusteringNumOutputNeuron.Size = new System.Drawing.Size(99, 20);
            this.txtbClusteringNumOutputNeuron.TabIndex = 31;
            // 
            // btnClustering
            // 
            this.btnClustering.Location = new System.Drawing.Point(179, 402);
            this.btnClustering.Name = "btnClustering";
            this.btnClustering.Size = new System.Drawing.Size(92, 22);
            this.btnClustering.TabIndex = 2;
            this.btnClustering.Text = "Clustering File";
            this.btnClustering.UseVisualStyleBackColor = true;
            this.btnClustering.Click += new System.EventHandler(this.btnClusteringFile_Click);
            // 
            // btnMixDetector
            // 
            this.btnMixDetector.Location = new System.Drawing.Point(235, 62);
            this.btnMixDetector.Name = "btnMixDetector";
            this.btnMixDetector.Size = new System.Drawing.Size(92, 23);
            this.btnMixDetector.TabIndex = 30;
            this.btnMixDetector.Text = "Mix Detector";
            this.btnMixDetector.UseVisualStyleBackColor = true;
            this.btnMixDetector.Click += new System.EventHandler(this.btnMixDetector_Click);
            // 
            // txtbClusteringFile
            // 
            this.txtbClusteringFile.Location = new System.Drawing.Point(53, 403);
            this.txtbClusteringFile.Name = "txtbClusteringFile";
            this.txtbClusteringFile.Size = new System.Drawing.Size(120, 20);
            this.txtbClusteringFile.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(28, 79);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 13);
            this.label10.TabIndex = 29;
            this.label10.Text = "Benign Size";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(47, 169);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(94, 13);
            this.label15.TabIndex = 29;
            this.label15.Text = "Num Input Neuron";
            // 
            // txtbBenignSize
            // 
            this.txtbBenignSize.Location = new System.Drawing.Point(94, 76);
            this.txtbBenignSize.Name = "txtbBenignSize";
            this.txtbBenignSize.ReadOnly = true;
            this.txtbBenignSize.Size = new System.Drawing.Size(112, 20);
            this.txtbBenignSize.TabIndex = 28;
            // 
            // txtbClusteringNumInputNeuron
            // 
            this.txtbClusteringNumInputNeuron.Location = new System.Drawing.Point(157, 166);
            this.txtbClusteringNumInputNeuron.Name = "txtbClusteringNumInputNeuron";
            this.txtbClusteringNumInputNeuron.Size = new System.Drawing.Size(99, 20);
            this.txtbClusteringNumInputNeuron.TabIndex = 28;
            this.txtbClusteringNumInputNeuron.Text = "4";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(28, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "Virus Size";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(47, 343);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(73, 13);
            this.label14.TabIndex = 27;
            this.label14.Text = "Error Thresold";
            // 
            // txtbVirusSize
            // 
            this.txtbVirusSize.Location = new System.Drawing.Point(94, 47);
            this.txtbVirusSize.Name = "txtbVirusSize";
            this.txtbVirusSize.ReadOnly = true;
            this.txtbVirusSize.Size = new System.Drawing.Size(112, 20);
            this.txtbVirusSize.TabIndex = 26;
            // 
            // txtbClusteringErrorThresold
            // 
            this.txtbClusteringErrorThresold.Location = new System.Drawing.Point(157, 336);
            this.txtbClusteringErrorThresold.Name = "txtbClusteringErrorThresold";
            this.txtbClusteringErrorThresold.Size = new System.Drawing.Size(99, 20);
            this.txtbClusteringErrorThresold.TabIndex = 26;
            this.txtbClusteringErrorThresold.Text = "0.2";
            // 
            // cbxUseRate
            // 
            this.cbxUseRate.AutoSize = true;
            this.cbxUseRate.Checked = true;
            this.cbxUseRate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxUseRate.Location = new System.Drawing.Point(25, 23);
            this.cbxUseRate.Name = "cbxUseRate";
            this.cbxUseRate.Size = new System.Drawing.Size(71, 17);
            this.cbxUseRate.TabIndex = 25;
            this.cbxUseRate.Text = "Use Rate";
            this.cbxUseRate.UseVisualStyleBackColor = true;
            this.cbxUseRate.CheckedChanged += new System.EventHandler(this.cbxUseRate_CheckedChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(47, 319);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 13);
            this.label13.TabIndex = 25;
            this.label13.Text = "Num Iterator";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(110, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Benign/Vr";
            // 
            // txtbClusteringNumIterator
            // 
            this.txtbClusteringNumIterator.Location = new System.Drawing.Point(157, 312);
            this.txtbClusteringNumIterator.Name = "txtbClusteringNumIterator";
            this.txtbClusteringNumIterator.Size = new System.Drawing.Size(99, 20);
            this.txtbClusteringNumIterator.TabIndex = 24;
            this.txtbClusteringNumIterator.Text = "1000";
            // 
            // txtbBenignVirusRate
            // 
            this.txtbBenignVirusRate.Location = new System.Drawing.Point(178, 20);
            this.txtbBenignVirusRate.Name = "txtbBenignVirusRate";
            this.txtbBenignVirusRate.Size = new System.Drawing.Size(62, 20);
            this.txtbBenignVirusRate.TabIndex = 23;
            this.txtbBenignVirusRate.Text = "10";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(47, 246);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "Num Neuron Y";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(47, 221);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Num Neuron X";
            // 
            // txtbNumNeuronY
            // 
            this.txtbNumNeuronY.Location = new System.Drawing.Point(157, 239);
            this.txtbNumNeuronY.Name = "txtbNumNeuronY";
            this.txtbNumNeuronY.Size = new System.Drawing.Size(99, 20);
            this.txtbNumNeuronY.TabIndex = 7;
            this.txtbNumNeuronY.Text = "10";
            // 
            // txtbNumNeuronX
            // 
            this.txtbNumNeuronX.Location = new System.Drawing.Point(157, 214);
            this.txtbNumNeuronX.Name = "txtbNumNeuronX";
            this.txtbNumNeuronX.Size = new System.Drawing.Size(99, 20);
            this.txtbNumNeuronX.TabIndex = 6;
            this.txtbNumNeuronX.Text = "10";
            // 
            // btnPrintNeuron
            // 
            this.btnPrintNeuron.Location = new System.Drawing.Point(165, 365);
            this.btnPrintNeuron.Name = "btnPrintNeuron";
            this.btnPrintNeuron.Size = new System.Drawing.Size(99, 23);
            this.btnPrintNeuron.TabIndex = 5;
            this.btnPrintNeuron.Text = "Print Neuron";
            this.btnPrintNeuron.UseVisualStyleBackColor = true;
            this.btnPrintNeuron.Click += new System.EventHandler(this.btnPrintNeuron_Click);
            // 
            // btnStartClustering
            // 
            this.btnStartClustering.Location = new System.Drawing.Point(60, 365);
            this.btnStartClustering.Name = "btnStartClustering";
            this.btnStartClustering.Size = new System.Drawing.Size(99, 23);
            this.btnStartClustering.TabIndex = 4;
            this.btnStartClustering.Text = "Start Clustering";
            this.btnStartClustering.UseVisualStyleBackColor = true;
            this.btnStartClustering.Click += new System.EventHandler(this.btnStartClustering_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(165, 430);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(99, 22);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnSaveClustering
            // 
            this.btnSaveClustering.Location = new System.Drawing.Point(59, 430);
            this.btnSaveClustering.Name = "btnSaveClustering";
            this.btnSaveClustering.Size = new System.Drawing.Size(99, 22);
            this.btnSaveClustering.TabIndex = 0;
            this.btnSaveClustering.Text = "Save";
            this.btnSaveClustering.UseVisualStyleBackColor = true;
            this.btnSaveClustering.Click += new System.EventHandler(this.btnSaveClustering_Click);
            // 
            // tabpgFileClassifier
            // 
            this.tabpgFileClassifier.Controls.Add(this.label24);
            this.tabpgFileClassifier.Controls.Add(this.label22);
            this.tabpgFileClassifier.Controls.Add(this.txtbClassifierNumOutputNeuron);
            this.tabpgFileClassifier.Controls.Add(this.label19);
            this.tabpgFileClassifier.Controls.Add(this.txtbClassifierErrorThresold);
            this.tabpgFileClassifier.Controls.Add(this.label20);
            this.tabpgFileClassifier.Controls.Add(this.txtbClassifierNumIterator);
            this.tabpgFileClassifier.Controls.Add(this.label21);
            this.tabpgFileClassifier.Controls.Add(this.txtbClassifierNumHiddenNeuron);
            this.tabpgFileClassifier.Controls.Add(this.label7);
            this.tabpgFileClassifier.Controls.Add(this.txtbFormatRange);
            this.tabpgFileClassifier.Controls.Add(this.txtbFileClassifierFile);
            this.tabpgFileClassifier.Controls.Add(this.btnFileClassifierFile);
            this.tabpgFileClassifier.Controls.Add(this.btnFileClassifierLoad);
            this.tabpgFileClassifier.Controls.Add(this.btnFileClassifierSave);
            this.tabpgFileClassifier.Controls.Add(this.btnStartFileClassifier);
            this.tabpgFileClassifier.Location = new System.Drawing.Point(4, 22);
            this.tabpgFileClassifier.Name = "tabpgFileClassifier";
            this.tabpgFileClassifier.Padding = new System.Windows.Forms.Padding(3);
            this.tabpgFileClassifier.Size = new System.Drawing.Size(744, 473);
            this.tabpgFileClassifier.TabIndex = 2;
            this.tabpgFileClassifier.Text = "File Classifier";
            this.tabpgFileClassifier.UseVisualStyleBackColor = true;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(52, 287);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(86, 13);
            this.label24.TabIndex = 40;
            this.label24.Text = "File Classifier File";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(50, 55);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(102, 13);
            this.label22.TabIndex = 39;
            this.label22.Text = "Num Output Neuron";
            // 
            // txtbClassifierNumOutputNeuron
            // 
            this.txtbClassifierNumOutputNeuron.Location = new System.Drawing.Point(158, 52);
            this.txtbClassifierNumOutputNeuron.Name = "txtbClassifierNumOutputNeuron";
            this.txtbClassifierNumOutputNeuron.Size = new System.Drawing.Size(99, 20);
            this.txtbClassifierNumOutputNeuron.TabIndex = 38;
            this.txtbClassifierNumOutputNeuron.Text = "1";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(50, 111);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(73, 13);
            this.label19.TabIndex = 35;
            this.label19.Text = "Error Thresold";
            // 
            // txtbClassifierErrorThresold
            // 
            this.txtbClassifierErrorThresold.Location = new System.Drawing.Point(158, 108);
            this.txtbClassifierErrorThresold.Name = "txtbClassifierErrorThresold";
            this.txtbClassifierErrorThresold.Size = new System.Drawing.Size(99, 20);
            this.txtbClassifierErrorThresold.TabIndex = 34;
            this.txtbClassifierErrorThresold.Text = "0.2";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(50, 84);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(65, 13);
            this.label20.TabIndex = 33;
            this.label20.Text = "Num Iterator";
            // 
            // txtbClassifierNumIterator
            // 
            this.txtbClassifierNumIterator.Location = new System.Drawing.Point(158, 81);
            this.txtbClassifierNumIterator.Name = "txtbClassifierNumIterator";
            this.txtbClassifierNumIterator.Size = new System.Drawing.Size(99, 20);
            this.txtbClassifierNumIterator.TabIndex = 32;
            this.txtbClassifierNumIterator.Text = "1000";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(50, 30);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(104, 13);
            this.label21.TabIndex = 31;
            this.label21.Text = "Num Hidden Neuron";
            // 
            // txtbClassifierNumHiddenNeuron
            // 
            this.txtbClassifierNumHiddenNeuron.Location = new System.Drawing.Point(158, 27);
            this.txtbClassifierNumHiddenNeuron.Name = "txtbClassifierNumHiddenNeuron";
            this.txtbClassifierNumHiddenNeuron.Size = new System.Drawing.Size(99, 20);
            this.txtbClassifierNumHiddenNeuron.TabIndex = 30;
            this.txtbClassifierNumHiddenNeuron.Text = "5";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(52, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(170, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Format Range (Dangerous Range)";
            // 
            // txtbFormatRange
            // 
            this.txtbFormatRange.Location = new System.Drawing.Point(55, 164);
            this.txtbFormatRange.Name = "txtbFormatRange";
            this.txtbFormatRange.Size = new System.Drawing.Size(110, 20);
            this.txtbFormatRange.TabIndex = 6;
            this.txtbFormatRange.Text = "0,3,5,7,10";
            // 
            // txtbFileClassifierFile
            // 
            this.txtbFileClassifierFile.Location = new System.Drawing.Point(26, 312);
            this.txtbFileClassifierFile.Name = "txtbFileClassifierFile";
            this.txtbFileClassifierFile.Size = new System.Drawing.Size(177, 20);
            this.txtbFileClassifierFile.TabIndex = 5;
            // 
            // btnFileClassifierFile
            // 
            this.btnFileClassifierFile.Location = new System.Drawing.Point(209, 312);
            this.btnFileClassifierFile.Name = "btnFileClassifierFile";
            this.btnFileClassifierFile.Size = new System.Drawing.Size(30, 21);
            this.btnFileClassifierFile.TabIndex = 4;
            this.btnFileClassifierFile.Text = "...";
            this.btnFileClassifierFile.UseVisualStyleBackColor = true;
            this.btnFileClassifierFile.Click += new System.EventHandler(this.btnFileClassifierFile_Click);
            // 
            // btnFileClassifierLoad
            // 
            this.btnFileClassifierLoad.Location = new System.Drawing.Point(142, 351);
            this.btnFileClassifierLoad.Name = "btnFileClassifierLoad";
            this.btnFileClassifierLoad.Size = new System.Drawing.Size(78, 27);
            this.btnFileClassifierLoad.TabIndex = 2;
            this.btnFileClassifierLoad.Text = "Load";
            this.btnFileClassifierLoad.UseVisualStyleBackColor = true;
            this.btnFileClassifierLoad.Click += new System.EventHandler(this.btnLoadFileClassifier_Click);
            // 
            // btnFileClassifierSave
            // 
            this.btnFileClassifierSave.Location = new System.Drawing.Point(39, 351);
            this.btnFileClassifierSave.Name = "btnFileClassifierSave";
            this.btnFileClassifierSave.Size = new System.Drawing.Size(76, 27);
            this.btnFileClassifierSave.TabIndex = 1;
            this.btnFileClassifierSave.Text = "Save";
            this.btnFileClassifierSave.UseVisualStyleBackColor = true;
            this.btnFileClassifierSave.Click += new System.EventHandler(this.btnSaveFileClassifier_Click);
            // 
            // btnStartFileClassifier
            // 
            this.btnStartFileClassifier.Location = new System.Drawing.Point(109, 230);
            this.btnStartFileClassifier.Name = "btnStartFileClassifier";
            this.btnStartFileClassifier.Size = new System.Drawing.Size(111, 27);
            this.btnStartFileClassifier.TabIndex = 0;
            this.btnStartFileClassifier.Text = "Start File Classifier";
            this.btnStartFileClassifier.UseVisualStyleBackColor = true;
            this.btnStartFileClassifier.Click += new System.EventHandler(this.btnBuildFileClassifier_Click);
            // 
            // tabPgVirusScanner
            // 
            this.tabPgVirusScanner.Controls.Add(this.label17);
            this.tabPgVirusScanner.Controls.Add(this.txtbNumOfBenign);
            this.tabPgVirusScanner.Controls.Add(this.label16);
            this.tabPgVirusScanner.Controls.Add(this.txtbNumOfVirus);
            this.tabPgVirusScanner.Controls.Add(this.txtbVirusScannerTestFileFolder);
            this.tabPgVirusScanner.Controls.Add(this.btnTestFileFolder);
            this.tabPgVirusScanner.Controls.Add(this.btnScanVirus);
            this.tabPgVirusScanner.Location = new System.Drawing.Point(4, 22);
            this.tabPgVirusScanner.Name = "tabPgVirusScanner";
            this.tabPgVirusScanner.Padding = new System.Windows.Forms.Padding(3);
            this.tabPgVirusScanner.Size = new System.Drawing.Size(744, 473);
            this.tabPgVirusScanner.TabIndex = 3;
            this.tabPgVirusScanner.Text = "Virus Scanner";
            this.tabPgVirusScanner.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(285, 262);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(79, 13);
            this.label17.TabIndex = 33;
            this.label17.Text = "Num Of Benign";
            // 
            // txtbNumOfBenign
            // 
            this.txtbNumOfBenign.Location = new System.Drawing.Point(374, 259);
            this.txtbNumOfBenign.Name = "txtbNumOfBenign";
            this.txtbNumOfBenign.Size = new System.Drawing.Size(85, 20);
            this.txtbNumOfBenign.TabIndex = 32;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(83, 263);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(69, 13);
            this.label16.TabIndex = 31;
            this.label16.Text = "Num Of Virus";
            // 
            // txtbNumOfVirus
            // 
            this.txtbNumOfVirus.Location = new System.Drawing.Point(172, 260);
            this.txtbNumOfVirus.Name = "txtbNumOfVirus";
            this.txtbNumOfVirus.Size = new System.Drawing.Size(85, 20);
            this.txtbNumOfVirus.TabIndex = 30;
            // 
            // txtbVirusScannerTestFileFolder
            // 
            this.txtbVirusScannerTestFileFolder.Location = new System.Drawing.Point(86, 96);
            this.txtbVirusScannerTestFileFolder.Name = "txtbVirusScannerTestFileFolder";
            this.txtbVirusScannerTestFileFolder.Size = new System.Drawing.Size(577, 20);
            this.txtbVirusScannerTestFileFolder.TabIndex = 7;
            // 
            // btnTestFileFolder
            // 
            this.btnTestFileFolder.Location = new System.Drawing.Point(86, 60);
            this.btnTestFileFolder.Name = "btnTestFileFolder";
            this.btnTestFileFolder.Size = new System.Drawing.Size(171, 29);
            this.btnTestFileFolder.TabIndex = 6;
            this.btnTestFileFolder.Text = "Test File Folder";
            this.btnTestFileFolder.UseVisualStyleBackColor = true;
            this.btnTestFileFolder.Click += new System.EventHandler(this.btnTestFileFolder_Click);
            // 
            // btnScanVirus
            // 
            this.btnScanVirus.Location = new System.Drawing.Point(86, 152);
            this.btnScanVirus.Name = "btnScanVirus";
            this.btnScanVirus.Size = new System.Drawing.Size(171, 26);
            this.btnScanVirus.TabIndex = 0;
            this.btnScanVirus.Text = "Scan Virus";
            this.btnScanVirus.UseVisualStyleBackColor = true;
            this.btnScanVirus.Click += new System.EventHandler(this.btnScanVirus_Click);
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
            this.tabpgFileClassifier.PerformLayout();
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
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnSaveClustering;
        private System.Windows.Forms.TextBox txtbClusteringFile;
        private System.Windows.Forms.Button btnClustering;
        private System.Windows.Forms.Button btnStartClustering;
        private System.Windows.Forms.Button btnPrintNeuron;
        private System.Windows.Forms.Button btnFileClassifierLoad;
        private System.Windows.Forms.Button btnFileClassifierSave;
        private System.Windows.Forms.Button btnStartFileClassifier;
        private System.Windows.Forms.Button btnScanVirus;
        private System.Windows.Forms.TextBox txtbFileClassifierFile;
        private System.Windows.Forms.Button btnFileClassifierFile;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtbFormatRange;
        private System.Windows.Forms.TextBox txtbVirusFragmentsCount;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtbClusteringErrorThresold;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtbClusteringNumIterator;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtbNumNeuronY;
        private System.Windows.Forms.TextBox txtbNumNeuronX;
        private System.Windows.Forms.Button btnLoadDetector;
        private System.Windows.Forms.Button btnSaveDetector;
        private System.Windows.Forms.TextBox txtbMixDetectorFile;
        private System.Windows.Forms.Button btnMixDetectorFile;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtbClusteringNumInputNeuron;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtbNumOfBenign;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtbNumOfVirus;
        private System.Windows.Forms.TextBox txtbVirusScannerTestFileFolder;
        private System.Windows.Forms.Button btnTestFileFolder;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtbClassifierNumOutputNeuron;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtbClassifierErrorThresold;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtbClassifierNumIterator;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtbClassifierNumHiddenNeuron;
        private System.Windows.Forms.Button btnMixDetector;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtbBenignSize;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtbVirusSize;
        private System.Windows.Forms.CheckBox cbxUseRate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtbBenignVirusRate;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtbClusteringNumOutputNeuron;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Button btnLoadMixDetector;
        private System.Windows.Forms.Button btnSaveMixDetector;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txtbClusteringTotalBenign;
        private System.Windows.Forms.TextBox txtbClusteringTotalVirus;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox txtbClusteringLearningRadius;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox txtbClusteringLearningRate;
    }
}

