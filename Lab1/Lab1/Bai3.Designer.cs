namespace Lab1
{
    partial class Bai3
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
            this.ReadNum = new System.Windows.Forms.Label();
            this.InNum = new System.Windows.Forms.Label();
            this.Result = new System.Windows.Forms.Label();
            this.FindNum = new System.Windows.Forms.Button();
            this.DelNum = new System.Windows.Forms.Button();
            this.ClsProgram = new System.Windows.Forms.Button();
            this.ResultStr = new System.Windows.Forms.TextBox();
            this.InpNum = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ReadNum
            // 
            this.ReadNum.AutoSize = true;
            this.ReadNum.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReadNum.ForeColor = System.Drawing.Color.Purple;
            this.ReadNum.Location = new System.Drawing.Point(314, 28);
            this.ReadNum.Name = "ReadNum";
            this.ReadNum.Size = new System.Drawing.Size(156, 38);
            this.ReadNum.TabIndex = 0;
            this.ReadNum.Text = "ĐỌC SỐ ";
            // 
            // InNum
            // 
            this.InNum.AutoSize = true;
            this.InNum.Font = new System.Drawing.Font("Times New Roman", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InNum.Location = new System.Drawing.Point(93, 90);
            this.InNum.Name = "InNum";
            this.InNum.Size = new System.Drawing.Size(116, 32);
            this.InNum.TabIndex = 1;
            this.InNum.Text = "Nhập số ";
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.Font = new System.Drawing.Font("Times New Roman", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Result.Location = new System.Drawing.Point(96, 355);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(103, 32);
            this.Result.TabIndex = 2;
            this.Result.Text = "Kết quả";
            // 
            // FindNum
            // 
            this.FindNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.FindNum.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FindNum.Location = new System.Drawing.Point(626, 90);
            this.FindNum.Name = "FindNum";
            this.FindNum.Size = new System.Drawing.Size(111, 51);
            this.FindNum.TabIndex = 3;
            this.FindNum.Text = "Tìm ";
            this.FindNum.UseVisualStyleBackColor = false;
            this.FindNum.Click += new System.EventHandler(this.FindNum_Click);
            // 
            // DelNum
            // 
            this.DelNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DelNum.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DelNum.Location = new System.Drawing.Point(626, 185);
            this.DelNum.Name = "DelNum";
            this.DelNum.Size = new System.Drawing.Size(111, 51);
            this.DelNum.TabIndex = 4;
            this.DelNum.Text = "Xóa";
            this.DelNum.UseVisualStyleBackColor = false;
            this.DelNum.Click += new System.EventHandler(this.DelNum_Click);
            // 
            // ClsProgram
            // 
            this.ClsProgram.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClsProgram.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClsProgram.Location = new System.Drawing.Point(626, 279);
            this.ClsProgram.Name = "ClsProgram";
            this.ClsProgram.Size = new System.Drawing.Size(111, 47);
            this.ClsProgram.TabIndex = 5;
            this.ClsProgram.Text = "Thoát";
            this.ClsProgram.UseVisualStyleBackColor = false;
            this.ClsProgram.Click += new System.EventHandler(this.ClsProgram_Click);
            // 
            // ResultStr
            // 
            this.ResultStr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ResultStr.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultStr.Location = new System.Drawing.Point(269, 348);
            this.ResultStr.Name = "ResultStr";
            this.ResultStr.Size = new System.Drawing.Size(265, 39);
            this.ResultStr.TabIndex = 6;
            // 
            // InpNum
            // 
            this.InpNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InpNum.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InpNum.Location = new System.Drawing.Point(269, 83);
            this.InpNum.Name = "InpNum";
            this.InpNum.Size = new System.Drawing.Size(175, 39);
            this.InpNum.TabIndex = 7;
            this.InpNum.TextChanged += new System.EventHandler(this.InpNum_TextChanged);
            // 
            // Bai3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.InpNum);
            this.Controls.Add(this.ResultStr);
            this.Controls.Add(this.ClsProgram);
            this.Controls.Add(this.DelNum);
            this.Controls.Add(this.FindNum);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.InNum);
            this.Controls.Add(this.ReadNum);
            this.Name = "Bai3";
            this.Text = "Bai3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ReadNum;
        private System.Windows.Forms.Label InNum;
        private System.Windows.Forms.Label Result;
        private System.Windows.Forms.Button FindNum;
        private System.Windows.Forms.Button DelNum;
        private System.Windows.Forms.Button ClsProgram;
        private System.Windows.Forms.TextBox ResultStr;
        private System.Windows.Forms.TextBox InpNum;
    }
}