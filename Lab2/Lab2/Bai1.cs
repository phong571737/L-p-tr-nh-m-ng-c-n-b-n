using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Bai1 : Form
    {
        public Bai1()
        {
            InitializeComponent();
        }

        private void RFile_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamReader sr = new StreamReader("input.txt"))
                   { 
                    string content = sr.ReadToEnd();
                    richTextBox1.Text = content; 
                    }
            }
            catch(Exception ex)  {
                MessageBox.Show("Error read" + ex.Message, "Error");
            }
        }

        private void WFile_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter("output.txt"))
                {
                    string content = richTextBox1.Text.ToUpper();
                    sw.WriteLine(content);
                }    
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error writing" + ex.Message, "Error");
            }
            
        }
    }
}
