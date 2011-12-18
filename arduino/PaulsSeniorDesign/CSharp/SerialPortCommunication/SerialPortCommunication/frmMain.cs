using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using PCComm;
namespace PCComm
{
    public partial class frmMain : Form
    {
        CommunicationManager comm = new CommunicationManager();
        string transType = string.Empty;
        PerformanceCounter cpuCounter;
        PerformanceCounter ramCounter;
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
           LoadValues();
           SetDefaults();
           SetControlState();
           cpuCounter = new PerformanceCounter();

           cpuCounter.CategoryName = "Processor";
           cpuCounter.CounterName = "% Processor Time";
           cpuCounter.InstanceName = "_Total";

           ramCounter = new PerformanceCounter("Memory", "% Committed Bytes In Use");
        }

        private void cmdOpen_Click(object sender, EventArgs e)
        {
            comm.PortName = cboPort.SelectedItem.ToString();
            comm.Parity = cboParity.Text;
            comm.StopBits = cboStop.Text;
            comm.DataBits = cboData.Text;
            comm.BaudRate = cboBaud.Text;
            comm.DisplayWindow = rtbDisplay;
            comm.OpenPort();

            cmdSend.Enabled = true;
        }

        /// <summary>
        /// Method to initialize serial port
        /// values to standard defaults
        /// </summary>
        private void SetDefaults()
        {
            cboPort.SelectedIndex = 0;
            cboBaud.SelectedText = "9600";
            cboParity.SelectedIndex = 0;
            cboStop.SelectedIndex = 1;
            cboData.SelectedIndex = 1;
        }

        /// <summary>
        /// methos to load our serial
        /// port option values
        /// </summary>
        private void LoadValues()
        {
            comm.SetPortNameValues(cboPort);
            comm.SetParityValues(cboParity);
            comm.SetStopBitValues(cboStop);
        }

        /// <summary>
        /// method to set the state of controls
        /// when the form first loads
        /// </summary>
        private void SetControlState()
        {
            rdoText.Checked = true;
            cmdSend.Enabled = false;
        }

        private void cmdSend_Click(object sender, EventArgs e)
        {
            comm.WriteData(txtSend.Text);
        }

        private void rdoHex_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoHex.Checked == true)
            {
                comm.CurrentTransmissionType = PCComm.CommunicationManager.TransmissionType.Hex;
            }
            else
            {
                comm.CurrentTransmissionType = PCComm.CommunicationManager.TransmissionType.Text;
            }
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {

        }

        private void chkNewLine_CheckedChanged(object sender, EventArgs e)
        {
           comm.AppendNewline = chkNewLine.Checked;
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            comm.ClosePort();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            while (true)
            {
                float cpuValue = cpuCounter.NextValue() / 100;
                byte convertedValue = Convert.ToByte(64.0 * cpuValue);
                byte disp = Convert.ToByte(0 | convertedValue);
                rtbDisplay.AppendText(cpuValue + "\t" + convertedValue + "\t" + disp + "\n");
                byte[] test = { disp };
                comm.WriteData(comm.ByteToHex(test));
                System.Threading.Thread.Sleep(500);
            }
            


            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}