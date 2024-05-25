using SimpleTCP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class TCPServer : Form
    {
        public TCPServer()
        {
            InitializeComponent();
        }

        SimpleTcpServer server;
        private void btlisten_Click(object sender, EventArgs e)
        {
            rtbReceived.Text += "Server start";
            System.Net.IPAddress ip = new System.Net.IPAddress(long.Parse(tbhost.Text));
            server.Start(ip, Convert.ToInt32(tbport.Text)); 
        }
        private void Server_DataReceived(object sender, SimpleTCP.Message e)
        {
            rtbReceived.Invoke((MethodInvoker)delegate ()
            {
                rtbReceived.Text += e.MessageString;
                e.Reply(string.Format("You said: {0}", e.MessageString));
            });
        }

        private void TCPServer_Load(object sender, EventArgs e)
        {
            server = new SimpleTcpServer();
            server.Delimiter = 0x13; //enter
            server.StringEncoder = Encoding.UTF8;
            server.DataReceived += Server_DataReceived;
        }
    }
}
