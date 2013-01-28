using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace AnalogGauges
{
    public partial class AnalogGaugeCmd : Form
    {
        private CommManager cm;
        private StatWrapper lftStatWrapper;
        private StatWrapper rhtStatWrapper;

        #region Common Form UI Functions
        public AnalogGaugeCmd()
        {
            InitializeComponent();
            cm = new CommManager();
            cm._rtbOutputComm = rtbOutput;
        }

        private void AnalogGaugeCmd_Load(object sender, EventArgs e)
        {
            loadPorts();
            loadCounterTypes();
            loadSettings();
        }

        private void AnalogGaugeCmd_FormClosed(object sender, FormClosedEventArgs e)
        {
            closePort();
            saveSettings();
        }

        private void btnOpenPort_Click(object sender, EventArgs e)
        {
            openPort();
        }

        private void btnClosePort_Click(object sender, EventArgs e)
        {
            closePort();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadPorts();
        }

        private void loadPorts()
        {
            String[] portList = CMTools.GetCommPortList();
            cmbPortList.Items.Clear();
            cmbPortList.Items.AddRange(portList);
            if (cmbPortList.Items.Count > 0)
            {
                cmbPortList.SelectedIndex = 0;
            }
        }

        public void loadCounterTypes()
        {
            cmbLftGaugeType.Items.Clear();
            cmbLftGaugeType.Items.AddRange(StatWrapper.getStatTypeNames());
            if (cmbLftGaugeType.Items.Count > 0)
                cmbLftGaugeType.SelectedIndex = 0;


            cmbRhtGaugeType.Items.Clear();
            cmbRhtGaugeType.Items.AddRange(StatWrapper.getStatTypeNames());
            if (cmbRhtGaugeType.Items.Count > 0)
                cmbRhtGaugeType.SelectedIndex = 0;
        }

        private void loadSettings()
        {
            // General Form Settings
            cmbPortList.SelectedItem = Properties.Settings.Default.Port;

            // Left Gauge Settings
            cmbLftGaugeType.SelectedItem = Properties.Settings.Default.LftGaugeType;
            txtLftAvg.Text = Properties.Settings.Default.LftGaugeAvg;
            txtLftRefresh.Text = Properties.Settings.Default.LftGaugeRfrsh;

            // Right Gauge Settings
            cmbRhtGaugeType.SelectedItem = Properties.Settings.Default.RhtGaugeType;
            txtRhtAvg.Text = Properties.Settings.Default.RhtGaugeAvg;
            txtRhtRefresh.Text = Properties.Settings.Default.RhtGaugeRfrsh;

        }

        private void saveSettings()
        {
            // General Form Settings
            Properties.Settings.Default.Port = (string)cmbPortList.SelectedItem;

            // Left Gauge Settings
            Properties.Settings.Default.LftGaugeType = (string)cmbLftGaugeType.SelectedItem;
            Properties.Settings.Default.LftGaugeAvg = txtLftAvg.Text;
            Properties.Settings.Default.LftGaugeRfrsh = txtLftRefresh.Text;

            // Right Gauge Settings
            Properties.Settings.Default.RhtGaugeType = (string)cmbRhtGaugeType.SelectedItem;
            Properties.Settings.Default.RhtGaugeAvg = txtRhtAvg.Text;
            Properties.Settings.Default.RhtGaugeRfrsh = txtRhtRefresh.Text;

            // Save the settings
            Properties.Settings.Default.Save();
        }
        #endregion

        #region Port Functions
        private void openPort()
        {
            if (cm.isOpen())
                cm.ClosePort();

            cm.PortName = (string)cmbPortList.SelectedItem;
            cm.OpenPort();

            updatePortStatus();
        }


        private void closePort()
        {
            chkLftEnable.Checked = false;
            chkRhtEnable.Checked = false;
            if (cm.isOpen())
                cm.ClosePort();

            updatePortStatus();
        }

        private void updatePortStatus()
        {
            if (cm.isOpen())
            {
                btnOpenPort.Enabled = false;
                btnClosePort.Enabled = true;
                rtbOutput.AppendText("Port " + cm.PortName + " is open.\n");
                tssPort.Text = cm.PortName;
                tssPortStatus.Text = "Open";
            }
            else
            {
                btnOpenPort.Enabled = true;
                btnClosePort.Enabled = false;
                rtbOutput.AppendText("Port  " + cm.PortName + " is closed.\n");
                tssPortStatus.Text = "Closed";
            }

        }
        #endregion

        #region Comm Debugging


        private void btnSend_Click(object sender, EventArgs e)
        {
            if (cm.isOpen())
            {
                int i;
                cm.SendBytes(CMTools.GetBytes(txtMsg.Text, out i));
                rtbOutput.AppendText("Sent: " + txtMsg.Text + "\n");
            }
            else
            {
                rtbOutput.AppendText("Port is not open.\n");
            }
        }

        #endregion

        #region delete me.
        private void button1_Click(object sender, EventArgs e)
        {
            openPort();

            if (textBox1.Text.Length <= 0)
                textBox1.Text = "0";

            int fromTxtBox = Convert.ToInt32(textBox1.Text);

            byte percentValue = CMTools.getByteFromPercent(fromTxtBox);

            byte[] sendValue = new byte[1];
            if(chkLftDsp.Checked) 
            {
                sendValue[0] = percentValue;
                cm.SendBytes(sendValue);
            }
            if(chkRhtDsp.Checked) 
            {
                sendValue[0] = (byte)(64 | percentValue); // Set the Disp ID # to 1 for the right display
                cm.SendBytes(sendValue);
            }
            //MessageBox.Show(sendValue.ToString());

        }



        private void button2_Click(object sender, EventArgs e)
        {
            //if (textBox1.Text.Length > 0) {
            //    timer1.Interval = Convert.ToInt32(textBox1.Text);
            //}


            //timer1.Enabled = !timer1.Enabled;
            //if (timer1.Enabled)
            //    btnToggleCPU.Text = "Stop CPU Thread";
            //else
            //    btnToggleCPU.Text = "Start CPU Thread";

        }

        //int curPercent = 0;
        //static int maxPercent = 4;
        //byte[] percentageLag = new byte[maxPercent];

        //private byte avgPercent() {
        //    int total = 0;
        //    for(int i = 0; i < maxPercent; i++) {
        //        total += percentageLag[i];
        //    }

        //    return (byte)(total/maxPercent);
        //}

        private void timer1_Tick(object sender, EventArgs e)
        {

        //    int cpuPercent = (int)lftCounter.NextValue();

        //    percentageLag[curPercent++ % maxPercent] = CMTools.getByteFromPercent(cpuPercent);
        //    byte percentValue = avgPercent();

        //    openPort();

        //    byte[] sendValue = new byte[1];
        //    if (chkLftDsp.Checked)
        //    {
        //        sendValue[0] = percentValue;
        //        cm.SendBytes(sendValue);
        //    }
        //    if (chkRhtDsp.Checked)
        //    {
        //        sendValue[0] = (byte)(64 | percentValue); // Set the Disp ID # to 1 for the right display
        //        cm.SendBytes(sendValue);
        //    }
        }
#endregion

        #region Gauge Settings

        private void chkLftEnable_CheckedChanged(object sender, EventArgs e)
        {
            // TODO: NOTE: I will need to prevent races at the comm.send() function.

            // Grab & Initialize Interval
            int intRefreshRate = int.Parse(txtLftRefresh.Text);
            tmrLftGauge.Interval = intRefreshRate;

            // Grab moving average
            int intMovingAvg = int.Parse(txtLftAvg.Text);

            // Initialize the StatWrapper
            lftStatWrapper = new StatWrapper(StatWrapper.getStatType((string)cmbLftGaugeType.SelectedItem), intMovingAvg);

            tmrLftGauge.Enabled = chkLftEnable.Checked;

        }

        private void chkRhtEnable_CheckedChanged(object sender, EventArgs e)
        {
            // TODO: NOTE: I will need to prevent races at the comm.send() function.

            // Grab & Initialize Interval
            int intRefreshRate = int.Parse(txtRhtRefresh.Text);
            tmrRhtGauge.Interval = intRefreshRate;

            // Grab moving average
            int intMovingAvg = int.Parse(txtRhtAvg.Text);

            // Initialize the StatWrapper
            rhtStatWrapper = new StatWrapper(StatWrapper.getStatType((string)cmbRhtGaugeType.SelectedItem), intMovingAvg);

            tmrRhtGauge.Enabled = chkRhtEnable.Checked;
        }

        private void tmrLftGauge_Tick(object sender, EventArgs e)
        {
            if(!cm.isOpen())
                openPort();

            byte[] sendByte = new byte[1];
            sendByte[0] = (byte)(AGConstants.DISP_ID_0 | CMTools.getByteFromPercent(lftStatWrapper.getValue()));
            cm.SendBytes(sendByte);
        }

        private void tmrRhtGauge_Tick(object sender, EventArgs e)
        {
            if (!cm.isOpen())
                openPort();

            byte[] sendByte = new byte[1];
            sendByte[0] = (byte)(AGConstants.DISP_ID_1 | CMTools.getByteFromPercent(rhtStatWrapper.getValue()));
            cm.SendBytes(sendByte);

        }
        #endregion

        private void button2_Click_1(object sender, EventArgs e)
        {

            //PerformanceCounter RhtCounter = AGTools.getCounter(AGTools.getCounterType((string)cmbRhtGaugeType.SelectedItem));

            //MessageBox.Show(RhtCounter.NextSample().RawValue.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label2.Text = AGTools.getDirectorySize("Z:\\SCM\\2012.0.0\\ProductInstallers").ToString();
        }


    }
}