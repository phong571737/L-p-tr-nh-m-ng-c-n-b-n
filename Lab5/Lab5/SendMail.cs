using MimeKit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using MailKitSmtpClient = MailKit.Net.Smtp.SmtpClient;

namespace Lab5
{
    public partial class SendMail : System.Windows.Forms.Form
    {
        private OpenFileDialog openFileDialog;
        public SendMail()
        {
            InitializeComponent();

            openFileDialog = new OpenFileDialog
            {
                Multiselect = false,
                Title = "Select file to attach"
            };
        }

        private void btSend_Click(object sender, EventArgs e)
        {
            try
            {
                string from = tbFrom.Text;
                string to = tbTo.Text;  
                string subject = tbSubject.Text;
                string body = rtbContent.Text;
                string attchmetPath = tbAttach.Text;

                var message = new MimeMessage();
                message.From.Add(new MailboxAddress("", from));
                message.To.Add(new MailboxAddress("", to));
                message.Subject = subject;

                // thiết lập nội dung email
                var builder = new BodyBuilder
                {
                    TextBody = body
                };

                if (!string.IsNullOrEmpty(attchmetPath))
                {
                    builder.Attachments.Add(attchmetPath);
                }

                message.Body = builder.ToMessageBody();
                // thiết lập smtpclient và gửi mail
                using (var client = new MailKitSmtpClient())
                {
                    // Kết nối đến máy chủ SMTP
                    client.Connect("smtp.gmail.com", 587, MailKit.Security.SecureSocketOptions.StartTls);

                    // Xác thực với tài khoản Gmail
                    client.Authenticate("phong571737@gmail.com", "scfgcepmuwvcnzyl");

                    // Gửi email
                    client.Send(message);

                    // Ngắt kết nối
                    client.Disconnect(true);
                }
                MessageBox.Show("Email đã được gửi thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show($"Có lỗi xảy ra", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void btBrowse_Click(object sender, EventArgs e)
        {
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                tbAttach.Text = openFileDialog.FileName;
            }    
        }
    }
}
