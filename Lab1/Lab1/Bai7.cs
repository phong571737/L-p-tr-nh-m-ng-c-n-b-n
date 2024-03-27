using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Bai7 : Form
    {
        public Bai7()
        {
            InitializeComponent();
        }

        private void Input_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void FindAns_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Input.Text))
            {
                string inp = Input.Text.Trim();
                string[] student = inp.Split(',');
                if (student.Length < 2)
                {
                    MessageBox.Show("Vui lòng nhập ít nhất một cột điểm ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string name = student[0].Trim();
                FullName.Text = name;
                string allPoint = "";
                for (int i = 1; i < student.Length; i++)
                {
                    string res = "Môn " + i.ToString() + ":" + student[i] + "  ";
                    Console.WriteLine(res);
                    allPoint += res + '\n';
                } 
                point.Text = allPoint;
                List<double> points = new List<double>();
                for(int i = 1;i < student.Length;i++)
                {
                    if (double.TryParse(student[i], out double n))
                    {
                        if (n >= 0 && n <= 10)
                        {
                            points.Add(n);
                        }
                        else
                        {
                            DialogResult err = MessageBox.Show("Điểm nhập vào không hợp lệ! Vui lòng nhập lại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            if (err == DialogResult.OK)
                            {
                                //delete unsatisfactory elements
                                points.RemoveAll(x => x < 0 || x > 10);
                            }
                        }
                    }                   
                }
                double dtb = 0;
            foreach (double t in points)
                {
                    dtb += t;
                }
            dtb /= points.Count;
            Avg.Text = dtb.ToString();
                double max = double.MinValue;
                double min = double.MaxValue;   
            foreach(double t in points)
                {
                    if(max <= t)
                    {
                        max = t;
                    }
                    if(min >= t)
                    {
                        min = t;
                    }
                }
            string minMaxstr = max.ToString() + " và " + min.ToString();
            Console.WriteLine(minMaxstr);
            MinMaxNum.Text = minMaxstr;
                int dat = 0;
                int khongdat = 0;
                foreach(double i in points)
                {
                    if(i < 5)
                    {
                        khongdat++;
                    }
                    else
                    {
                        dat++;
                    }
                }
            string kq = dat.ToString() + " và " + khongdat.ToString();
            Console.WriteLine(kq);  
            Res.Text = kq;

                // ranked academic
            double[] diem = new double[points.Count]; // Initialize diem array with the count of valid points
            for (int i = 0; i < points.Count; i++)
                {
                    diem[i] = points[i]; // Populate diem array with the actual points
                }
            string Grade;
            if(dtb >= 8 && !Array.TrueForAll(diem, d => d < 6.5))
                {
                    Grade = "Giỏi";
                }
            else if(dtb >= 6.5 && !Array.TrueForAll(diem, d => d < 5))
                {
                    Grade = "Khá";
                }    
            else if(dtb >= 5 && !Array.TrueForAll(diem, d => d < 3.5))
                {
                    Grade = "TB";
                }
            else if(dtb >= 3.5 && !Array.TrueForAll(diem, d => d < 2))
                {
                    Grade = "Yếu";
                }
            else
                {
                    Grade = "Kém";
                }
                Rank.Text = Grade;     
            }
            else
            {
                MessageBox.Show("Vui long nhap thong tin sinh vien!", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void point_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
