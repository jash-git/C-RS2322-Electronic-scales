using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;              // for SerialPort class

namespace WriteDemo
{
    public partial class Form1 : Form
    {
        private SerialPort _serialPort = null;

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

        private void btnLED_Click(object sender, EventArgs e)
        {
            if (btnLED.BackColor == Color.WhiteSmoke)
            {
                _serialPort.Write("1");         // Turn on Arduino's LED
                btnLED.BackColor = Color.LawnGreen;                
            }
            else
            {
                _serialPort.Write("0");         // Turn off Arduino's LED
                btnLED.BackColor = Color.WhiteSmoke;
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (_serialPort != null && _serialPort.IsOpen)            
                _serialPort.Close();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (btnOpen.Text == "Open")
            {
                // Set up serial port
                _serialPort = new SerialPort(cbSerialPorts.SelectedItem.ToString(),
                                                9600, Parity.None, 8, StopBits.One);

                try
                {
                    // Open serial port
                    _serialPort.Open();
                    btnOpen.Text = "Close";
                    btnLED.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Open() error: " + ex.Message);
                }
            }
            else
            {
                _serialPort.Close();
                btnOpen.Text = "Open";
                btnLED.Enabled = false;
            }
        }
    }
}
