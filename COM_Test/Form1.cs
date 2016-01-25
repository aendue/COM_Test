using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO.Ports;
using System.IO;
using System.Text.RegularExpressions;

namespace COM_Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            GetComPort();
            //cb_port.SelectedIndex = 0;
        }

        private void readfile()
        {
            StreamReader stream = new StreamReader("C:\\Users\\Andy\\Desktop\\usage.txt");
            string line;
            while ((line = stream.ReadLine()) != null)
            {
                //int search = line.IndexOf("use");
                string resultString = Regex.Match(line.Substring(line.IndexOf("use")), @"\d+").Value;
                MessageBox.Show(resultString);
            }
            
        }

        private void GetComPort()
        {
                string[] ports = SerialPort.GetPortNames();

            foreach(string value in ports)
            {
                cb_port.Items.Add(value);
            }
            
        }

        private void port(String number)
        {
            SerialPort arduinoBoard = new SerialPort(cb_port.Text, 9600);

            if (!arduinoBoard.IsOpen)
            {
                try
                {
                    arduinoBoard.Open();
                    arduinoBoard.Write(number);
                    arduinoBoard.Close();
                }
                catch (Exception e)
                {
                    MessageBox.Show("Keine Verbindung" + "\n" + e.Message, "Verbindungsfehler");
                }
            }
            else
            {
                throw new InvalidOperationException("Der Serial Port ist schon offen!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            port(text.Text);
        }

        private void bt_test_Click(object sender, EventArgs e)
        {
            readfile();
        }
    }
}
