using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using MimeKit;
using MailKitSmtpClient = MailKit.Net.Smtp.SmtpClient;

namespace Lab5
{
    public partial class Bai1 : System.Windows.Forms.Form
    {
        public Bai1()
        {
            InitializeComponent();

        }

        private void btSend_Click(object sender, EventArgs e)
        {
            string userName = "phong571737@gmail.com";
            string pass = "scfgcepmuwvcnzyl";

            try
            {
                string from = tbFrom.Text;
                string to = tbTo.Text;
                string subject = tbSubject.Text;
                string body = rtbContent.Text;

                var message = new MimeMessage();
                message.From.Add(new MailboxAddress("", from));
                message.To.Add(new MailboxAddress("", to));
                message.Subject = subject;

                // thiết lập nội dung email
                message.Body = new TextPart("plain")
                {
                    Text = body
                };

                // thiết lập smtpclient và gửi mail
                using (var client = new MailKitSmtpClient())
                {
                    // Kết nối đến máy chủ SMTP
                    client.Connect("smtp.gmail.com", 587, MailKit.Security.SecureSocketOptions.StartTls);

                    // Xác thực với tài khoản Gmail
                    client.Authenticate(userName, pass);

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
    }
}
