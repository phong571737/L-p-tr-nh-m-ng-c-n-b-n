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
    public partial class Bai3plus : Form
    {
        public Bai3plus()
        {
            InitializeComponent();
        }
        static string[] numName = { "không", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };
        static string[] unitName = {"", " nghìn", " triệu", " tỷ" };
        //function using read the values of hundreds
        static string ReadHundred(int number)
        {
            string hundred = "";
            if(number >= 100)
            {
                hundred += numName[number / 100] + " trăm "; // hundreds
                number %= 100;
            }
            switch(number)
            {
                case 0: 
                    break;
                case 1:
                    hundred += " lẻ một";
                    break;
                case 2:
                    hundred += " lẻ hai";
                    break;
                case 3:
                    hundred += " lẻ ba";
                    break;
                case 4:
                    hundred += " lẻ bốn";
                    break;
                case 5:
                    hundred += " lẻ năm";
                    break;
                case 6:
                    hundred += " lẻ sáu";
                    break;
                case 7:
                    hundred += " lẻ bảy";
                    break;
                case 8:
                    hundred += " lẻ tám";
                    break;
                case 9:
                    hundred += " lẻ chín";
                    break;
                case 10:
                    hundred += " mười";
                    break;
                case 11:
                    hundred += " mười một";
                    break;
                case 12:
                    hundred += " mười hai";
                    break;
                case 13:
                    hundred += " mười ba ";
                    break;
                case 14:
                    hundred += " mười bốn";
                    break;
                case 15:
                    hundred += " mười lăm ";
                    break;
                case 16:
                    hundred += " mười sáu";
                    break;
                case 17:
                    hundred += " mười bảy";
                    break;
                case 18:
                    hundred += " mười tám";
                    break;
                case 19:
                    hundred += " mười chín";
                    break;
                default:
                    if(number >= 10) 
                    {
                        hundred += numName[number / 10] + " mươi ";// dozens
                        number %= 10;
                    }
                    if(number == 1)
                    {
                        hundred += " mốt ";
                    }
                    else
                    {
                        hundred += numName[number];                      
                    }    
                    break;
            }
            return hundred;
        }

        private void ReadNum_Click(object sender, EventArgs e)
        {
            if (long.TryParse(InputNum.Text, out var number))
            {
                long n = long.Parse(InputNum.Text);
                if (n == 0)
                {
                    OutNum.Text = "Không";
                }
                else
                {
                    string word = "";
                    for (int i = 0; n > 0; i++)
                    {
                        if (n % 1000 != 0)
                        {
                            if (n > 1000)
                                word = ", " + ReadHundred((int)(n % 1000)) + unitName[i] + word;//read from hundreds from millions, billions
                            else
                                word = ReadHundred((int)(n % 1000)) + unitName[i] + word;
                        }
                        n /= 1000;
                    }
                    OutNum.Text = word;
                }
            }
            else
            {
                MessageBox.Show("Giá trị nhập vào không hợp lệ!", "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                InputNum.Clear();
            }    
        }

        private void DelNum_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(InputNum.Text))
            {
                InputNum.Clear();
                OutNum.Clear();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số vào!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ExitPro_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
