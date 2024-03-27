namespace Lab1
{
    partial class Bai1
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
            this.CalcuNum = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Num1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Num2 = new System.Windows.Forms.TextBox();
            this.Result = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CalcuNum
            // 
            this.CalcuNum.BackColor = System.Drawing.Color.Yellow;
            this.CalcuNum.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalcuNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.CalcuNum.Location = new System.Drawing.Point(359, 261);
            this.CalcuNum.Name = "CalcuNum";
            this.CalcuNum.Size = new System.Drawing.Size(141, 65);
            this.CalcuNum.TabIndex = 0;
            this.CalcuNum.Text = "Tính";
            this.CalcuNum.UseVisualStyleBackColor = false;
            this.CalcuNum.Click += new System.EventHandler(this.CalcuNum_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(200, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(426, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "TÍNH TỔNG HAI SỐ NGUYÊN";
            // 
            // Num1
            // 
            this.Num1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num1.Location = new System.Drawing.Point(271, 121);
            this.Num1.Name = "Num1";
            this.Num1.Size = new System.Drawing.Size(323, 34);
            this.Num1.TabIndex = 2;
            this.Num1.TextChanged += new System.EventHandler(this.Num1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(70, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Số thứ hai";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(70, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "Số thứ nhất";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(70, 364);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 26);
            this.label4.TabIndex = 5;
            this.label4.Text = "Kết quả";
            // 
            // Num2
            // 
            this.Num2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num2.Location = new System.Drawing.Point(271, 200);
            this.Num2.Name = "Num2";
            this.Num2.Size = new System.Drawing.Size(323, 34);
            this.Num2.TabIndex = 6;
            this.Num2.TextChanged += new System.EventHandler(this.Num2_TextChanged);
            // 
            // Result
            // 
            this.Result.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Result.Location = new System.Drawing.Point(271, 368);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(323, 34);
            this.Result.TabIndex = 7;
            // 
            // Bai1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.Num2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Num1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CalcuNum);
            this.Name = "Bai1";
            this.Text = "Bai1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CalcuNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Num1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Num2;
        private System.Windows.Forms.TextBox Result;
    }
}