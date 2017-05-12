using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;              // for SerialPort class

namespace ReadDemo
{
    public partial class Form1 : Form
    {
        private SerialPort _serialPort;
        public delegate void AddDataDelegate();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Gets an array of serial port names for the current computer
            string[] serialPorts = SerialPort.GetPortNames();

            // Fill in Combobox with serial port names
            cbSerialPorts.DataSource = serialPorts;
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            _serialPort = new SerialPort(cbSerialPorts.SelectedItem.ToString(), 
                                            9600, Parity.Even, 7, StopBits.One);
            _serialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);

            try
            {
                // Open Serial Port
                _serialPort.Open();
                btnOpen.Enabled = false;
                btnClose.Enabled = true;

                textBox1.Clear();  // clear the content of textbox
            }
            catch (Exception ex)
            {
                MessageBox.Show("Open() error: " + ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            // Close Serial Port
            _serialPort.Close();
            btnClose.Enabled = false;
            btnOpen.Enabled = true;
        }

        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            this.Invoke(new AddDataDelegate(AddData));
        }

        private void AddData()
        {
            string dataLine = _serialPort.ReadLine();
            textBox1.AppendText(dataLine);
            textBox1.AppendText("\r\n");   // new line characeter
        }

    }
}
