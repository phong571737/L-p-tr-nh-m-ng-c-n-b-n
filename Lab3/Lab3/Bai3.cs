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
    public partial class Bai3 : Form
    {
        public Bai3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TCPClient tCP = new TCPClient();
            tCP.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TCPServer tCP = new TCPServer();
            tCP.Show();
        }
    }
}
