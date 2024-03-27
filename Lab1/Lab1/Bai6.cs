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
    public partial class Bai6 : Form
    {
        public Bai6()
        {
            InitializeComponent();
        }

        private void DayBorn_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(DayBorn.Text))
            {             
                if (int.TryParse(DayBorn.Text, out int n))
                {
                    if (n < 1 || n > 31)
                    {
                        MessageBox.Show("Ngày không hợp lệ! Vui lòng nhập lại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        DayBorn.Clear();    
                    }
                }
                else
                {
                    MessageBox.Show("Ngày không hợp lệ! Vui lòng nhập lại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DayBorn.Clear();
                }
            }
        }

        private void MonthBorn_TextChanged(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(MonthBorn.Text))
            {
                if(int.TryParse(MonthBorn.Text,out int n))
                {
                    if(n < 1 || n > 12)
                    {
                        MessageBox.Show("Tháng không hợp lệ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        MonthBorn.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Tháng không hợp lệ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MonthBorn.Clear();
                }
            }
        }

        private void YearBorn_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(YearBorn.Text))
            {
                if (int.TryParse(YearBorn.Text, out int n))
                {
                    if (n < 1 )
                    {
                        MessageBox.Show("Năm không hợp lệ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        MonthBorn.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Năm không hợp lệ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MonthBorn.Clear();
                }
            }
        }

        private void CheckInf_Click(object sender, EventArgs e)
        {
            int d = int.Parse(DayBorn.Text);
            int m = int.Parse(MonthBorn.Text);
            int y = int.Parse(YearBorn.Text);
            switch(m)
            {
                case 1:
                    Zodiac.Text = (d < 21) ?  "Cung Ma Kết"  : "Cung Bảo Bình";
                    break;
                case 2:
                    Zodiac.Text = d < 20 ? "Cung Bảo Bình" : "Cung Song Ngư";                   
                    break;
                case 3:
                    Zodiac.Text = d < 21 ? "Cung song ngữ" : "Cung Bạch Dương";
                    break;
                case 4:
                    Zodiac.Text = d < 21 ? "Cung Bạch Dương" : "Cung Kim Ngưu";
                    break;
                case 5:
                    Zodiac.Text = d < 22 ? "Cung Kim Ngưu" : "Cung Song Tử";
                    break;
                case 6:
                    Zodiac.Text = d < 22 ? "Cung Song Tử" : "Cung Cự Giải";
                    break;
                case 7:
                    Zodiac.Text = d < 23 ? "Cung Cự Giải" : "Cung Sư Tử";
                    break;
                case 8:
                    Zodiac.Text = d < 23 ? "Cung Sư Tử" : "Cung Xử Nữ";
                    break;
                case 9:
                    Zodiac.Text = d < 24 ? "Cung Xử Nữ" : "Cung Thiên Bình";
                    break;
                case 10:
                    Zodiac.Text = d < 24 ? "Cung Thiên Bình " : "Cung Thần Nông";
                    break;
                case 11:
                    Zodiac.Text = d < 23 ? "Cung Thần Nông" : "Cung Nhân Mã";
                    break;
                default:
                    Zodiac.Text = d < 22 ? "Cung Nhân Mã" : "Cung Ma Kết";
                    break;

            }
        }
    }
}
