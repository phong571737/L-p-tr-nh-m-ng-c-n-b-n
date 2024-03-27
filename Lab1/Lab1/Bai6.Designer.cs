namespace Lab1
{
    partial class Bai6
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.Day = new System.Windows.Forms.Label();
            this.Month = new System.Windows.Forms.Label();
            this.Year = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.MonthBorn = new System.Windows.Forms.TextBox();
            this.YearBorn = new System.Windows.Forms.TextBox();
            this.DayBorn = new System.Windows.Forms.TextBox();
            this.Zodiac = new System.Windows.Forms.TextBox();
            this.CheckInf = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(252, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "CUNG HOÀNG ĐẠO";
            // 
            // Day
            // 
            this.Day.AutoSize = true;
            this.Day.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Day.Location = new System.Drawing.Point(98, 97);
            this.Day.Name = "Day";
            this.Day.Size = new System.Drawing.Size(127, 33);
            this.Day.TabIndex = 1;
            this.Day.Text = "Ngày sinh";
            // 
            // Month
            // 
            this.Month.AutoSize = true;
            this.Month.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Month.Location = new System.Drawing.Point(348, 97);
            this.Month.Name = "Month";
            this.Month.Size = new System.Drawing.Size(138, 33);
            this.Month.TabIndex = 2;
            this.Month.Text = "Tháng sinh";
            // 
            // Year
            // 
            this.Year.AutoSize = true;
            this.Year.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Year.Location = new System.Drawing.Point(587, 97);
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(121, 33);
            this.Year.TabIndex = 3;
            this.Year.Text = "Năm sinh";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(35, 347);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(203, 33);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cung hoàng đạo ";
            // 
            // MonthBorn
            // 
            this.MonthBorn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MonthBorn.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MonthBorn.Location = new System.Drawing.Point(354, 154);
            this.MonthBorn.Name = "MonthBorn";
            this.MonthBorn.Size = new System.Drawing.Size(132, 34);
            this.MonthBorn.TabIndex = 5;
            this.MonthBorn.TextChanged += new System.EventHandler(this.MonthBorn_TextChanged);
            // 
            // YearBorn
            // 
            this.YearBorn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.YearBorn.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YearBorn.Location = new System.Drawing.Point(593, 154);
            this.YearBorn.Name = "YearBorn";
            this.YearBorn.Size = new System.Drawing.Size(115, 34);
            this.YearBorn.TabIndex = 6;
            this.YearBorn.TextChanged += new System.EventHandler(this.YearBorn_TextChanged);
            // 
            // DayBorn
            // 
            this.DayBorn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DayBorn.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DayBorn.Location = new System.Drawing.Point(104, 154);
            this.DayBorn.Name = "DayBorn";
            this.DayBorn.Size = new System.Drawing.Size(121, 34);
            this.DayBorn.TabIndex = 7;
            this.DayBorn.TextChanged += new System.EventHandler(this.DayBorn_TextChanged);
            // 
            // Zodiac
            // 
            this.Zodiac.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Zodiac.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Zodiac.Location = new System.Drawing.Point(283, 346);
            this.Zodiac.Name = "Zodiac";
            this.Zodiac.Size = new System.Drawing.Size(370, 34);
            this.Zodiac.TabIndex = 8;
            // 
            // CheckInf
            // 
            this.CheckInf.BackColor = System.Drawing.Color.Yellow;
            this.CheckInf.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckInf.ForeColor = System.Drawing.Color.Red;
            this.CheckInf.Location = new System.Drawing.Point(336, 224);
            this.CheckInf.Name = "CheckInf";
            this.CheckInf.Size = new System.Drawing.Size(150, 57);
            this.CheckInf.TabIndex = 9;
            this.CheckInf.Text = "CHECK";
            this.CheckInf.UseVisualStyleBackColor = false;
            this.CheckInf.Click += new System.EventHandler(this.CheckInf_Click);
            // 
            // Bai6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CheckInf);
            this.Controls.Add(this.Zodiac);
            this.Controls.Add(this.DayBorn);
            this.Controls.Add(this.YearBorn);
            this.Controls.Add(this.MonthBorn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Year);
            this.Controls.Add(this.Month);
            this.Controls.Add(this.Day);
            this.Controls.Add(this.label1);
            this.Name = "Bai6";
            this.Text = "Bai5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Day;
        private System.Windows.Forms.Label Month;
        private System.Windows.Forms.Label Year;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox MonthBorn;
        private System.Windows.Forms.TextBox YearBorn;
        private System.Windows.Forms.TextBox DayBorn;
        private System.Windows.Forms.TextBox Zodiac;
        private System.Windows.Forms.Button CheckInf;
    }
}