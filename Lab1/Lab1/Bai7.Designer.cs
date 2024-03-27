namespace Lab1
{
    partial class Bai7
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
            this.label2 = new System.Windows.Forms.Label();
            this.Input = new System.Windows.Forms.TextBox();
            this.Rank = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Res = new System.Windows.Forms.TextBox();
            this.Avg = new System.Windows.Forms.TextBox();
            this.MinMaxNum = new System.Windows.Forms.TextBox();
            this.FindAns = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.point = new System.Windows.Forms.TextBox();
            this.FullName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(254, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "XỬ LÝ MẢNG";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập ";
            // 
            // Input
            // 
            this.Input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Input.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Input.Location = new System.Drawing.Point(90, 78);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(465, 39);
            this.Input.TabIndex = 2;
            this.Input.TextChanged += new System.EventHandler(this.Input_TextChanged);
            // 
            // Rank
            // 
            this.Rank.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Rank.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rank.Location = new System.Drawing.Point(563, 399);
            this.Rank.Name = "Rank";
            this.Rank.Size = new System.Drawing.Size(107, 39);
            this.Rank.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(560, 359);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 33);
            this.label4.TabIndex = 5;
            this.label4.Text = "Xếp loại";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 359);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(203, 33);
            this.label5.TabIndex = 6;
            this.label5.Text = "Đạt và không đạt";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(449, 263);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(316, 33);
            this.label6.TabIndex = 7;
            this.label6.Text = "Điểm cao nhất và thấp nhất";
            // 
            // Res
            // 
            this.Res.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Res.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Res.Location = new System.Drawing.Point(27, 399);
            this.Res.Name = "Res";
            this.Res.Size = new System.Drawing.Size(191, 39);
            this.Res.TabIndex = 8;
            // 
            // Avg
            // 
            this.Avg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Avg.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Avg.Location = new System.Drawing.Point(27, 299);
            this.Avg.Name = "Avg";
            this.Avg.Size = new System.Drawing.Size(191, 39);
            this.Avg.TabIndex = 9;
            // 
            // MinMaxNum
            // 
            this.MinMaxNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MinMaxNum.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinMaxNum.Location = new System.Drawing.Point(455, 299);
            this.MinMaxNum.Name = "MinMaxNum";
            this.MinMaxNum.Size = new System.Drawing.Size(298, 39);
            this.MinMaxNum.TabIndex = 10;
            // 
            // FindAns
            // 
            this.FindAns.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.FindAns.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FindAns.Location = new System.Drawing.Point(619, 60);
            this.FindAns.Name = "FindAns";
            this.FindAns.Size = new System.Drawing.Size(146, 57);
            this.FindAns.TabIndex = 11;
            this.FindAns.Text = "Tìm";
            this.FindAns.UseVisualStyleBackColor = false;
            this.FindAns.Click += new System.EventHandler(this.FindAns_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 33);
            this.label3.TabIndex = 4;
            this.label3.Text = "Điểm trung bình";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 33);
            this.label7.TabIndex = 12;
            this.label7.Text = "Họ tên";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 214);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(187, 33);
            this.label8.TabIndex = 13;
            this.label8.Text = "Điểm từng môn";
            // 
            // point
            // 
            this.point.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.point.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.point.Location = new System.Drawing.Point(215, 208);
            this.point.Name = "point";
            this.point.Size = new System.Drawing.Size(531, 39);
            this.point.TabIndex = 15;
            this.point.TextChanged += new System.EventHandler(this.point_TextChanged);
            // 
            // FullName
            // 
            this.FullName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FullName.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FullName.Location = new System.Drawing.Point(142, 147);
            this.FullName.Name = "FullName";
            this.FullName.Size = new System.Drawing.Size(604, 39);
            this.FullName.TabIndex = 16;
            // 
            // Bai7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FullName);
            this.Controls.Add(this.point);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.FindAns);
            this.Controls.Add(this.MinMaxNum);
            this.Controls.Add(this.Avg);
            this.Controls.Add(this.Res);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Rank);
            this.Controls.Add(this.Input);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Bai7";
            this.Text = "Bai7";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Input;
        private System.Windows.Forms.TextBox Rank;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Res;
        private System.Windows.Forms.TextBox Avg;
        private System.Windows.Forms.TextBox MinMaxNum;
        private System.Windows.Forms.Button FindAns;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox point;
        private System.Windows.Forms.TextBox FullName;
    }
}