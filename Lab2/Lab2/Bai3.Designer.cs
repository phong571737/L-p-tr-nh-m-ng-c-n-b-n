namespace Lab2
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
            this.label1 = new System.Windows.Forms.Label();
            this.RFile = new System.Windows.Forms.Button();
            this.WFile = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(125, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(547, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "ĐỌC VÀ GHI FILE VÀ TÍNH TOÁN";
            // 
            // RFile
            // 
            this.RFile.BackColor = System.Drawing.Color.Lime;
            this.RFile.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RFile.Location = new System.Drawing.Point(45, 117);
            this.RFile.Name = "RFile";
            this.RFile.Size = new System.Drawing.Size(181, 86);
            this.RFile.TabIndex = 1;
            this.RFile.Text = "Đọc file";
            this.RFile.UseVisualStyleBackColor = false;
            this.RFile.Click += new System.EventHandler(this.RFile_Click);
            // 
            // WFile
            // 
            this.WFile.BackColor = System.Drawing.Color.Lime;
            this.WFile.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WFile.Location = new System.Drawing.Point(45, 271);
            this.WFile.Name = "WFile";
            this.WFile.Size = new System.Drawing.Size(181, 92);
            this.WFile.TabIndex = 2;
            this.WFile.Text = "Ghi File";
            this.WFile.UseVisualStyleBackColor = false;
            this.WFile.Click += new System.EventHandler(this.WFile_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(293, 117);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(468, 246);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // Bai3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.WFile);
            this.Controls.Add(this.RFile);
            this.Controls.Add(this.label1);
            this.Name = "Bai3";
            this.Text = "Bai3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button RFile;
        private System.Windows.Forms.Button WFile;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}