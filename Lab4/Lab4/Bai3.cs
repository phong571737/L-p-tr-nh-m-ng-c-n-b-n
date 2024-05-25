using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.WinForms;
using HtmlAgilityPack;
using System.IO;
using System.Net;

namespace Lab4
{
    public partial class Bai3 : Form
    {
        public Bai3()
        {
            InitializeComponent();
            InitializeWebView();
        }

        private void txtURL_TextChanged(object sender, EventArgs e)
        {

        }

        private async void InitializeWebView()
        {
            await wbContent.EnsureCoreWebView2Async(null);
        }

        private void btLoad_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtURL.Text))
            {
                wbContent.CoreWebView2.Navigate(txtURL.Text); // điều hướng tới url
            }
            else
            {
                MessageBox.Show("Please enter a valid URL.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btReload_Click(object sender, EventArgs e)
        {
            wbContent.CoreWebView2.Reload();
        }

        private void btDFile_Click(object sender, EventArgs e)
        {
            
        }

        private async void btDResources_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtURL.Text))
            {
                try
                {
                    using (WebClient client = new WebClient())
                    {                    
                        string htmlContent = await client.DownloadStringTaskAsync(txtURL.Text);// Tải nội dung của trang web                       
                        HtmlAgilityPack.HtmlDocument htmlDocument = new HtmlAgilityPack.HtmlDocument();
                        htmlDocument.LoadHtml(htmlContent);// Sử dụng HTMLAgilityPack để phân tích nội dung HTML
                        HtmlNodeCollection imgNodes = htmlDocument.DocumentNode.SelectNodes("//img"); // thẻ img
                        if (imgNodes != null && imgNodes.Count > 0) // kiểm tra có hình không
                        {                           
                            foreach (HtmlNode imgNode in imgNodes)
                            {
                                string imgUrl = imgNode.GetAttributeValue("src", "");

                                // Kiểm tra xem đường dẫn của hình ảnh có đúng định dạng không
                                if (!string.IsNullOrEmpty(imgUrl) && Uri.TryCreate(imgUrl, UriKind.Absolute, out Uri uriResult))
                                {
                                    // Tạo tên file từ đường dẫn hình ảnh
                                    string fileName = Path.GetFileName(uriResult.LocalPath);
                                    client.DownloadFile(imgUrl, Path.Combine(@"E:\BASIC NETWORK PROGRAMING\PRACTICE\LAB1\Lab4\Image", fileName)); // tải ảnh vào đường dẫn
                                }
                            }
                            MessageBox.Show("Tải hình ảnh thành công", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy ảnh.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đường dẫn.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
