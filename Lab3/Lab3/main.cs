﻿using System;
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
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void Bai1_Click(object sender, EventArgs e)
        {
            Dashboard d = new Dashboard();
            d.Show();   
        }

        private void Bai2_Click(object sender, EventArgs e)
        {
            Bai2 b = new Bai2();    
            b.Show();   
        }

        private void Bai3_Click(object sender, EventArgs e)
        {
            Bai3 b = new Bai3();    
            b.Show();   
        }

        private void Bai4_Click(object sender, EventArgs e)
        {
            Bai4 b = new Bai4();    
            b.Show();   
        }

        private void Bai5_Click(object sender, EventArgs e)
        {
            Bai5 b = new Bai5();    
            b.Show();   
        }

        private void Bai6_Click(object sender, EventArgs e)
        {
            Bai6 b = new Bai6();    
            b.Show();
        }
    }
}
