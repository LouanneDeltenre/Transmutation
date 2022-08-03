using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;

namespace ClavierCode
{


    public partial class ClavierCode : Form
    {
        int baurrate = 9600;
        public ClavierCode()
        {

            InitializeComponent();
            getPorts();
            serialPort1.DataReceived += new SerialDataReceivedEventHandler(dataRecived);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort1.IsOpen == false) {
                    if (ComList.Text == "COM")
                    {
                        status.Text = "Veuillez sélectionner un port.";
                    }
                    else
                    {
                        try
                        {
                        serialPort1.PortName = ComList.Text;
                        serialPort1.BaudRate = baurrate;
                        serialPort1.Open();
                        Connecter.Text = "Déconnecter";
                        status.Text = "Connecté";
                        }catch(System.IO.IOException)
                        {
                            status.Text = "Erreur de connection au clavier.";
                        }

                    }
                }
                else if(serialPort1.IsOpen == true)
                {
                    serialPort1.Close();
                    Connecter.Text = "Connecter";
                    status.Text = "Déconnecté";
                }
            }
            catch (UnauthorizedAccessException)
            {
                status.Text = "Erreur de connection au clavier.";
            }
        }


        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            baurrate = 9600;
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            baurrate = 115200;
        }




        void getPorts()
        {
            String[] ports = SerialPort.GetPortNames();
            if(ports.Length == 0)
            {
                ComList.Text = "COM";
            }
            else
            {
            ComList.Items.Clear();
            ComList.Items.AddRange(ports);
            ComList.Text = ports[0];
            }


        }


        void dataRecived(object sender, SerialDataReceivedEventArgs e)
        {
            
            string data = serialPort1.ReadLine().Substring(0, 1);

            if (data == "1001101")
            {
                Console.WriteLine("1001101");
                SendKeys.SendWait("{1001101}");
            }
            if (data == "1000101")
            {
                Console.WriteLine("1000101");
                SendKeys.SendWait("{1000101}");
            }
            if (data == "1001111")
            {
                Console.WriteLine("1001111");
                SendKeys.SendWait("{1001111}");
            }
            if (data == "1001001")
            {
                Console.WriteLine("1001001");
                SendKeys.SendWait("{1001001}");
            }
            if (data == "1010010")
            {
                Console.WriteLine("1010010");
                SendKeys.SendWait("{1010010}");
            }
            if (data == "1000001")
            {
                Console.WriteLine("1000001");
                SendKeys.SendWait("{1000001}");
            }
            if (data == "1000100")
            {
                Console.WriteLine("1000100");
                SendKeys.SendWait("{1000100}");
            }
            if (data == "1010101")
            {
                Console.WriteLine("1010101");
                SendKeys.SendWait("{1010101}");
            }
            if (data == "1010000")
            {
                Console.WriteLine("1010000");
                SendKeys.SendWait("{1010000}");
            }
            if (data == "k")
            {
                Console.WriteLine("k");
                SendKeys.SendWait("{ENTER}");
            }
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            getPorts();
        }
    }



}
