using System;
using System.Collections.Generic;
using System.Text;
using System.IO.Ports;              // for SerialPort class

namespace ListPorts_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            // Gets an array of serial port names for the current computer
            string[] serialPorts = SerialPort.GetPortNames();
            
            // Print the serial port names in console
            foreach (string serialPort in serialPorts)
                Console.WriteLine(serialPort);                       
        }
    }
}
