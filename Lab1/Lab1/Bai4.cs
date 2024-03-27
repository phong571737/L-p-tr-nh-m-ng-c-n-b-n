using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Bai4 : Form
    {
        public Bai4()
        {
            InitializeComponent();
        }
        
        static Dictionary<string,List <string>> seat = new Dictionary<string,List <string>>()
        {
            {"Vé vớt", new List<string>(){"A1", "A5", "C1", "C5"}},
            {"Vé thường", new List<string>(){"A2", "A3", "A4", "C2", "C3","C4" } },
            {"Vé vip", new List<string>(){ "B2", "B3","B4"} }
        };
        static Dictionary<string, int> Fare = new Dictionary<string, int>()
        {
            { "Đào, phở, piano", 45000 },
            {"Mai", 100000},
            {"Gặp lại chị bầu", 70000},
            { "Tarot", 90000}
            };

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void OutName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Pay_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(InputName.Text))
            {
                OutName.Text = InputName.Text;  
                if(comboBox2.Text == "Vé thường")
                {
                    OutType.Text = "Vé thường ";
                }    
                else if(comboBox2.Text == "Vé vớt")
                {
                    OutType.Text = "Vé vớt";
               
                }
                else
                {
                    OutType.Text = "Vé vip";
                }
                // print the ticket price of customer
                double TicketPrice = 0;
                if (Fare.TryGetValue(comboBox1.Text, out int value))
                {
                    switch (comboBox2.Text)
                    {
                        case "Vé thường":
                            TicketPrice = value;
                            break;
                        case "Vé vớt":
                            TicketPrice = (double)(value / 4);
                            break;
                        default:
                            TicketPrice = 2 * value;
                            break;
                    }
                }
                SumMoney.Text = TicketPrice.ToString();
                // room
                Random rnd = new Random();
                int num;
                if(comboBox1.Text == "Đào, phở, piano")
                {
                    num = rnd.Next(1, 4);
                }    
                else if(comboBox1.Text == "Mai")
                {
                    num = rnd.Next(2, 4);
                }    
                else if(comboBox1.Text == "Gặp lại chị bầu")
                {
                    num = 1;
                }    
                else
                {
                    num = 3;
                }
                OutRoom.Text = num.ToString();
                // choose your seat
                string selected = comboBox2.SelectedItem.ToString();
                foreach(var s in seat[selected] )
                {
                    checkedListBox1.Items.Add(s);
                }   
                //print movie's name
                NameMovie.Text = comboBox1.Text;
            }

            else
            {
                MessageBox.Show("Vui lòng nhập họ tên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }
    }
}
