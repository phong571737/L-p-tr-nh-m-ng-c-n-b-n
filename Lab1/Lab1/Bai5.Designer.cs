namespace Lab1
{
    partial class Bai5
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
            this.InpB = new System.Windows.Forms.Label();
            this.Inp = new System.Windows.Forms.Label();
            this.Ans = new System.Windows.Forms.Label();
            this.InputA = new System.Windows.Forms.TextBox();
            this.InputB = new System.Windows.Forms.TextBox();
            this.ChooseCal = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ListNum = new System.Windows.Forms.ListView();
            this.Calcu = new System.Windows.Forms.Button();
            this.Del = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InpB
            // 
            this.InpB.AutoSize = true;
            this.InpB.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InpB.Location = new System.Drawing.Point(41, 144);
            this.InpB.Name = "InpB";
            this.InpB.Size = new System.Drawing.Size(107, 32);
            this.InpB.TabIndex = 0;
            this.InpB.Text = "Nhập B";
            // 
            // Inp
            // 
            this.Inp.AutoSize = true;
            this.Inp.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Inp.Location = new System.Drawing.Point(43, 87);
            this.Inp.Name = "Inp";
            this.Inp.Size = new System.Drawing.Size(105, 32);
            this.Inp.TabIndex = 1;
            this.Inp.Text = "Nhập A";
            // 
            // Ans
            // 
            this.Ans.AutoSize = true;
            this.Ans.Font = new System.Drawing.Font("Times New Roman", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ans.Location = new System.Drawing.Point(12, 303);
            this.Ans.Name = "Ans";
            this.Ans.Size = new System.Drawing.Size(103, 32);
            this.Ans.TabIndex = 2;
            this.Ans.Text = "Kết quả";
            // 
            // InputA
            // 
            this.InputA.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputA.Location = new System.Drawing.Point(185, 80);
            this.InputA.Name = "InputA";
            this.InputA.Size = new System.Drawing.Size(387, 39);
            this.InputA.TabIndex = 3;
            this.InputA.TextChanged += new System.EventHandler(this.InputA_TextChanged);
            // 
            // InputB
            // 
            this.InputB.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputB.Location = new System.Drawing.Point(185, 137);
            this.InputB.Name = "InputB";
            this.InputB.Size = new System.Drawing.Size(387, 39);
            this.InputB.TabIndex = 4;
            // 
            // ChooseCal
            // 
            this.ChooseCal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ChooseCal.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChooseCal.FormattingEnabled = true;
            this.ChooseCal.Items.AddRange(new object[] {
            "Bảng cửu chương",
            "Tính toán giá trị "});
            this.ChooseCal.Location = new System.Drawing.Point(231, 226);
            this.ChooseCal.Name = "ChooseCal";
            this.ChooseCal.Size = new System.Drawing.Size(293, 42);
            this.ChooseCal.TabIndex = 5;
            this.ChooseCal.SelectedIndexChanged += new System.EventHandler(this.ChooseCal_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(237, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(335, 38);
            this.label4.TabIndex = 6;
            this.label4.Text = "TÍNH TOÁN GIÁ TRỊ ";
            // 
            // ListNum
            // 
            this.ListNum.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListNum.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListNum.GridLines = true;
            this.ListNum.HideSelection = false;
            this.ListNum.Location = new System.Drawing.Point(134, 303);
            this.ListNum.Name = "ListNum";
            this.ListNum.Size = new System.Drawing.Size(631, 135);
            this.ListNum.TabIndex = 8;
            this.ListNum.UseCompatibleStateImageBehavior = false;
            this.ListNum.View = System.Windows.Forms.View.List;
            // 
            // Calcu
            // 
            this.Calcu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Calcu.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calcu.Location = new System.Drawing.Point(664, 80);
            this.Calcu.Name = "Calcu";
            this.Calcu.Size = new System.Drawing.Size(101, 45);
            this.Calcu.TabIndex = 9;
            this.Calcu.Text = "Tính";
            this.Calcu.UseVisualStyleBackColor = false;
            this.Calcu.Click += new System.EventHandler(this.Calcu_Click);
            // 
            // Del
            // 
            this.Del.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Del.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Del.Location = new System.Drawing.Point(664, 144);
            this.Del.Name = "Del";
            this.Del.Size = new System.Drawing.Size(101, 43);
            this.Del.TabIndex = 10;
            this.Del.Text = "Xóa";
            this.Del.UseVisualStyleBackColor = false;
            this.Del.Click += new System.EventHandler(this.Del_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Exit.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Location = new System.Drawing.Point(664, 215);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(101, 43);
            this.Exit.TabIndex = 11;
            this.Exit.Text = "Thoát";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Bai5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Del);
            this.Controls.Add(this.Calcu);
            this.Controls.Add(this.ListNum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ChooseCal);
            this.Controls.Add(this.InputB);
            this.Controls.Add(this.InputA);
            this.Controls.Add(this.Ans);
            this.Controls.Add(this.Inp);
            this.Controls.Add(this.InpB);
            this.Name = "Bai5";
            this.Text = "Bai5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label InpB;
        private System.Windows.Forms.Label Inp;
        private System.Windows.Forms.Label Ans;
        private System.Windows.Forms.TextBox InputA;
        private System.Windows.Forms.TextBox InputB;
        private System.Windows.Forms.ComboBox ChooseCal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView ListNum;
        private System.Windows.Forms.Button Calcu;
        private System.Windows.Forms.Button Del;
        private System.Windows.Forms.Button Exit;
    }
}