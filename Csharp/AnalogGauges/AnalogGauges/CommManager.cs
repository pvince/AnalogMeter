using System;
using System.IO.Ports;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Threading;

namespace AnalogGauges
{
    class CommManager
    {
        #region Local vars, properties, getters, setters
        private static Semaphore commLock = new Semaphore(1, 1);

        // Property Variables
        private string _baudRate = string.Empty;
        private string _portName = string.Empty;
        private SerialPort comPort = new SerialPort();


        /// <summary>
        /// Property to hold the BaudRate
        /// of our manager class
        /// </summary>
        public string BaudRate
        {
            get { return _baudRate; }
            set { _baudRate = value; }
        }

        /// <summary>
        /// property to hold the PortName
        /// of our manager class
        /// </summary>
        public string PortName
        {
            get { return _portName; }
            set { _portName = value; }
        }
        #endregion

        #region Constructors
        // <summary>
        /// Constructor to set the properties of our Manager Class
        /// </summary>
        /// <param name="baud">Desired BaudRate</param>
        /// <param name="name">Desired PortName</param>
        public CommManager(string baud, string name)
        {
            _baudRate = baud;
            _portName = name;

            //now add an event handler
            comPort.DataReceived += new SerialDataReceivedEventHandler(comPort_DataReceived);
        }

        /// <summary>
        /// Comstructor to set the properties of our
        /// serial port communicator to nothing
        /// </summary>
        public CommManager()
        {
            _baudRate = "9600";
            _portName = "COM4";

            //now add an event handler
            comPort.DataReceived += new SerialDataReceivedEventHandler(comPort_DataReceived);
        }
        #endregion

        #region Open // Close Port
        public bool OpenPort()
        {
            try
            {
                //first check if the port is already open
                //if its open then close it
                if (comPort.IsOpen == true) ClosePort();

                //set the properties of our SerialPort Object
                comPort.BaudRate = int.Parse(_baudRate);    //BaudRate
                comPort.PortName = _portName;   //PortName
                //now open the port
                comPort.Open();
                //return true
                return true;
            }
            catch (Exception ex)
            {
                DisplayData("Failed to open port " + comPort.PortName + ". Error:\t" +
                    ex.ToString());
                return false;
            }
        }

        public bool isOpen()
        {
            return comPort.IsOpen;
        }
        /// <summary>
        /// Closes an open Comm port.
        /// </summary>
        /// <returns>Returns true if the comm port is successfully closed w/o any errors</returns>
        public bool ClosePort()
        {
            bool result = false;

            try
            {
                comPort.Close();
                result = !comPort.IsOpen;
            }
            catch (Exception ex)
            {
                DisplayData("Failed to close port " + comPort.PortName + ". Error:\t" +
                    ex.ToString());
                return false;
            }
            return result;
        }
        #endregion

        public void SendBytes(byte[] bytes)
        {
            if (!(comPort.IsOpen == true)) OpenPort();
            if (comPort.IsOpen && (bytes.Length > 0))
            {
                bool threadLocked = commLock.WaitOne(100);
                if (threadLocked)
                {
                    comPort.Write(bytes, 0, bytes.Length);
                    commLock.Release();
                }
                else
                    throw new Exception("Failed to lock SendBytes");

                //DisplayData("Sent: " + CMTools.BytesToHex(bytes) + "\n");
            }
            else
            {
                DisplayData("Error: Failed to send bytes - [" +
                    CMTools.BytesToHex(bytes) + "]\n");
            }
            //comPort.Close();
        }

        /// <summary>
        /// method that will be called when there is data waiting in the buffer.
        /// 
        /// THIS WILL BE CALLED ASYNCHRONOSLY.  WATCH FOR RACES.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void comPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            int bytes = comPort.BytesToRead;
            byte[] comBuffer = new byte[bytes];
            comPort.Read(comBuffer, 0, bytes);

            DisplayData("Received: " + CMTools.BytesToHex(comBuffer) + "\n");
            //handleData(comBuffer);
            //DisplayDataQueue();
        }
        #region DisplayData
        public RichTextBox _rtbOutputComm = null;

        /// <summary>
        /// method to display the data to & from the port
        /// on the screen
        /// </summary>
        /// <param name="type">MessageType of the message</param>
        /// <param name="msg">Message to display</param>
        [STAThread]
        private void DisplayData(string msg)
        {
            if (_rtbOutputComm != null)
            {
                _rtbOutputComm.Invoke(new EventHandler(delegate
                {
                    _rtbOutputComm.SelectedText = string.Empty;
                    _rtbOutputComm.SelectionFont = new Font(_rtbOutputComm.SelectionFont, FontStyle.Bold);
                    _rtbOutputComm.AppendText(msg);
                    _rtbOutputComm.ScrollToCaret();
                }));
            }
            else
            {
                // TODO: Implement alternate method for "DisplayData"
            }
        }


        #endregion

    }
}
