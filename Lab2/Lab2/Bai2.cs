using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();
        }

        private void Bai2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog(); 
            if(ofd.ShowDialog() == DialogResult.OK)
            {  
                //print name of file
                NameFile.Text = ofd.SafeFileName;
                LinkFile.Text = ofd.FileName;// print link of file
            }
            // print size of url
            FileInfo fLink = new FileInfo(ofd.FileName);
            long size = fLink.Length;
            SizeFile.Text = size.ToString() + " bytes";
            //read file
            try
            {
                using(StreamReader sr = new StreamReader(ofd.SafeFileName))
                {
                    string content = sr.ReadToEnd();
                    richTextBox1.Text = content;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error read file" +  ex.Message);   
            }
            // count the number of lines
            int countLine = 0;
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                string[] lines = File.ReadAllLines(ofd.FileName);
                {
                    countLine = lines.Length;
                }
            }
            LineFile.Text = countLine.ToString();
            // count the number of words
            int countWord = 0;
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                string text = File.ReadAllText(ofd.FileName);
                string[] words = text.Split(new char[] { ' ', '\t', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
                countWord = words.Length;   
            }
            WordFile.Text = countWord.ToString();
            // count the character of file
            int countcharacter = 0;
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                string character = File.ReadAllText(ofd.FileName);
                countcharacter = character.Length; 
            }
            CountChar.Text = countcharacter.ToString(); 
        }

        private void LinkFile_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
