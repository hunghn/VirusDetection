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
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
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
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabpgBuildDetector = new System.Windows.Forms.TabPage();
            this.dtGroupView = new System.Windows.Forms.DataGridView();
            this.dtNegativeSelection = new System.Windows.Forms.DataGridView();
            this.panelTabRight = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnMixDetector = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtbBenignSize = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtbVirusSize = new System.Windows.Forms.TextBox();
            this.cbxUseRate = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtbBenignVirusRate = new System.Windows.Forms.TextBox();
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
            this.tabpgBuildClustering = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnPrintNeuron = new System.Windows.Forms.Button();
            this.btnStartClustering = new System.Windows.Forms.Button();
            this.txtbClusteringFile = new System.Windows.Forms.TextBox();
            this.btnClustering = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnSaveClustering = new System.Windows.Forms.Button();
            this.tabpgBuildFileClassifier = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.txtbFormatRange = new System.Windows.Forms.TextBox();
            this.txtbFileClassifierFile = new System.Windows.Forms.TextBox();
            this.btnFileClassifierFile = new System.Windows.Forms.Button();
            this.btnLoadFileClassifier = new System.Windows.Forms.Button();
            this.btnSaveFileClassifier = new System.Windows.Forms.Button();
            this.btnBuildFileClassifier = new System.Windows.Forms.Button();
            this.tabPgVirusScanner = new System.Windows.Forms.TabPage();
            this.btnScanVirus = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelFooter.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelRight.SuspendLayout();
            this.grbOutput.SuspendLayout();
            this.grbIO.SuspendLayout();
            this.grbActions.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.tabpgBuildDetector.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGroupView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNegativeSelection)).BeginInit();
            this.panelTabRight.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabpgBuildClustering.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabpgBuildFileClassifier.SuspendLayout();
            this.tabPgVirusScanner.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelFooter
            // 
            this.panelFooter.BackColor = System.Drawing.SystemColors.Control;
            this.panelFooter.Controls.Add(this.progressBar2);
            this.panelFooter.Controls.Add(this.panel1);
            this.panelFooter.Controls.Add(this.pbStatus);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(5, 569);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Padding = new System.Windows.Forms.Padding(5);
            this.panelFooter.Size = new System.Drawing.Size(952, 84);
            this.panelFooter.TabIndex = 1;
            // 
            // progressBar2
            // 
            this.progressBar2.Dock = System.Windows.Forms.DockStyle.Top;
            this.progressBar2.Location = new System.Drawing.Point(5, 59);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(942, 23);
            this.progressBar2.TabIndex = 2;
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
            this.txtbVirusFragmentsCount.Location = new System.Drawing.Point(843, 8);
            this.txtbVirusFragmentsCount.Name = "txtbVirusFragmentsCount";
            this.txtbVirusFragmentsCount.Size = new System.Drawing.Size(96, 20);
            this.txtbVirusFragmentsCount.TabIndex = 2;
            // 
            // txtStatusBar
            // 
            this.txtStatusBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtStatusBar.Location = new System.Drawing.Point(195, 5);
            this.txtStatusBar.Name = "txtStatusBar";
            this.txtStatusBar.ReadOnly = true;
            this.txtStatusBar.Size = new System.Drawing.Size(747, 20);
            this.txtStatusBar.TabIndex = 1;
            // 
            // txtTimeBox
            // 
            this.txtTimeBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtTimeBox.Location = new System.Drawing.Point(0, 5);
            this.txtTimeBox.Name = "txtTimeBox";
            this.txtTimeBox.ReadOnly = true;
            this.txtTimeBox.Size = new System.Drawing.Size(195, 20);
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
            this.panelRight.Size = new System.Drawing.Size(200, 564);
            this.panelRight.TabIndex = 2;
            // 
            // grbOutput
            // 
            this.grbOutput.Controls.Add(this.btnLoadDetector);
            this.grbOutput.Controls.Add(this.btnSaveDetector);
            this.grbOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbOutput.Location = new System.Drawing.Point(0, 404);
            this.grbOutput.Name = "grbOutput";
            this.grbOutput.Size = new System.Drawing.Size(200, 160);
            this.grbOutput.TabIndex = 2;
            this.grbOutput.TabStop = false;
            this.grbOutput.Text = "Output";
            // 
            // btnLoadDetector
            // 
            this.btnLoadDetector.Location = new System.Drawing.Point(15, 60);
            this.btnLoadDetector.Name = "btnLoadDetector";
            this.btnLoadDetector.Size = new System.Drawing.Size(171, 29);
            this.btnLoadDetector.TabIndex = 9;
            this.btnLoadDetector.Text = "Load Mix Detector";
            this.btnLoadDetector.UseVisualStyleBackColor = true;
            this.btnLoadDetector.Click += new System.EventHandler(this.btnLoadDetector_Click);
            // 
            // btnSaveDetector
            // 
            this.btnSaveDetector.Location = new System.Drawing.Point(15, 19);
            this.btnSaveDetector.Name = "btnSaveDetector";
            this.btnSaveDetector.Size = new System.Drawing.Size(171, 29);
            this.btnSaveDetector.TabIndex = 7;
            this.btnSaveDetector.Text = "Save Mix Detector";
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
            this.grbIO.Location = new System.Drawing.Point(0, 167);
            this.grbIO.Name = "grbIO";
            this.grbIO.Size = new System.Drawing.Size(200, 237);
            this.grbIO.TabIndex = 1;
            this.grbIO.TabStop = false;
            this.grbIO.Text = "I/O";
            // 
            // txtbDetectorFile
            // 
            this.txtbDetectorFile.Location = new System.Drawing.Point(15, 199);
            this.txtbDetectorFile.Name = "txtbDetectorFile";
            this.txtbDetectorFile.Size = new System.Drawing.Size(171, 20);
            this.txtbDetectorFile.TabIndex = 7;
            // 
            // btnDetectorFile
            // 
            this.btnDetectorFile.Location = new System.Drawing.Point(15, 164);
            this.btnDetectorFile.Name = "btnDetectorFile";
            this.btnDetectorFile.Size = new System.Drawing.Size(171, 29);
            this.btnDetectorFile.TabIndex = 6;
            this.btnDetectorFile.Text = "Detector File";
            this.btnDetectorFile.UseVisualStyleBackColor = true;
            this.btnDetectorFile.Click += new System.EventHandler(this.btnDetect_Click);
            // 
            // txtbBenignFolder
            // 
            this.txtbBenignFolder.Location = new System.Drawing.Point(15, 126);
            this.txtbBenignFolder.Name = "txtbBenignFolder";
            this.txtbBenignFolder.Size = new System.Drawing.Size(171, 20);
            this.txtbBenignFolder.TabIndex = 5;
            // 
            // btnBegin
            // 
            this.btnBegin.Location = new System.Drawing.Point(15, 91);
            this.btnBegin.Name = "btnBegin";
            this.btnBegin.Size = new System.Drawing.Size(171, 29);
            this.btnBegin.TabIndex = 4;
            this.btnBegin.Text = "Begin Directory";
            this.btnBegin.UseVisualStyleBackColor = true;
            this.btnBegin.Click += new System.EventHandler(this.btnBegin_Click);
            // 
            // txtbVirusFolder
            // 
            this.txtbVirusFolder.Location = new System.Drawing.Point(15, 55);
            this.txtbVirusFolder.Name = "txtbVirusFolder";
            this.txtbVirusFolder.Size = new System.Drawing.Size(171, 20);
            this.txtbVirusFolder.TabIndex = 3;
            // 
            // btnVirusDetect
            // 
            this.btnVirusDetect.Location = new System.Drawing.Point(15, 19);
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
            this.grbActions.Size = new System.Drawing.Size(200, 167);
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
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabpgBuildDetector);
            this.tabMain.Controls.Add(this.tabpgBuildClustering);
            this.tabMain.Controls.Add(this.tabpgBuildFileClassifier);
            this.tabMain.Controls.Add(this.tabPgVirusScanner);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Location = new System.Drawing.Point(205, 5);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(752, 564);
            this.tabMain.TabIndex = 3;
            // 
            // tabpgBuildDetector
            // 
            this.tabpgBuildDetector.Controls.Add(this.dtGroupView);
            this.tabpgBuildDetector.Controls.Add(this.dtNegativeSelection);
            this.tabpgBuildDetector.Controls.Add(this.panelTabRight);
            this.tabpgBuildDetector.Location = new System.Drawing.Point(4, 22);
            this.tabpgBuildDetector.Name = "tabpgBuildDetector";
            this.tabpgBuildDetector.Padding = new System.Windows.Forms.Padding(3);
            this.tabpgBuildDetector.Size = new System.Drawing.Size(744, 538);
            this.tabpgBuildDetector.TabIndex = 0;
            this.tabpgBuildDetector.Text = "Build Detector";
            this.tabpgBuildDetector.UseVisualStyleBackColor = true;
            // 
            // dtGroupView
            // 
            this.dtGroupView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGroupView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGroupView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtGroupView.Location = new System.Drawing.Point(203, 279);
            this.dtGroupView.Name = "dtGroupView";
            this.dtGroupView.Size = new System.Drawing.Size(538, 256);
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
            this.panelTabRight.Size = new System.Drawing.Size(200, 532);
            this.panelTabRight.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnMixDetector);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtbBenignSize);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtbVirusSize);
            this.groupBox1.Controls.Add(this.cbxUseRate);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtbBenignVirusRate);
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
            this.groupBox1.Size = new System.Drawing.Size(200, 532);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parameter";
            // 
            // btnMixDetector
            // 
            this.btnMixDetector.Location = new System.Drawing.Point(14, 488);
            this.btnMixDetector.Name = "btnMixDetector";
            this.btnMixDetector.Size = new System.Drawing.Size(171, 29);
            this.btnMixDetector.TabIndex = 22;
            this.btnMixDetector.Text = "Mix Detector";
            this.btnMixDetector.UseVisualStyleBackColor = true;
            this.btnMixDetector.Click += new System.EventHandler(this.btnMixDetector_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 447);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Benign Size";
            // 
            // txtbBenignSize
            // 
            this.txtbBenignSize.Enabled = false;
            this.txtbBenignSize.Location = new System.Drawing.Point(73, 444);
            this.txtbBenignSize.Name = "txtbBenignSize";
            this.txtbBenignSize.Size = new System.Drawing.Size(112, 20);
            this.txtbBenignSize.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 412);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Virus Size";
            // 
            // txtbVirusSize
            // 
            this.txtbVirusSize.Enabled = false;
            this.txtbVirusSize.Location = new System.Drawing.Point(73, 409);
            this.txtbVirusSize.Name = "txtbVirusSize";
            this.txtbVirusSize.Size = new System.Drawing.Size(112, 20);
            this.txtbVirusSize.TabIndex = 18;
            // 
            // cbxUseRate
            // 
            this.cbxUseRate.AutoSize = true;
            this.cbxUseRate.Checked = true;
            this.cbxUseRate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxUseRate.Location = new System.Drawing.Point(26, 374);
            this.cbxUseRate.Name = "cbxUseRate";
            this.cbxUseRate.Size = new System.Drawing.Size(71, 17);
            this.cbxUseRate.TabIndex = 17;
            this.cbxUseRate.Text = "Use Rate";
            this.cbxUseRate.UseVisualStyleBackColor = true;
            this.cbxUseRate.CheckedChanged += new System.EventHandler(this.cbxUseRate_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 342);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Benign/Vr";
            // 
            // txtbBenignVirusRate
            // 
            this.txtbBenignVirusRate.Location = new System.Drawing.Point(72, 339);
            this.txtbBenignVirusRate.Name = "txtbBenignVirusRate";
            this.txtbBenignVirusRate.Size = new System.Drawing.Size(112, 20);
            this.txtbBenignVirusRate.TabIndex = 15;
            this.txtbBenignVirusRate.Text = "10";
            // 
            // txtContiguos
            // 
            this.txtContiguos.Location = new System.Drawing.Point(72, 256);
            this.txtContiguos.Name = "txtContiguos";
            this.txtContiguos.Size = new System.Drawing.Size(113, 20);
            this.txtContiguos.TabIndex = 14;
            this.txtContiguos.Text = "16";
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
            this.txtHamming.Text = "8";
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
            // tabpgBuildClustering
            // 
            this.tabpgBuildClustering.Controls.Add(this.panel2);
            this.tabpgBuildClustering.Controls.Add(this.groupBox2);
            this.tabpgBuildClustering.Location = new System.Drawing.Point(4, 22);
            this.tabpgBuildClustering.Name = "tabpgBuildClustering";
            this.tabpgBuildClustering.Padding = new System.Windows.Forms.Padding(3);
            this.tabpgBuildClustering.Size = new System.Drawing.Size(744, 538);
            this.tabpgBuildClustering.TabIndex = 1;
            this.tabpgBuildClustering.Text = "Build Clustering/Classifier";
            this.tabpgBuildClustering.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(249, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(492, 532);
            this.panel2.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnPrintNeuron);
            this.groupBox2.Controls.Add(this.btnStartClustering);
            this.groupBox2.Controls.Add(this.txtbClusteringFile);
            this.groupBox2.Controls.Add(this.btnClustering);
            this.groupBox2.Controls.Add(this.btnLoad);
            this.groupBox2.Controls.Add(this.btnSaveClustering);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(246, 532);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Function";
            // 
            // btnPrintNeuron
            // 
            this.btnPrintNeuron.Location = new System.Drawing.Point(22, 268);
            this.btnPrintNeuron.Name = "btnPrintNeuron";
            this.btnPrintNeuron.Size = new System.Drawing.Size(196, 34);
            this.btnPrintNeuron.TabIndex = 5;
            this.btnPrintNeuron.Text = "Print Neuron";
            this.btnPrintNeuron.UseVisualStyleBackColor = true;
            this.btnPrintNeuron.Click += new System.EventHandler(this.btnPrintNeuron_Click);
            // 
            // btnStartClustering
            // 
            this.btnStartClustering.Location = new System.Drawing.Point(22, 212);
            this.btnStartClustering.Name = "btnStartClustering";
            this.btnStartClustering.Size = new System.Drawing.Size(196, 34);
            this.btnStartClustering.TabIndex = 4;
            this.btnStartClustering.Text = "Start Clustering";
            this.btnStartClustering.UseVisualStyleBackColor = true;
            this.btnStartClustering.Click += new System.EventHandler(this.btnStartClustering_Click);
            // 
            // txtbClusteringFile
            // 
            this.txtbClusteringFile.Location = new System.Drawing.Point(22, 58);
            this.txtbClusteringFile.Name = "txtbClusteringFile";
            this.txtbClusteringFile.Size = new System.Drawing.Size(196, 20);
            this.txtbClusteringFile.TabIndex = 3;
            // 
            // btnClustering
            // 
            this.btnClustering.Location = new System.Drawing.Point(22, 20);
            this.btnClustering.Name = "btnClustering";
            this.btnClustering.Size = new System.Drawing.Size(196, 31);
            this.btnClustering.TabIndex = 2;
            this.btnClustering.Text = "Clustering File";
            this.btnClustering.UseVisualStyleBackColor = true;
            this.btnClustering.Click += new System.EventHandler(this.btnClassifier_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(22, 142);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(196, 36);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnSaveClustering
            // 
            this.btnSaveClustering.Location = new System.Drawing.Point(22, 94);
            this.btnSaveClustering.Name = "btnSaveClustering";
            this.btnSaveClustering.Size = new System.Drawing.Size(196, 34);
            this.btnSaveClustering.TabIndex = 0;
            this.btnSaveClustering.Text = "Save";
            this.btnSaveClustering.UseVisualStyleBackColor = true;
            this.btnSaveClustering.Click += new System.EventHandler(this.btnSaveClustering_Click);
            // 
            // tabpgBuildFileClassifier
            // 
            this.tabpgBuildFileClassifier.Controls.Add(this.label7);
            this.tabpgBuildFileClassifier.Controls.Add(this.txtbFormatRange);
            this.tabpgBuildFileClassifier.Controls.Add(this.txtbFileClassifierFile);
            this.tabpgBuildFileClassifier.Controls.Add(this.btnFileClassifierFile);
            this.tabpgBuildFileClassifier.Controls.Add(this.btnLoadFileClassifier);
            this.tabpgBuildFileClassifier.Controls.Add(this.btnSaveFileClassifier);
            this.tabpgBuildFileClassifier.Controls.Add(this.btnBuildFileClassifier);
            this.tabpgBuildFileClassifier.Location = new System.Drawing.Point(4, 22);
            this.tabpgBuildFileClassifier.Name = "tabpgBuildFileClassifier";
            this.tabpgBuildFileClassifier.Padding = new System.Windows.Forms.Padding(3);
            this.tabpgBuildFileClassifier.Size = new System.Drawing.Size(744, 538);
            this.tabpgBuildFileClassifier.TabIndex = 2;
            this.tabpgBuildFileClassifier.Text = "Build File Classifier";
            this.tabpgBuildFileClassifier.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(57, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(170, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Format Range (Dangerous Range)";
            // 
            // txtbFormatRange
            // 
            this.txtbFormatRange.Location = new System.Drawing.Point(60, 145);
            this.txtbFormatRange.Name = "txtbFormatRange";
            this.txtbFormatRange.Size = new System.Drawing.Size(196, 20);
            this.txtbFormatRange.TabIndex = 6;
            // 
            // txtbFileClassifierFile
            // 
            this.txtbFileClassifierFile.Location = new System.Drawing.Point(54, 74);
            this.txtbFileClassifierFile.Name = "txtbFileClassifierFile";
            this.txtbFileClassifierFile.Size = new System.Drawing.Size(196, 20);
            this.txtbFileClassifierFile.TabIndex = 5;
            // 
            // btnFileClassifierFile
            // 
            this.btnFileClassifierFile.Location = new System.Drawing.Point(54, 36);
            this.btnFileClassifierFile.Name = "btnFileClassifierFile";
            this.btnFileClassifierFile.Size = new System.Drawing.Size(196, 31);
            this.btnFileClassifierFile.TabIndex = 4;
            this.btnFileClassifierFile.Text = "File Classifier File";
            this.btnFileClassifierFile.UseVisualStyleBackColor = true;
            this.btnFileClassifierFile.Click += new System.EventHandler(this.btnFileClassifierFile_Click);
            // 
            // btnLoadFileClassifier
            // 
            this.btnLoadFileClassifier.Location = new System.Drawing.Point(69, 351);
            this.btnLoadFileClassifier.Name = "btnLoadFileClassifier";
            this.btnLoadFileClassifier.Size = new System.Drawing.Size(109, 27);
            this.btnLoadFileClassifier.TabIndex = 2;
            this.btnLoadFileClassifier.Text = "Load File Classifier";
            this.btnLoadFileClassifier.UseVisualStyleBackColor = true;
            this.btnLoadFileClassifier.Click += new System.EventHandler(this.btnLoadFileClassifier_Click);
            // 
            // btnSaveFileClassifier
            // 
            this.btnSaveFileClassifier.Location = new System.Drawing.Point(69, 280);
            this.btnSaveFileClassifier.Name = "btnSaveFileClassifier";
            this.btnSaveFileClassifier.Size = new System.Drawing.Size(109, 27);
            this.btnSaveFileClassifier.TabIndex = 1;
            this.btnSaveFileClassifier.Text = "Save File Classifier";
            this.btnSaveFileClassifier.UseVisualStyleBackColor = true;
            this.btnSaveFileClassifier.Click += new System.EventHandler(this.btnSaveFileClassifier_Click);
            // 
            // btnBuildFileClassifier
            // 
            this.btnBuildFileClassifier.Location = new System.Drawing.Point(69, 200);
            this.btnBuildFileClassifier.Name = "btnBuildFileClassifier";
            this.btnBuildFileClassifier.Size = new System.Drawing.Size(109, 27);
            this.btnBuildFileClassifier.TabIndex = 0;
            this.btnBuildFileClassifier.Text = "Build File Classifier";
            this.btnBuildFileClassifier.UseVisualStyleBackColor = true;
            this.btnBuildFileClassifier.Click += new System.EventHandler(this.btnBuildFileClassifier_Click);
            // 
            // tabPgVirusScanner
            // 
            this.tabPgVirusScanner.Controls.Add(this.btnScanVirus);
            this.tabPgVirusScanner.Location = new System.Drawing.Point(4, 22);
            this.tabPgVirusScanner.Name = "tabPgVirusScanner";
            this.tabPgVirusScanner.Padding = new System.Windows.Forms.Padding(3);
            this.tabPgVirusScanner.Size = new System.Drawing.Size(744, 538);
            this.tabPgVirusScanner.TabIndex = 3;
            this.tabPgVirusScanner.Text = "Virus Scanner";
            this.tabPgVirusScanner.UseVisualStyleBackColor = true;
            // 
            // btnScanVirus
            // 
            this.btnScanVirus.Location = new System.Drawing.Point(161, 138);
            this.btnScanVirus.Name = "btnScanVirus";
            this.btnScanVirus.Size = new System.Drawing.Size(143, 26);
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
            this.ClientSize = new System.Drawing.Size(962, 658);
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
            this.tabpgBuildDetector.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGroupView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNegativeSelection)).EndInit();
            this.panelTabRight.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabpgBuildClustering.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabpgBuildFileClassifier.ResumeLayout(false);
            this.tabpgBuildFileClassifier.PerformLayout();
            this.tabPgVirusScanner.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.GroupBox grbOutput;
        private System.Windows.Forms.Button btnSaveDetector;
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
        private System.Windows.Forms.TabPage tabpgBuildDetector;
        private System.Windows.Forms.TabPage tabpgBuildClustering;
        private System.Windows.Forms.TabPage tabpgBuildFileClassifier;
        private System.Windows.Forms.TabPage tabPgVirusScanner;
        private System.Windows.Forms.ProgressBar progressBar2;
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
        private System.Windows.Forms.Button btnLoadDetector;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnSaveClustering;
        private System.Windows.Forms.TextBox txtbClusteringFile;
        private System.Windows.Forms.Button btnClustering;
        private System.Windows.Forms.Button btnStartClustering;
        private System.Windows.Forms.Button btnPrintNeuron;
        private System.Windows.Forms.Button btnLoadFileClassifier;
        private System.Windows.Forms.Button btnSaveFileClassifier;
        private System.Windows.Forms.Button btnBuildFileClassifier;
        private System.Windows.Forms.Button btnScanVirus;
        private System.Windows.Forms.TextBox txtbFileClassifierFile;
        private System.Windows.Forms.Button btnFileClassifierFile;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtbFormatRange;
        private System.Windows.Forms.TextBox txtbVirusFragmentsCount;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtbBenignSize;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtbVirusSize;
        private System.Windows.Forms.CheckBox cbxUseRate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtbBenignVirusRate;
        private System.Windows.Forms.Button btnMixDetector;
    }
}

