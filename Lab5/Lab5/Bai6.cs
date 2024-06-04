using MailKit;
using MailKit.Net.Imap;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5
{
    public partial class Bai6 : System.Windows.Forms.Form
    {
        private ImapClient imapclient;
        public Bai6()
        {
            InitializeComponent();
            btLogin.Enabled = true;
            btLogout.Enabled = false;
            button3.Enabled = false;
            tbPass.PasswordChar = '*';
            lvContent.SelectedIndexChanged += LvContent_SelectedIndexChanged; 
        }

        private void LvContent_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach(ListViewItem selectedItem in lvContent.SelectedItems)
            {
                
                int emailIndex = (int)selectedItem.Tag;
                var message = imapclient.Inbox.GetMessage(emailIndex);

                // hiển thị nội dung mail lên một form riêng
                ShowEmailContentForm(message.TextBody);
            }    
        }

        private void ShowEmailContentForm(string emailContent)
        {
            ContentEmail content = new ContentEmail(emailContent);
            content.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SendMail sendMail = new SendMail();
            sendMail.Show();
        }

        private void LoadEmails()
        {
            var inbox = imapclient.Inbox;
            inbox.Open(FolderAccess.ReadOnly);

            lvContent.Items.Clear();

            for (int i = 0; i < Math.Min(inbox.Count, 20); i++)
            {
                var message = inbox.GetMessage(i);
                var item = new ListViewItem(new[] { (i + 1).ToString(), message.Subject, message.From.ToString(), message.Date.DateTime.ToString() });
                item.Tag = i;// lưu chỉ số của email vào trong listview
                lvContent.Items.Add(item);
            }
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            string user = tbUser.Text;
            string pass = tbPass.Text;
            try
            {
                imapclient = new ImapClient();
                imapclient.Connect("imap.gmail.com", 993, true);
                imapclient.Authenticate(user, pass);
                LoadEmails();
                MessageBox.Show("Đăng nhập thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);   
                btLogin.Enabled = false;
                btLogout.Enabled = true;
                button3.Enabled = true;
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Đăng nhập thất bại: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btLogout_Click(object sender, EventArgs e)
        {
            if (imapclient != null)
            {
                imapclient.Disconnect(true);// đăng xuất
                imapclient.Dispose();// giải phóng tài nguyên
                lvContent.Items.Clear();
                tbUser.Clear();
                tbPass.Clear();
                MessageBox.Show("Đăng xuất thành công ", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information );
                btLogin.Enabled = true;
                btLogout.Enabled = false;
                button3.Enabled= false;
            }
        }
    }
}
