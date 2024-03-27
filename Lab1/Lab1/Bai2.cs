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
    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();
        }

        private void Number1_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Number1.Text))
            {
                bool n = double.TryParse(Number1.Text, out double d);
                if (!n)
                {
                    DialogResult k = MessageBox.Show("Không hợp lệ! Vui lòng nhập số thứ nhất ", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
                    if (k == DialogResult.OK)
                    {
                        Number1.Clear();
                    }
                }
            }
            
        }
        private void Number2_TextChanged(object sender, EventArgs e)
        {
         
            if (!string.IsNullOrEmpty(Number2.Text))
            {
                if (!double.TryParse(Number2.Text, out double d))
                {
                    MessageBox.Show("Không hợp lệ! Vui lòng nhập lại số thứ hai", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Number2.Clear();
                }
            }
        }

        private void Number3_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Number3.Text))// ensure that the parsing and validation logi only execute
            { 
                bool n = double.TryParse(Number3.Text, out double d);
                if (!n)
                {
                    DialogResult k = MessageBox.Show("Không hợp lệ! Vui lòng nhập lại số thứ ba", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (k == DialogResult.OK)
                    {
                        Number3.Clear();
                    }
                }
            }
        }

        private void FindNum_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Number1.Text) && !string.IsNullOrEmpty(Number2.Text) && !string.IsNullOrEmpty(Number3.Text))
            {
                double a = double.Parse(Number1.Text);
                double b = double.Parse(Number2.Text);
                double c = double.Parse(Number3.Text);
                double Max;
                double Min;
                //Find min
                if (a <= b && a <= c)
                {
                    Min = a;
                }
                else if (b <= c && b <= a)
                {
                    Min = b;
                }
                else
                {
                    Min = c;
                }

                //Find max
                if (a >= b && a >= c)
                {
                    Max = a;
                }
                else if (b >= c && b >= a)
                {
                    Max = b;
                }
                else
                {
                    Max = c;
                }
                MaxNum.Text = Max.ToString();
                MinNum.Text = Min.ToString();
            }
        }

        private void DelNum_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Number1.Text) && !string.IsNullOrEmpty(Number2.Text) && !string.IsNullOrEmpty(Number3.Text))
            {
                Number1.Clear();
                Number2.Clear();
                Number3.Clear();
                MaxNum.Clear();
                MinNum.Clear();
            }
        }

        private void MinNum_TextChanged(object sender, EventArgs e)
        {

        }

        private void ClsPro_Click(object sender, EventArgs e)
        {
                this.Close();       
        }
    }
}
