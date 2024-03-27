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
    public partial class Bai3 : Form
    {
        public Bai3()
        {
            InitializeComponent();
        }

        private void InpNum_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(InpNum.Text))
            {
                if (int.TryParse(InpNum.Text, out int n))
                {
                    if (n < 0 || n > 9)
                    {
                        MessageBox.Show("Nhập số không hợp lệ!", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
                        InpNum.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Nhập số không hợp lệ!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    InpNum.Clear();
                }
            }
        }

        private void FindNum_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(InpNum.Text)) { 
           int n = int.Parse(InpNum.Text);
                switch (n)
                {
                    case 0:
                        ResultStr.Text = "Không";
                        break;
                    case 1:
                        ResultStr.Text = "Một";
                        break;
                    case 2:
                        ResultStr.Text = "Hai";
                        break;
                    case 3:
                        ResultStr.Text = "Ba";
                        break;
                    case 4:
                        ResultStr.Text = "Bốn";
                        break;
                    case 5:
                        ResultStr.Text = "Năm";
                        break;
                    case 6:
                        ResultStr.Text = "Sáu";
                        break;
                    case 7:
                        ResultStr.Text = "Bảy";
                        break;
                    case 8:
                        ResultStr.Text = "Tám";
                        break;
                    case 9:
                        ResultStr.Text = "Chín";
                        break;
                }
            }
        }

        private void DelNum_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(InpNum.Text))
            { 
                int n = int.Parse(InpNum.Text);
                InpNum.Clear ();
                ResultStr.Clear(); 
            }
        }

        private void ClsProgram_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
