using MailKit.Net.Imap;
using MailKit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MailKit.Net.Pop3;

namespace Lab5
{
    public partial class Bai3 : System.Windows.Forms.Form
    {
        public Bai3()
        {
            InitializeComponent();
            tbPass.PasswordChar = '*';
        }

        private string GetSelectedProtocol()
        {
            foreach (var item in checkedListBox1.CheckedItems)
            {
                return item.ToString();
            }
            return null;
        }

        private void tbLogin_Click(object sender, EventArgs e)
        {
            string userName = tbUser.Text;
            string pass = tbPass.Text;
            string selectedPro = GetSelectedProtocol();
            try
            {
                if(selectedPro == "IMAP")
                {
                    using (var client = new ImapClient())
                    {
                        client.Connect("imap.gmail.com", 993, true);
                        client.Authenticate(userName, pass);

                        var inbox = client.Inbox;
                        inbox.Open(FolderAccess.ReadOnly);

                        tbTotal.Text = inbox.Count.ToString();
                        tbRecent.Text = inbox.Recent.ToString();

                        tbContent.Items.Clear();

                        // lấy và hiển thị 20 thư gần nhất
                        for (int i = 0; i < Math.Min(inbox.Count, 20); i++)
                        {
                            var message = inbox.GetMessage(i);
                            var item = new ListViewItem();
                            item.Text = message.Subject;
                            item.SubItems.Add(message.From.ToString());
                            //item.SubItems.Add(message.Subject.ToString());
                            item.SubItems.Add(message.Date.DateTime.ToString());

                            tbContent.Items.Add(item);

                        }
                        client.Disconnect(true);
                    }
                    MessageBox.Show("Email được tải lên bằng IMAP thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if(selectedPro == "POP3")
                {
                    using (var client = new Pop3Client())
                    {
                        client.Connect("pop.gmail.com", 995, true);
                        client.Authenticate(userName, pass);

                        var count = client.GetMessageCount();
                        tbTotal.Text = count.ToString();
                        tbRecent.Text = "0";

                        tbContent.Items.Clear();

                        for (int i = count - 1; i >= Math.Max(count - 20, 0); i--)
                        {
                            var message = client.GetMessage(i);
                            var item = new ListViewItem(message.Subject);
                            item.SubItems.Add(message.From.ToString());
                            item.SubItems.Add(message.Date.DateTime.ToString());

                            tbContent.Items.Add(item);
                        }
                        client.Disconnect(true);
                    }
                    MessageBox.Show("Email được tải lên bằng POP3 thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn phương thức gửi thư", "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Có lỗi", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
