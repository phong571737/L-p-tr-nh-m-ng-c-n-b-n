using SimpleTCP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Lab3
{
    public partial class TCPClient : Form
    {
        public TCPClient()
        {
            InitializeComponent();
        }
        SimpleTcpServer server;
        SimpleTcpClient client;

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        
        private void TCPClient_Load(object sender, EventArgs e)
        {
            client = new SimpleTcpClient();
            client.StringEncoder = Encoding.UTF8;
            client.DataReceived += Client_DataReceived;
        }

        private void Client_DataReceived(object sender, SimpleTCP.Message e)
        {
            richTextBox1.Invoke((MethodInvoker)delegate ()
            {
                richTextBox1.Text += e.MessageString;
                
            });
        }

        private void btdisconnect_Click(object sender, EventArgs e)
        {
            if(server.IsStarted)
            {
                server.Stop();
            }
        }

        private void btsend_Click(object sender, EventArgs e)
        {
            client.WriteLineAndGetReply(richTextBox1.Text, TimeSpan.FromSeconds(3));
        }
    }
}
