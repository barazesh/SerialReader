using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;


namespace SerialReader
{
    class Program
    {
        static SerialPort serialPort = new SerialPort
        {
            BaudRate = 115200,
            StopBits = StopBits.None,
            Parity=Parity.Even,
            DataBits=8
        };
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome");
            Console.WriteLine("Available Ports:");
            string[] portnames = SerialPort.GetPortNames();
            foreach (var p in portnames)
            {
                Console.WriteLine(p);
            }
            Console.WriteLine("Enter the number of the desired port");
            string num = Console.ReadLine();
            serialPort.PortName = "COM" + num;
            serialPort.DataReceived += SerialPort_DataReceived;
            serialPort.Open();

        }

        private static void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            sp.
        }
    }
}
