using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class ChonBai3 : Form
    {
        public ChonBai3()
        {
            InitializeComponent();
        }

        private void BasicLession_Click(object sender, EventArgs e)
        {
            Bai3 b = new Bai3();
            b.Show();
        }

        private void Advanced_Click(object sender, EventArgs e)
        {
            Bai3plus b = new Bai3plus();
            b.Show();   
        }
    }
}
