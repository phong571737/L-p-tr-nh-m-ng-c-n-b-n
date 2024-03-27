using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Bai8 : Form
    {
        public Bai8()
        {
            InitializeComponent();
        }

        private void AddDish_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(InpDish.Text))
            {
                listDishAdd.View = View.List; // display dish in a line
                //if (AddDish.Text == "Thêm") // add dish
                //{
                    listDishAdd.Text = InpDish.Text;    
                    listDishAdd.Items.Add(InpDish.Text);
                    InpDish.Text = ""; //clear inputdish 
                    OutDish.Text = "";// clear outdish
                //}
            }
            else
            {
                MessageBox.Show("Vui lòng nhập món ăn! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return ;
            }
        }

        private void FindDish_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(listDishAdd.Text))
            {
                Random rnd = new Random();
                int index = rnd.Next(0, listDishAdd.Items.Count);
                OutDish.Text = listDishAdd.Items[index].Text;
            }
            else
            {
                MessageBox.Show("Không có món ăn nào trong danh sách! Vui lòng thêm món ăn", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);   
                return ;
            }
        }

        private void DelDish_Click(object sender, EventArgs e)
        {

                listDishAdd.Clear();
                OutDish.Clear();
                
        }

        private void ClsPro_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InpDish_TextChanged(object sender, EventArgs e)
        {

        }

        private void listDishAdd_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
