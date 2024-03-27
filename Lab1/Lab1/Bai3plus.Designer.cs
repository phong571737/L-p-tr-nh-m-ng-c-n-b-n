namespace Lab1
{
    partial class Bai3plus
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
            this.InputNum = new System.Windows.Forms.TextBox();
            this.OutNum = new System.Windows.Forms.TextBox();
            this.ReadNum = new System.Windows.Forms.Button();
            this.DelNum = new System.Windows.Forms.Button();
            this.ExitPro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(205, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(371, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "ĐỌC SỐ NÂNG CAO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập số";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 367);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kết quả";
            // 
            // InputNum
            // 
            this.InputNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InputNum.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputNum.Location = new System.Drawing.Point(151, 96);
            this.InputNum.Name = "InputNum";
            this.InputNum.Size = new System.Drawing.Size(287, 34);
            this.InputNum.TabIndex = 3;
            // 
            // OutNum
            // 
            this.OutNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OutNum.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutNum.Location = new System.Drawing.Point(135, 359);
            this.OutNum.Name = "OutNum";
            this.OutNum.Size = new System.Drawing.Size(563, 34);
            this.OutNum.TabIndex = 4;
            // 
            // ReadNum
            // 
            this.ReadNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ReadNum.Font = new System.Drawing.Font("Times New Roman", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReadNum.Location = new System.Drawing.Point(643, 96);
            this.ReadNum.Name = "ReadNum";
            this.ReadNum.Size = new System.Drawing.Size(114, 50);
            this.ReadNum.TabIndex = 5;
            this.ReadNum.Text = "Đọc";
            this.ReadNum.UseVisualStyleBackColor = false;
            this.ReadNum.Click += new System.EventHandler(this.ReadNum_Click);
            // 
            // DelNum
            // 
            this.DelNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.DelNum.Font = new System.Drawing.Font("Times New Roman", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DelNum.Location = new System.Drawing.Point(643, 180);
            this.DelNum.Name = "DelNum";
            this.DelNum.Size = new System.Drawing.Size(114, 50);
            this.DelNum.TabIndex = 6;
            this.DelNum.Text = "Xóa";
            this.DelNum.UseVisualStyleBackColor = false;
            this.DelNum.Click += new System.EventHandler(this.DelNum_Click);
            // 
            // ExitPro
            // 
            this.ExitPro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ExitPro.Font = new System.Drawing.Font("Times New Roman", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitPro.Location = new System.Drawing.Point(643, 278);
            this.ExitPro.Name = "ExitPro";
            this.ExitPro.Size = new System.Drawing.Size(114, 50);
            this.ExitPro.TabIndex = 7;
            this.ExitPro.Text = "Thoát";
            this.ExitPro.UseVisualStyleBackColor = false;
            this.ExitPro.Click += new System.EventHandler(this.ExitPro_Click);
            // 
            // Bai3plus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ExitPro);
            this.Controls.Add(this.DelNum);
            this.Controls.Add(this.ReadNum);
            this.Controls.Add(this.OutNum);
            this.Controls.Add(this.InputNum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Bai3plus";
            this.Text = "Bai3plus";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox InputNum;
        private System.Windows.Forms.TextBox OutNum;
        private System.Windows.Forms.Button ReadNum;
        private System.Windows.Forms.Button DelNum;
        private System.Windows.Forms.Button ExitPro;
    }
}