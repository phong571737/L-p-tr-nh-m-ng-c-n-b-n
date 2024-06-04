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
    public partial class Bai2 : System.Windows.Forms.Form
    {
        public Bai2()
        {
            InitializeComponent();
            tbPass.PasswordChar = '*';
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            string userName = tbmail.Text;
            string password = tbPass.Text;
            try
            {
                using(var client = new ImapClient())
                {
                    client.Connect("imap.gmail.com", 993, true);
                    client.Authenticate(userName, password);

                    var inbox = client.Inbox;
                    inbox.Open(FolderAccess.ReadOnly);

                    tbTotal.Text = inbox.Count.ToString();
                    tbRecent.Text = inbox.Recent.ToString();

                    lvContent.Items.Clear();

                    // lấy và hiển thị 20 thư gần nhất
                    for (int i = 0; i < Math.Min(inbox.Count, 20); i++)
                    {
                        var message = inbox.GetMessage(i);
                        var item = new ListViewItem();
                        item.Text = message.Subject;
                        item.SubItems.Add(message.From.ToString());
                        //item.SubItems.Add(message.Subject.ToString());
                        item.SubItems.Add(message.Date.DateTime.ToString());    

                        lvContent.Items.Add(item);

                    }
                    client.Disconnect(true);
                }
                MessageBox.Show("Email được tải lên thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Có lỗi", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
