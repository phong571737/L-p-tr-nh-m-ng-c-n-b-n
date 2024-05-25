using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class UDPClient : Form
    {
        public UDPClient()
        {
            InitializeComponent();
        }

        private void ipaddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void Send_Click(object sender, EventArgs e)
        {
            UdpClient udpClient = new UdpClient(); // create udp connection
            IPAddress ipadd = IPAddress.Parse(ipaddress.Text);
            udpClient.Connect(ipadd, 8080); //int.Parse(port.Text));

            string messageToSend = message.Text;

            Byte[] sendbyte = Encoding.ASCII.GetBytes(messageToSend); // convert string to byte

            // send data without need to establish a connection to the server
            udpClient.Send(sendbyte, sendbyte.Length); 
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
