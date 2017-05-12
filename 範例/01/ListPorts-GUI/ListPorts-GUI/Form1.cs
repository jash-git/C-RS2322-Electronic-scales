using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;              // for SerialPort class

namespace ListPorts_GUI
{
    public partial class Form1 : Form
    {
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

            /* You can fill in combobox in this way:            
            foreach (string serialPort in serialPorts)
                cbSerialPorts.Items.Add(serialPort);

            if (cbSerialPorts.Items.Count > 0) 
                cbSerialPorts.SelectedIndex = 0;        // Select the first available serial port
            */
        }
    }
}
