using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
//using Newtonsoft.Json;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Lab2
{
   
    public partial class Bai4 : Form
    {
        List<Student> students = new List<Student>();
        
        public Bai4()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void AddInfo_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(WName.Text) 
                || string.IsNullOrEmpty(WPhone.Text)
                || string.IsNullOrEmpty(WID.Text)
                || string.IsNullOrEmpty(WCourse1.Text) 
                || string.IsNullOrEmpty(WCourse2.Text)
                || string.IsNullOrEmpty(WCourse3.Text)
                )
            {
                MessageBox.Show("Please fill in all information", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            var student = new Student();
            student.HoTen = WName.Text;
            student.MSSV = int.Parse(WID.Text);
            student.DienThoai = WPhone.Text;
            student.DiemMon1 = float.Parse(WCourse1.Text);
            student.DiemMon2 = float.Parse(WCourse2.Text);
            student.DiemMon3 = float.Parse(WCourse3.Text);   
            float avg = (student.DiemMon1 + student.DiemMon2 + student.DiemMon3)/3;
            WAverage.Text = avg.ToString();
            student.DiemTrungBinh = float.Parse(WAverage.Text);
            students.Add(student);
            string studentInfor = $"{student.HoTen}\n" 
                                + $"{student.MSSV}\n" 
                                + $"{student.DienThoai}\n"
                                + $"{student.DiemMon1}\n"
                                + $"{student.DiemMon2}\n"
                                + $"{student.DiemMon3}\n"
                                + $"{student.DiemTrungBinh}\n";
            richTextBox1.AppendText(studentInfor);
            WName.Clear();
            WID.Clear();
            WPhone.Clear(); 
            WCourse1.Clear();
            WCourse2.Clear();
            WCourse3.Clear();
            WAverage.Clear();   
        }

        private void WFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName + ".json";
                SerializeToFileJson(filePath, students);
            }
        }

        public void InforStudent(Student studentId)
        {
            RName.Text = students[0].HoTen.ToString();
            RID.Text = students[0].MSSV.ToString();
            RPhone.Text = students[0].DienThoai.ToString();
            RCourse1.Text = students[0].DiemMon1.ToString();
            RCourse2.Text = students[0].DiemMon2.ToString();
            RCourse3.Text = students[0].DiemMon3.ToString();
            RAverage.Text = students[0].DiemTrungBinh.ToString();
        }

        int stt = 0;
        private void RFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog(); 
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                page.Text = (stt + 1).ToString();
                students = DeserializeFromFileJson(openFileDialog.FileName);
                if(students == null)
                {
                    MessageBox.Show("Empty list");
                }
                else
                {
                    InforStudent(students[0]);
                }
            }
        }

        static void SerializeToFileJson(string filePath, List<Student> obj)
        {
            try
            {
                var options = new JsonSerializerOptions()
                {
                    IncludeFields = true,
                };
                // Serialize the object to JSON format
                string json = JsonSerializer.Serialize(obj, options);
                File.WriteAllText(filePath, json);
                MessageBox.Show($"Serialized data successfully written to {filePath} ");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error occurred while serializing data: {ex.Message} ");
            }
        }
        static List<Student> DeserializeFromFileJson(string filePath)
        {
            try
            {
                // Read the JSON data from the file
                string json = File.ReadAllText(filePath);
                // Deserialize the JSON data to the specified type
                return JsonSerializer.Deserialize<List<Student>>(json);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error occurred while deserializing data:{ ex.Message}");
            return default;
            }
        }

        private void WName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void BackInfor_Click(object sender, EventArgs e)
        {
            if(stt > 0)
            {
                stt--;
                page.Text = stt.ToString(); 
                InforStudent(students[(int)stt]);
            }
        }

        private void NextInfor_Click(object sender, EventArgs e)
        {

            if (stt < students.Count - 1 && students != null)
            {
                stt++;
                page.Text = stt.ToString();
                InforStudent(students[(int)stt]);
            }
        }
    }
    [Serializable] public class Student
    {
        public string HoTen { get; set; }
        public int MSSV { get; set; }
        public string DienThoai { get; set; }
        public float DiemMon1 { get; set; }
        public float DiemMon2 { get; set; }
        public float DiemMon3 { get; set; }
        public float DiemTrungBinh { get; set; }
    }
    
}
