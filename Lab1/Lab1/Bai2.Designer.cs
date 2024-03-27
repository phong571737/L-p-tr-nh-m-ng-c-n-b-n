namespace Lab1
{
    partial class Bai2
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.FindNum = new System.Windows.Forms.Button();
            this.DelNum = new System.Windows.Forms.Button();
            this.ClsPro = new System.Windows.Forms.Button();
            this.Number2 = new System.Windows.Forms.TextBox();
            this.Number1 = new System.Windows.Forms.TextBox();
            this.Number3 = new System.Windows.Forms.TextBox();
            this.MinNum = new System.Windows.Forms.TextBox();
            this.MaxNum = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(146, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(514, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "TÌM SỐ LỚN NHẤT, SỐ NHỎ NHẤT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(71, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số thứ nhất";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(71, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số thứ hai";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(71, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số thứ ba";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(110, 324);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 26);
            this.label5.TabIndex = 4;
            this.label5.Text = "Số lớn nhất";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(110, 399);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 26);
            this.label6.TabIndex = 5;
            this.label6.Text = "Số bé nhất";
            // 
            // FindNum
            // 
            this.FindNum.BackColor = System.Drawing.Color.Yellow;
            this.FindNum.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FindNum.Location = new System.Drawing.Point(633, 96);
            this.FindNum.Name = "FindNum";
            this.FindNum.Size = new System.Drawing.Size(121, 46);
            this.FindNum.TabIndex = 6;
            this.FindNum.Text = "Tìm";
            this.FindNum.UseVisualStyleBackColor = false;
            this.FindNum.Click += new System.EventHandler(this.FindNum_Click);
            // 
            // DelNum
            // 
            this.DelNum.BackColor = System.Drawing.Color.Yellow;
            this.DelNum.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DelNum.Location = new System.Drawing.Point(633, 178);
            this.DelNum.Name = "DelNum";
            this.DelNum.Size = new System.Drawing.Size(121, 42);
            this.DelNum.TabIndex = 7;
            this.DelNum.Text = "Xóa";
            this.DelNum.UseVisualStyleBackColor = false;
            this.DelNum.Click += new System.EventHandler(this.DelNum_Click);
            // 
            // ClsPro
            // 
            this.ClsPro.BackColor = System.Drawing.Color.Yellow;
            this.ClsPro.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClsPro.Location = new System.Drawing.Point(633, 257);
            this.ClsPro.Name = "ClsPro";
            this.ClsPro.Size = new System.Drawing.Size(121, 48);
            this.ClsPro.TabIndex = 8;
            this.ClsPro.Text = "Thoát";
            this.ClsPro.UseVisualStyleBackColor = false;
            this.ClsPro.Click += new System.EventHandler(this.ClsPro_Click);
            // 
            // Number2
            // 
            this.Number2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Number2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Number2.Location = new System.Drawing.Point(224, 153);
            this.Number2.Name = "Number2";
            this.Number2.Size = new System.Drawing.Size(222, 34);
            this.Number2.TabIndex = 9;
            this.Number2.TextChanged += new System.EventHandler(this.Number2_TextChanged);
            // 
            // Number1
            // 
            this.Number1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Number1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Number1.Location = new System.Drawing.Point(224, 94);
            this.Number1.Name = "Number1";
            this.Number1.Size = new System.Drawing.Size(222, 34);
            this.Number1.TabIndex = 10;
            this.Number1.TextChanged += new System.EventHandler(this.Number1_TextChanged);
            // 
            // Number3
            // 
            this.Number3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Number3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Number3.Location = new System.Drawing.Point(224, 212);
            this.Number3.Name = "Number3";
            this.Number3.Size = new System.Drawing.Size(222, 34);
            this.Number3.TabIndex = 11;
            this.Number3.TextChanged += new System.EventHandler(this.Number3_TextChanged);
            // 
            // MinNum
            // 
            this.MinNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MinNum.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinNum.Location = new System.Drawing.Point(305, 396);
            this.MinNum.Name = "MinNum";
            this.MinNum.Size = new System.Drawing.Size(449, 34);
            this.MinNum.TabIndex = 12;
            this.MinNum.TextChanged += new System.EventHandler(this.MinNum_TextChanged);
            // 
            // MaxNum
            // 
            this.MaxNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MaxNum.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaxNum.Location = new System.Drawing.Point(305, 321);
            this.MaxNum.Name = "MaxNum";
            this.MaxNum.Size = new System.Drawing.Size(449, 34);
            this.MaxNum.TabIndex = 13;
            // 
            // Bai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MaxNum);
            this.Controls.Add(this.MinNum);
            this.Controls.Add(this.Number3);
            this.Controls.Add(this.Number1);
            this.Controls.Add(this.Number2);
            this.Controls.Add(this.ClsPro);
            this.Controls.Add(this.DelNum);
            this.Controls.Add(this.FindNum);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Bai2";
            this.Text = "Bai2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button FindNum;
        private System.Windows.Forms.Button DelNum;
        private System.Windows.Forms.Button ClsPro;
        private System.Windows.Forms.TextBox Number2;
        private System.Windows.Forms.TextBox Number1;
        private System.Windows.Forms.TextBox Number3;
        private System.Windows.Forms.TextBox MinNum;
        private System.Windows.Forms.TextBox MaxNum;
    }
}