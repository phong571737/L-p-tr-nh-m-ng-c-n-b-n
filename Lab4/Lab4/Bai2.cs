using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();
        }

        private void DownloadFile(string url, string FilePath)
        {
            try
            {
                WebClient client = new WebClient();
                //Stream response = client.OpenRead(url);
                client.DownloadFile(url, FilePath);// download file from url link into FilePath
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisplayContent(string filePath)
        {
            try
            {
                string fileContent = File.ReadAllText(filePath);
                rtbContent.Text = fileContent;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btDownload_Click(object sender, EventArgs e)
        {
            string url = tbURL.Text;
            string filePath = tbPhysical.Text;

            if (!string.IsNullOrEmpty(url) && !string.IsNullOrEmpty(filePath))
            {
                DownloadFile(url, filePath);
                DisplayContent(filePath);
            }
            else
            {
                MessageBox.Show("Vui lòng nhập url và đường dẫn lưu file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
        }
    }
}
