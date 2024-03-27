using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Bai1 : Form
    {
        public Bai1()
        {
            InitializeComponent();
        }

        private void Num1_TextChanged(object sender, EventArgs e)
        {
            bool check = int.TryParse(Num1.Text, out int n);
            if (!check) 
            {
                DialogResult kq = MessageBox.Show("Vui lòng nhập số nguyên! ");// check input if it is not an integer 
                if(kq == DialogResult.OK) //clear number is not integer after press OK
                {
                    Num1.Clear();   
                }    
            }
            else
            {
                return; 
            }    
        }

        private void Num2_TextChanged(object sender, EventArgs e)
        {
            bool check = int.TryParse(Num2.Text, out int n);
            if (!check) 
            {
               DialogResult kq =  MessageBox.Show("Vui lòng nhập số nguyên! ");
                if(kq == DialogResult.OK)   
                    Num2.Clear();   
            }
            else 
            { 
                return; 
            }    
        }

        private void CalcuNum_Click(object sender, EventArgs e)
        {
            int a = int.Parse(Num1.Text);   
            int b = int.Parse(Num2.Text);
            int kq = a + b;
            Result.Text = kq.ToString();
        }
    }
}
