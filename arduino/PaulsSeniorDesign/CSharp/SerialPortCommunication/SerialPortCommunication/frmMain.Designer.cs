namespace PCComm
{
    partial class frmMain
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
           this.cboData = new System.Windows.Forms.ComboBox();
           this.label4 = new System.Windows.Forms.Label();
           this.label5 = new System.Windows.Forms.Label();
           this.groupBox3 = new System.Windows.Forms.GroupBox();
           this.rdoText = new System.Windows.Forms.RadioButton();
           this.rdoHex = new System.Windows.Forms.RadioButton();
           this.cboStop = new System.Windows.Forms.ComboBox();
           this.GroupBox1 = new System.Windows.Forms.GroupBox();
           this.cmdSend = new System.Windows.Forms.Button();
           this.txtSend = new System.Windows.Forms.TextBox();
           this.rtbDisplay = new System.Windows.Forms.RichTextBox();
           this.label3 = new System.Windows.Forms.Label();
           this.groupBox2 = new System.Windows.Forms.GroupBox();
           this.label2 = new System.Windows.Forms.Label();
           this.cboParity = new System.Windows.Forms.ComboBox();
           this.Label1 = new System.Windows.Forms.Label();
           this.cboBaud = new System.Windows.Forms.ComboBox();
           this.cboPort = new System.Windows.Forms.ComboBox();
           this.cmdOpen = new System.Windows.Forms.Button();
           this.chkNewLine = new System.Windows.Forms.CheckBox();
           this.groupBox3.SuspendLayout();
           this.GroupBox1.SuspendLayout();
           this.groupBox2.SuspendLayout();
           this.SuspendLayout();
           // 
           // cboData
           // 
           this.cboData.FormattingEnabled = true;
           this.cboData.Items.AddRange(new object[] {
            "7",
            "8",
            "9"});
           this.cboData.Location = new System.Drawing.Point(9, 195);
           this.cboData.Name = "cboData";
           this.cboData.Size = new System.Drawing.Size(76, 21);
           this.cboData.TabIndex = 14;
           // 
           // label4
           // 
           this.label4.AutoSize = true;
           this.label4.Location = new System.Drawing.Point(7, 139);
           this.label4.Name = "label4";
           this.label4.Size = new System.Drawing.Size(49, 13);
           this.label4.TabIndex = 18;
           this.label4.Text = "Stop Bits";
           // 
           // label5
           // 
           this.label5.AutoSize = true;
           this.label5.Location = new System.Drawing.Point(6, 179);
           this.label5.Name = "label5";
           this.label5.Size = new System.Drawing.Size(50, 13);
           this.label5.TabIndex = 19;
           this.label5.Text = "Data Bits";
           // 
           // groupBox3
           // 
           this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
           this.groupBox3.Controls.Add(this.rdoText);
           this.groupBox3.Controls.Add(this.rdoHex);
           this.groupBox3.Location = new System.Drawing.Point(394, 240);
           this.groupBox3.Name = "groupBox3";
           this.groupBox3.Size = new System.Drawing.Size(100, 60);
           this.groupBox3.TabIndex = 7;
           this.groupBox3.TabStop = false;
           this.groupBox3.Text = "Mode";
           // 
           // rdoText
           // 
           this.rdoText.AutoSize = true;
           this.rdoText.Location = new System.Drawing.Point(6, 38);
           this.rdoText.Name = "rdoText";
           this.rdoText.Size = new System.Drawing.Size(46, 17);
           this.rdoText.TabIndex = 1;
           this.rdoText.TabStop = true;
           this.rdoText.Text = "Text";
           this.rdoText.UseVisualStyleBackColor = true;
           // 
           // rdoHex
           // 
           this.rdoHex.AutoSize = true;
           this.rdoHex.Location = new System.Drawing.Point(6, 16);
           this.rdoHex.Name = "rdoHex";
           this.rdoHex.Size = new System.Drawing.Size(44, 17);
           this.rdoHex.TabIndex = 0;
           this.rdoHex.TabStop = true;
           this.rdoHex.Text = "Hex";
           this.rdoHex.UseVisualStyleBackColor = true;
           this.rdoHex.CheckedChanged += new System.EventHandler(this.rdoHex_CheckedChanged);
           // 
           // cboStop
           // 
           this.cboStop.FormattingEnabled = true;
           this.cboStop.Location = new System.Drawing.Point(9, 155);
           this.cboStop.Name = "cboStop";
           this.cboStop.Size = new System.Drawing.Size(76, 21);
           this.cboStop.TabIndex = 13;
           // 
           // GroupBox1
           // 
           this.GroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                       | System.Windows.Forms.AnchorStyles.Left)
                       | System.Windows.Forms.AnchorStyles.Right)));
           this.GroupBox1.Controls.Add(this.cmdSend);
           this.GroupBox1.Controls.Add(this.txtSend);
           this.GroupBox1.Controls.Add(this.rtbDisplay);
           this.GroupBox1.Location = new System.Drawing.Point(12, 12);
           this.GroupBox1.Name = "GroupBox1";
           this.GroupBox1.Size = new System.Drawing.Size(376, 347);
           this.GroupBox1.TabIndex = 4;
           this.GroupBox1.TabStop = false;
           this.GroupBox1.Text = "Serial Port Communication";
           // 
           // cmdSend
           // 
           this.cmdSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
           this.cmdSend.Location = new System.Drawing.Point(295, 318);
           this.cmdSend.Name = "cmdSend";
           this.cmdSend.Size = new System.Drawing.Size(75, 23);
           this.cmdSend.TabIndex = 5;
           this.cmdSend.Text = "Send";
           this.cmdSend.UseVisualStyleBackColor = true;
           this.cmdSend.Click += new System.EventHandler(this.cmdSend_Click);
           // 
           // txtSend
           // 
           this.txtSend.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                       | System.Windows.Forms.AnchorStyles.Right)));
           this.txtSend.Location = new System.Drawing.Point(7, 318);
           this.txtSend.Name = "txtSend";
           this.txtSend.Size = new System.Drawing.Size(282, 20);
           this.txtSend.TabIndex = 4;
           // 
           // rtbDisplay
           // 
           this.rtbDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                       | System.Windows.Forms.AnchorStyles.Left)
                       | System.Windows.Forms.AnchorStyles.Right)));
           this.rtbDisplay.Location = new System.Drawing.Point(7, 19);
           this.rtbDisplay.Name = "rtbDisplay";
           this.rtbDisplay.Size = new System.Drawing.Size(363, 293);
           this.rtbDisplay.TabIndex = 3;
           this.rtbDisplay.Text = "";
           // 
           // label3
           // 
           this.label3.AutoSize = true;
           this.label3.Location = new System.Drawing.Point(6, 98);
           this.label3.Name = "label3";
           this.label3.Size = new System.Drawing.Size(33, 13);
           this.label3.TabIndex = 17;
           this.label3.Text = "Parity";
           // 
           // groupBox2
           // 
           this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
           this.groupBox2.Controls.Add(this.label5);
           this.groupBox2.Controls.Add(this.cboData);
           this.groupBox2.Controls.Add(this.label4);
           this.groupBox2.Controls.Add(this.cboStop);
           this.groupBox2.Controls.Add(this.label3);
           this.groupBox2.Controls.Add(this.label2);
           this.groupBox2.Controls.Add(this.cboParity);
           this.groupBox2.Controls.Add(this.Label1);
           this.groupBox2.Controls.Add(this.cboBaud);
           this.groupBox2.Controls.Add(this.cboPort);
           this.groupBox2.Location = new System.Drawing.Point(398, 13);
           this.groupBox2.Name = "groupBox2";
           this.groupBox2.Size = new System.Drawing.Size(96, 221);
           this.groupBox2.TabIndex = 6;
           this.groupBox2.TabStop = false;
           this.groupBox2.Text = "Options";
           // 
           // label2
           // 
           this.label2.AutoSize = true;
           this.label2.Location = new System.Drawing.Point(6, 58);
           this.label2.Name = "label2";
           this.label2.Size = new System.Drawing.Size(58, 13);
           this.label2.TabIndex = 16;
           this.label2.Text = "Baud Rate";
           // 
           // cboParity
           // 
           this.cboParity.FormattingEnabled = true;
           this.cboParity.Location = new System.Drawing.Point(9, 114);
           this.cboParity.Name = "cboParity";
           this.cboParity.Size = new System.Drawing.Size(76, 21);
           this.cboParity.TabIndex = 12;
           // 
           // Label1
           // 
           this.Label1.AutoSize = true;
           this.Label1.Location = new System.Drawing.Point(6, 18);
           this.Label1.Name = "Label1";
           this.Label1.Size = new System.Drawing.Size(26, 13);
           this.Label1.TabIndex = 15;
           this.Label1.Text = "Port";
           // 
           // cboBaud
           // 
           this.cboBaud.FormattingEnabled = true;
           this.cboBaud.Items.AddRange(new object[] {
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "28800",
            "36000",
            "115000"});
           this.cboBaud.Location = new System.Drawing.Point(9, 74);
           this.cboBaud.Name = "cboBaud";
           this.cboBaud.Size = new System.Drawing.Size(76, 21);
           this.cboBaud.TabIndex = 11;
           // 
           // cboPort
           // 
           this.cboPort.FormattingEnabled = true;
           this.cboPort.Location = new System.Drawing.Point(9, 34);
           this.cboPort.Name = "cboPort";
           this.cboPort.Size = new System.Drawing.Size(76, 21);
           this.cboPort.TabIndex = 10;
           // 
           // cmdOpen
           // 
           this.cmdOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
           this.cmdOpen.Location = new System.Drawing.Point(400, 335);
           this.cmdOpen.Name = "cmdOpen";
           this.cmdOpen.Size = new System.Drawing.Size(100, 23);
           this.cmdOpen.TabIndex = 8;
           this.cmdOpen.Text = "Open Port";
           this.cmdOpen.UseVisualStyleBackColor = true;
           this.cmdOpen.Click += new System.EventHandler(this.cmdOpen_Click);
           // 
           // chkNewLine
           // 
           this.chkNewLine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
           this.chkNewLine.AutoSize = true;
           this.chkNewLine.Location = new System.Drawing.Point(394, 306);
           this.chkNewLine.Name = "chkNewLine";
           this.chkNewLine.Size = new System.Drawing.Size(104, 17);
           this.chkNewLine.TabIndex = 9;
           this.chkNewLine.Text = "Append Newline";
           this.chkNewLine.UseVisualStyleBackColor = true;
           this.chkNewLine.CheckedChanged += new System.EventHandler(this.chkNewLine_CheckedChanged);
           // 
           // frmMain
           // 
           this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
           this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
           this.ClientSize = new System.Drawing.Size(508, 364);
           this.Controls.Add(this.chkNewLine);
           this.Controls.Add(this.groupBox3);
           this.Controls.Add(this.GroupBox1);
           this.Controls.Add(this.groupBox2);
           this.Controls.Add(this.cmdOpen);
           this.MinimumSize = new System.Drawing.Size(524, 402);
           this.Name = "frmMain";
           this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
           this.Text = "frmMain";
           this.Load += new System.EventHandler(this.frmMain_Load);
           this.groupBox3.ResumeLayout(false);
           this.groupBox3.PerformLayout();
           this.GroupBox1.ResumeLayout(false);
           this.GroupBox1.PerformLayout();
           this.groupBox2.ResumeLayout(false);
           this.groupBox2.PerformLayout();
           this.ResumeLayout(false);
           this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboData;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdoText;
        private System.Windows.Forms.RadioButton rdoHex;
        private System.Windows.Forms.ComboBox cboStop;
        private System.Windows.Forms.GroupBox GroupBox1;
        private System.Windows.Forms.Button cmdSend;
        private System.Windows.Forms.TextBox txtSend;
        private System.Windows.Forms.RichTextBox rtbDisplay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboParity;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.ComboBox cboBaud;
        private System.Windows.Forms.ComboBox cboPort;
        private System.Windows.Forms.Button cmdOpen;
        private System.Windows.Forms.CheckBox chkNewLine;
    }
}