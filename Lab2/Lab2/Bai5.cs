using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Lab2
{
    public partial class Bai5 : Form
    {
        public Bai5()
        {
            InitializeComponent();
        }
        public class Film
        {
            public string Name { get; set; }
            public List<int> RoomID { get; set; }
            public int Fare { get; set; }
            public Film(string a, List<int> b, int c)
            {
                Name = a;
                RoomID = b;
                Fare = c;
            }
            public Film()
            {
                this.Name = string.Empty;
                this.RoomID = new List<int>();
                this.Fare = 0;
            }
            public override string ToString()
            {
                string kq = string.Empty;
                kq += this.Name + " " + this.Fare.ToString() + " ";
                foreach (int i in this.RoomID)
                {
                    kq += i.ToString() + ",";
                }
                return kq;
            }

        }
        private Dictionary<string, Film> movies = new Dictionary<string, Film>();
        private Dictionary<string, int> soldTickets = new Dictionary<string, int>();

        private void UpdateRoomCheckListBox(List<int> rooms)
        {
            checkedListBoxSeat.Items.Clear();
            foreach (var room in rooms)
            {
                checkedListBoxSeat.Items.Add($"Room {room}");
            }
        }

        private void Pay_Click(object sender, EventArgs e)
        {
            string selectedMovie = comboBoxMovie.SelectedItem.ToString();
            Film movie = movies[selectedMovie];
            List<int> selectedRooms = new List<int>();
            foreach (var item in checkedListBoxSeat.CheckedItems)
            {
                string roomStr = item.ToString().Replace("Room ", "");
                selectedRooms.Add(int.Parse(roomStr));
            }
            if (selectedRooms.Count == 0)
            {
                MessageBox.Show("Please select at least one room.");
                return;
            }
            string customerName = WName.Text;
            int totalPrice = movie.Fare * selectedRooms.Count;
            soldTickets[selectedMovie] += selectedRooms.Count;
            try
            {
                using (StreamWriter sw = new StreamWriter("output5.txt"))
                {
                    foreach (var m in movies)
                    {

                    }
                }
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }       
        
        private void LoadMoviesFromFile(string fileName)
        {
            try
            { 
                using (StreamReader sr = new StreamReader(fileName))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] parts = line.Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
                        Name = parts[0].Trim();
                        int ticketPrice = int.Parse(parts[1].Replace("đ", "").Trim());
                        List<int> rooms = parts[2].Split(',').Select(x => int.Parse(x.Trim())).ToList();
                        movies.Add(comboBoxMovie.Text, new Film(comboBoxMovie.Text, rooms, ticketPrice));
                        soldTickets.Add(Name, 0);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
        }
        private void comboBoxMovie_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedMovie = comboBoxMovie.SelectedItem.ToString();
            Film movie = movies[selectedMovie];
            selectedMovie = movie.Name;
        }

        private void Bai5_Load(object sender, EventArgs e)
        {
            LoadMoviesFromFile("input5.txt");
        }

        private void WName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
