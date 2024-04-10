using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Lab2
{
    public partial class Bai6 : Form
    {
        string connectionString = @"Data Source=MonAn.db;Version=3;";

        public Bai6()
        {
            InitializeComponent();
        }

        private void FILLDGV()
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT TENMONAN FROM MONAN LIMIT 2";
                SQLiteDataAdapter da = new SQLiteDataAdapter(query, conn);
                DataTable dt = new DataTable();
                
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void AddDishAll(string id, string tenMonAn, string hinhAnh, string idncc)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                using (SQLiteCommand cmd = new SQLiteCommand(conn))
                {
                    cmd.CommandText = "INSERT INTO MONAN(IDMA, TenMonAn, HinhAnh, IDNCC) VALUES(@IDMA, @TenMonAn, @HinhAnh, @IDNCC)";
                    cmd.Parameters.AddWithValue("@IDMA", id);
                    cmd.Parameters.AddWithValue("@TenMonAn", tenMonAn);
                    cmd.Parameters.AddWithValue("@HinhAnh", hinhAnh);
                    cmd.Parameters.AddWithValue("@IDNCC", idncc);

                    cmd.ExecuteNonQuery();
                }
            }
        }
        private void AddDish_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                using (SQLiteCommand cmd = new SQLiteCommand(conn))
                {
                    AddDishAll("1", "bún bò", "", "MA1"); // First dish
                    AddDishAll("2", "phở", "", "MA2");    // Second dish
                    AddDishAll("3", "Cơm tấm", "", "MA3"); //third dish
                }
            }
        }

        private void CheckIfDataExists()
        {
            if (!File.Exists("MonAn.db"))
            {
                SQLiteConnection.CreateFile("MonAn.db");
                using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();
                    // create table MONAN
                    string commandstringmonan = @"
                    CREATE TABLE MONAN(
                    IDMA TEXT, 
                    TenMonAn TEXT, 
                    HinhAnh TEXT, 
                    IDNCC TEXT);";
                    string comandnguoidung = @"
                    CREATE TABLE NGUOIDUNG(
                    IDNCC TEXT, 
                    HoVaTen TEXT, 
                    QuyenHan TEXT);";

                    using (SQLiteCommand cmd = new SQLiteCommand(commandstringmonan, conn))
                    {
                        cmd.CommandText = comandnguoidung;
                        cmd.ExecuteNonQuery();
                        cmd.CommandText = commandstringmonan;
                        cmd.ExecuteNonQuery();  
                    }
                }
            }
            else
            {
                LoadContactDataListView();
            }
        }

        private void LoadContactDataListView()
        {
            dataGridView1.DataSource = GetDataFromDataBase();
        }

        private DataTable GetDataFromDataBase()
        {
            DataTable dt = new DataTable();
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string commandstring = "SELECT * FROM MONAN";
                using (SQLiteCommand cmd = new SQLiteCommand(commandstring, conn))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {

                        dt.Load(reader);
                    }
                }
            }
            return dt;
        }

        private void Bai6_Load(object sender, EventArgs e)
        {
            CheckIfDataExists();
            FILLDGV();
        }

        private void FindDish_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                Random rnd = new Random();
                int index = rnd.Next(0, dataGridView1.Rows.Count);
                DataGridViewRow row = dataGridView1.Rows[index];

                // Check if the cell value is not null before converting to string
                if (row.Cells[0].Value != null)
                {
                    string dishName = row.Cells[0].Value.ToString();
                    NameDish.Text = dishName;
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu cho món ăn này! Vui lòng chọn một món ăn khác.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Không có món ăn nào trong danh sách! Vui lòng thêm món ăn", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void DelDish_Click(object sender, EventArgs e)
        {
            NameDish.Clear();
            NameProvider.Clear();
        }

        private void ExitProc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
