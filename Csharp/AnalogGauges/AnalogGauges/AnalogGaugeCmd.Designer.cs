namespace AnalogGauges
{
    partial class AnalogGaugeCmd
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslblPort = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssPort = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssPortStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnOpenPort = new System.Windows.Forms.Button();
            this.txtMsg = new System.Windows.Forms.TextBox();
            this.rtbOutput = new System.Windows.Forms.RichTextBox();
            this.btnClosePort = new System.Windows.Forms.Button();
            this.cmbPortList = new System.Windows.Forms.ComboBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpDebug = new System.Windows.Forms.TabPage();
            this.tpGaugeCtrl = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.btnToggleCPU = new System.Windows.Forms.Button();
            this.chkRhtDsp = new System.Windows.Forms.CheckBox();
            this.chkLftDsp = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tpGaugeSetup = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtLftRefresh = new System.Windows.Forms.TextBox();
            this.txtLftAvg = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chkLftEnable = new System.Windows.Forms.CheckBox();
            this.lblLftGaugeType = new System.Windows.Forms.Label();
            this.cmbLftGaugeType = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtRhtAvg = new System.Windows.Forms.TextBox();
            this.chkRhtEnable = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbRhtGaugeType = new System.Windows.Forms.ComboBox();
            this.txtRhtRefresh = new System.Windows.Forms.TextBox();
            this.lblRhtGaugeType = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tmrLftGauge = new System.Windows.Forms.Timer(this.components);
            this.tmrRhtGauge = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tpDebug.SuspendLayout();
            this.tpGaugeCtrl.SuspendLayout();
            this.tpGaugeSetup.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslblPort,
            this.tssPort,
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.tssPortStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 207);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(396, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "ssStatus";
            // 
            // tsslblPort
            // 
            this.tsslblPort.Name = "tsslblPort";
            this.tsslblPort.Size = new System.Drawing.Size(32, 17);
            this.tsslblPort.Text = "Port:";
            // 
            // tssPort
            // 
            this.tssPort.Name = "tssPort";
            this.tssPort.Size = new System.Drawing.Size(27, 17);
            this.tssPort.Text = "----";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(212, 17);
            this.toolStripStatusLabel1.Spring = true;
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(67, 17);
            this.toolStripStatusLabel2.Text = "Port Status:";
            // 
            // tssPortStatus
            // 
            this.tssPortStatus.Name = "tssPortStatus";
            this.tssPortStatus.Size = new System.Drawing.Size(43, 17);
            this.tssPortStatus.Text = "Closed";
            // 
            // btnOpenPort
            // 
            this.btnOpenPort.Location = new System.Drawing.Point(141, 12);
            this.btnOpenPort.Name = "btnOpenPort";
            this.btnOpenPort.Size = new System.Drawing.Size(121, 23);
            this.btnOpenPort.TabIndex = 9;
            this.btnOpenPort.Text = "Open Port";
            this.btnOpenPort.UseVisualStyleBackColor = true;
            this.btnOpenPort.Click += new System.EventHandler(this.btnOpenPort_Click);
            // 
            // txtMsg
            // 
            this.txtMsg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMsg.Location = new System.Drawing.Point(6, 111);
            this.txtMsg.Name = "txtMsg";
            this.txtMsg.Size = new System.Drawing.Size(268, 20);
            this.txtMsg.TabIndex = 8;
            // 
            // rtbOutput
            // 
            this.rtbOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbOutput.Location = new System.Drawing.Point(6, 6);
            this.rtbOutput.Name = "rtbOutput";
            this.rtbOutput.Size = new System.Drawing.Size(352, 99);
            this.rtbOutput.TabIndex = 7;
            this.rtbOutput.Text = "";
            // 
            // btnClosePort
            // 
            this.btnClosePort.Enabled = false;
            this.btnClosePort.Location = new System.Drawing.Point(268, 12);
            this.btnClosePort.Name = "btnClosePort";
            this.btnClosePort.Size = new System.Drawing.Size(121, 23);
            this.btnClosePort.TabIndex = 6;
            this.btnClosePort.Text = "Close Port";
            this.btnClosePort.UseVisualStyleBackColor = true;
            this.btnClosePort.Click += new System.EventHandler(this.btnClosePort_Click);
            // 
            // cmbPortList
            // 
            this.cmbPortList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPortList.FormattingEnabled = true;
            this.cmbPortList.Location = new System.Drawing.Point(14, 12);
            this.cmbPortList.Name = "cmbPortList";
            this.cmbPortList.Size = new System.Drawing.Size(93, 21);
            this.cmbPortList.TabIndex = 10;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(113, 12);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(22, 23);
            this.btnRefresh.TabIndex = 11;
            this.btnRefresh.Text = "R";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSend
            // 
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSend.Location = new System.Drawing.Point(280, 109);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(78, 23);
            this.btnSend.TabIndex = 12;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tpDebug);
            this.tabControl1.Controls.Add(this.tpGaugeCtrl);
            this.tabControl1.Controls.Add(this.tpGaugeSetup);
            this.tabControl1.Location = new System.Drawing.Point(12, 41);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(372, 163);
            this.tabControl1.TabIndex = 13;
            // 
            // tpDebug
            // 
            this.tpDebug.Controls.Add(this.rtbOutput);
            this.tpDebug.Controls.Add(this.btnSend);
            this.tpDebug.Controls.Add(this.txtMsg);
            this.tpDebug.Location = new System.Drawing.Point(4, 22);
            this.tpDebug.Name = "tpDebug";
            this.tpDebug.Padding = new System.Windows.Forms.Padding(3);
            this.tpDebug.Size = new System.Drawing.Size(364, 137);
            this.tpDebug.TabIndex = 0;
            this.tpDebug.Text = "Serial Debug";
            this.tpDebug.UseVisualStyleBackColor = true;
            // 
            // tpGaugeCtrl
            // 
            this.tpGaugeCtrl.Controls.Add(this.button2);
            this.tpGaugeCtrl.Controls.Add(this.btnToggleCPU);
            this.tpGaugeCtrl.Controls.Add(this.chkRhtDsp);
            this.tpGaugeCtrl.Controls.Add(this.chkLftDsp);
            this.tpGaugeCtrl.Controls.Add(this.label1);
            this.tpGaugeCtrl.Controls.Add(this.button1);
            this.tpGaugeCtrl.Controls.Add(this.textBox1);
            this.tpGaugeCtrl.Location = new System.Drawing.Point(4, 22);
            this.tpGaugeCtrl.Name = "tpGaugeCtrl";
            this.tpGaugeCtrl.Padding = new System.Windows.Forms.Padding(3);
            this.tpGaugeCtrl.Size = new System.Drawing.Size(364, 137);
            this.tpGaugeCtrl.TabIndex = 1;
            this.tpGaugeCtrl.Text = "Gauge Control";
            this.tpGaugeCtrl.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(162, 69);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // btnToggleCPU
            // 
            this.btnToggleCPU.Location = new System.Drawing.Point(6, 52);
            this.btnToggleCPU.Name = "btnToggleCPU";
            this.btnToggleCPU.Size = new System.Drawing.Size(106, 23);
            this.btnToggleCPU.TabIndex = 6;
            this.btnToggleCPU.Text = "Start CPU Proc";
            this.btnToggleCPU.UseVisualStyleBackColor = true;
            this.btnToggleCPU.Click += new System.EventHandler(this.button2_Click);
            // 
            // chkRhtDsp
            // 
            this.chkRhtDsp.AutoSize = true;
            this.chkRhtDsp.Location = new System.Drawing.Point(6, 29);
            this.chkRhtDsp.Name = "chkRhtDsp";
            this.chkRhtDsp.Size = new System.Drawing.Size(88, 17);
            this.chkRhtDsp.TabIndex = 5;
            this.chkRhtDsp.Text = "Right Display";
            this.chkRhtDsp.UseVisualStyleBackColor = true;
            // 
            // chkLftDsp
            // 
            this.chkLftDsp.AutoSize = true;
            this.chkLftDsp.Location = new System.Drawing.Point(6, 6);
            this.chkLftDsp.Name = "chkLftDsp";
            this.chkLftDsp.Size = new System.Drawing.Size(81, 17);
            this.chkLftDsp.TabIndex = 4;
            this.chkLftDsp.Text = "Left Display";
            this.chkLftDsp.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(142, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "%";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(163, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Send %";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(93, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(52, 20);
            this.textBox1.TabIndex = 1;
            // 
            // tpGaugeSetup
            // 
            this.tpGaugeSetup.Controls.Add(this.splitContainer1);
            this.tpGaugeSetup.Controls.Add(this.splitter1);
            this.tpGaugeSetup.Location = new System.Drawing.Point(4, 22);
            this.tpGaugeSetup.Name = "tpGaugeSetup";
            this.tpGaugeSetup.Padding = new System.Windows.Forms.Padding(3);
            this.tpGaugeSetup.Size = new System.Drawing.Size(364, 137);
            this.tpGaugeSetup.TabIndex = 2;
            this.tpGaugeSetup.Text = "Gauge Setup";
            this.tpGaugeSetup.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(6, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Size = new System.Drawing.Size(355, 131);
            this.splitContainer1.SplitterDistance = 175;
            this.splitContainer1.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.txtLftRefresh);
            this.groupBox2.Controls.Add(this.txtLftAvg);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.chkLftEnable);
            this.groupBox2.Controls.Add(this.lblLftGaugeType);
            this.groupBox2.Controls.Add(this.cmbLftGaugeType);
            this.groupBox2.Location = new System.Drawing.Point(7, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(165, 124);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Left Gauge";
            // 
            // txtLftRefresh
            // 
            this.txtLftRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLftRefresh.Location = new System.Drawing.Point(79, 71);
            this.txtLftRefresh.Name = "txtLftRefresh";
            this.txtLftRefresh.Size = new System.Drawing.Size(80, 20);
            this.txtLftRefresh.TabIndex = 7;
            this.txtLftRefresh.Text = "250";
            // 
            // txtLftAvg
            // 
            this.txtLftAvg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLftAvg.Location = new System.Drawing.Point(79, 95);
            this.txtLftAvg.Name = "txtLftAvg";
            this.txtLftAvg.Size = new System.Drawing.Size(80, 20);
            this.txtLftAvg.TabIndex = 6;
            this.txtLftAvg.Text = "4";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Moving Avg:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Refresh (ms):";
            // 
            // chkLftEnable
            // 
            this.chkLftEnable.AutoSize = true;
            this.chkLftEnable.Location = new System.Drawing.Point(7, 20);
            this.chkLftEnable.Name = "chkLftEnable";
            this.chkLftEnable.Size = new System.Drawing.Size(65, 17);
            this.chkLftEnable.TabIndex = 2;
            this.chkLftEnable.Text = "Enabled";
            this.chkLftEnable.UseVisualStyleBackColor = true;
            this.chkLftEnable.CheckedChanged += new System.EventHandler(this.chkLftEnable_CheckedChanged);
            // 
            // lblLftGaugeType
            // 
            this.lblLftGaugeType.AutoSize = true;
            this.lblLftGaugeType.Location = new System.Drawing.Point(7, 46);
            this.lblLftGaugeType.Name = "lblLftGaugeType";
            this.lblLftGaugeType.Size = new System.Drawing.Size(69, 13);
            this.lblLftGaugeType.TabIndex = 1;
            this.lblLftGaugeType.Text = "Gauge Type:";
            // 
            // cmbLftGaugeType
            // 
            this.cmbLftGaugeType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbLftGaugeType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLftGaugeType.FormattingEnabled = true;
            this.cmbLftGaugeType.Items.AddRange(new object[] {
            "% CPU",
            "% RAM"});
            this.cmbLftGaugeType.Location = new System.Drawing.Point(79, 43);
            this.cmbLftGaugeType.Name = "cmbLftGaugeType";
            this.cmbLftGaugeType.Size = new System.Drawing.Size(80, 21);
            this.cmbLftGaugeType.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtRhtAvg);
            this.groupBox1.Controls.Add(this.chkRhtEnable);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cmbRhtGaugeType);
            this.groupBox1.Controls.Add(this.txtRhtRefresh);
            this.groupBox1.Controls.Add(this.lblRhtGaugeType);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(170, 125);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Right Gauge";
            // 
            // txtRhtAvg
            // 
            this.txtRhtAvg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRhtAvg.Location = new System.Drawing.Point(78, 94);
            this.txtRhtAvg.Name = "txtRhtAvg";
            this.txtRhtAvg.Size = new System.Drawing.Size(86, 20);
            this.txtRhtAvg.TabIndex = 13;
            this.txtRhtAvg.Text = "2";
            // 
            // chkRhtEnable
            // 
            this.chkRhtEnable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.chkRhtEnable.AutoSize = true;
            this.chkRhtEnable.Location = new System.Drawing.Point(6, 19);
            this.chkRhtEnable.Name = "chkRhtEnable";
            this.chkRhtEnable.Size = new System.Drawing.Size(65, 17);
            this.chkRhtEnable.TabIndex = 9;
            this.chkRhtEnable.Text = "Enabled";
            this.chkRhtEnable.UseVisualStyleBackColor = true;
            this.chkRhtEnable.CheckedChanged += new System.EventHandler(this.chkRhtEnable_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Moving Avg:";
            // 
            // cmbRhtGaugeType
            // 
            this.cmbRhtGaugeType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbRhtGaugeType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRhtGaugeType.FormattingEnabled = true;
            this.cmbRhtGaugeType.Items.AddRange(new object[] {
            "% CPU",
            "% RAM"});
            this.cmbRhtGaugeType.Location = new System.Drawing.Point(78, 42);
            this.cmbRhtGaugeType.Name = "cmbRhtGaugeType";
            this.cmbRhtGaugeType.Size = new System.Drawing.Size(86, 21);
            this.cmbRhtGaugeType.TabIndex = 7;
            // 
            // txtRhtRefresh
            // 
            this.txtRhtRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRhtRefresh.Location = new System.Drawing.Point(78, 70);
            this.txtRhtRefresh.Name = "txtRhtRefresh";
            this.txtRhtRefresh.Size = new System.Drawing.Size(86, 20);
            this.txtRhtRefresh.TabIndex = 11;
            this.txtRhtRefresh.Text = "500";
            // 
            // lblRhtGaugeType
            // 
            this.lblRhtGaugeType.AutoSize = true;
            this.lblRhtGaugeType.Location = new System.Drawing.Point(6, 45);
            this.lblRhtGaugeType.Name = "lblRhtGaugeType";
            this.lblRhtGaugeType.Size = new System.Drawing.Size(69, 13);
            this.lblRhtGaugeType.TabIndex = 8;
            this.lblRhtGaugeType.Text = "Gauge Type:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Refresh (ms):";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(3, 3);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 131);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 250;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tmrLftGauge
            // 
            this.tmrLftGauge.Tick += new System.EventHandler(this.tmrLftGauge_Tick);
            // 
            // tmrRhtGauge
            // 
            this.tmrRhtGauge.Tick += new System.EventHandler(this.tmrRhtGauge_Tick);
            // 
            // AnalogGaugeCmd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 229);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnClosePort);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.cmbPortList);
            this.Controls.Add(this.btnOpenPort);
            this.MinimumSize = new System.Drawing.Size(412, 267);
            this.Name = "AnalogGaugeCmd";
            this.Text = "AnalogGaugeCmd";
            this.Load += new System.EventHandler(this.AnalogGaugeCmd_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tpDebug.ResumeLayout(false);
            this.tpDebug.PerformLayout();
            this.tpGaugeCtrl.ResumeLayout(false);
            this.tpGaugeCtrl.PerformLayout();
            this.tpGaugeSetup.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsslblPort;
        private System.Windows.Forms.ToolStripStatusLabel tssPort;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel tssPortStatus;
        private System.Windows.Forms.Button btnOpenPort;
        private System.Windows.Forms.TextBox txtMsg;
        private System.Windows.Forms.RichTextBox rtbOutput;
        private System.Windows.Forms.Button btnClosePort;
        private System.Windows.Forms.ComboBox cmbPortList;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpDebug;
        private System.Windows.Forms.TabPage tpGaugeCtrl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox chkRhtDsp;
        private System.Windows.Forms.CheckBox chkLftDsp;
        private System.Windows.Forms.Button btnToggleCPU;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TabPage tpGaugeSetup;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblLftGaugeType;
        private System.Windows.Forms.ComboBox cmbLftGaugeType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkLftEnable;
        private System.Windows.Forms.TextBox txtLftAvg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRhtAvg;
        private System.Windows.Forms.CheckBox chkRhtEnable;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbRhtGaugeType;
        private System.Windows.Forms.TextBox txtRhtRefresh;
        private System.Windows.Forms.Label lblRhtGaugeType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtLftRefresh;
        private System.Windows.Forms.Timer tmrLftGauge;
        private System.Windows.Forms.Timer tmrRhtGauge;
        private System.Windows.Forms.Button button2;
    }
}