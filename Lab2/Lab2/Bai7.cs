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
    public partial class Bai7 : Form
    {
        string path = @"D:\";
        public Bai7()
        {
            InitializeComponent();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            groupBox1.Controls.Clear();
            TreeNode node = treeView1.GetNodeAt(treeView1.PointToClient(Cursor.Position));
            if(node != null)
            {
                string filePath = node.Text;    
                if(Path.GetExtension(filePath).ToLower() == ".jpg" 
                   || Path.GetExtension(filePath).ToLower() == "jpeg"
                   || Path.GetExtension(filePath).ToLower() == "gif"
                   || Path.GetExtension(filePath).ToLower() == "png"
                   || Path.GetExtension(filePath).ToLower() == "svg"
                   )
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Image = Image.FromFile(filePath);    
                    pictureBox.Dock = DockStyle.Fill;
                    pictureBox.Height = 426;
                    pictureBox.Width = 549;
                    groupBox1.Controls.Add(pictureBox);
                }
                else if(Path.GetExtension(filePath).ToLower() == ".txt")
                {
                    System.Windows.Forms.TextBox textBox = new System.Windows.Forms.TextBox();  
                    textBox.Multiline = true;
                    textBox.Dock = DockStyle.Fill;
                    textBox.ScrollBars = ScrollBars.Vertical;   
                    textBox.Text = File.ReadAllText(filePath);  
                    groupBox1.Controls.Add(textBox);    
                }
                else
                {
                    MessageBox.Show("Cannot display content");
                }
            }
        }
        public void Loadfile_folder(TreeNode root)
        {
             if (root == null) return;
            try
            {
                string[] filePaths = Directory.GetFiles(root.Text);
                foreach (string filePath in filePaths)
                {
                    TreeNode node = new TreeNode() { Text = filePath };
                    root.Nodes.Add(node);
                }
                DirectoryInfo[] directory = new DirectoryInfo(root.Text).GetDirectories();
                if (directory.Count() == 0) return;
                foreach (DirectoryInfo d in directory)
                {
                    if (Directory.Exists(d.FullName))
                    {
                        TreeNode node = new TreeNode() { Text = d.FullName };
                        root.Nodes.Add(node);
                        Loadfile_folder(node);
                    }
                }
            }
            catch
            {
                return;
            }
        }

        private void Bai7_Load(object sender, EventArgs e)
        {
            
            if (Directory.Exists(path))
            {
                TreeNode node = new TreeNode() { Text = path};
                Loadfile_folder(node);
                treeView1.Nodes.Add(node);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
