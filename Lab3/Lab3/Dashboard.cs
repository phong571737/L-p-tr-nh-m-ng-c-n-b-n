using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void UDPclient_Click(object sender, EventArgs e)
        {
            UDPClient uDPClient = new UDPClient();
            uDPClient.Show();
        }

        private void UDPserver_Click(object sender, EventArgs e)
        {
            UDPServer uDServer = new UDPServer();   
            uDServer.Show();    
        }
    }
}
