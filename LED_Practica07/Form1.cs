using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LED_Practica07
{
    public partial class Form1 : Form
    {
        public SerialPort ArduinoPort { get; }

        public Form1()
        {
            InitializeComponent();

            ArduinoPort = new System.IO.Ports.SerialPort();
            ArduinoPort.PortName = "COM3";
            ArduinoPort.BaudRate = 9600;
            ArduinoPort.Open();

            this.FormClosing += CerrandoForm1;
            this.btnApagar.Click += btnApagar_Click;
            this.bntEncender.Click += bntEncender_Click;
        }

        private void bntEncender_Click(object sender, EventArgs e)
        {
            ArduinoPort.Write("a");
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            ArduinoPort.Write("b");
        }
        
        private void CerrandoForm1(object sender, FormClosingEventArgs e)
        {
            if (ArduinoPort.IsOpen) ArduinoPort.Close();
        }
    }
}