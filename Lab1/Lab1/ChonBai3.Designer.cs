namespace Lab1
{
    partial class ChonBai3
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
            this.BasicLession = new System.Windows.Forms.Button();
            this.Advanced = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(66, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(674, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "CHỌN CÂU 3 CƠ BẢN HOẶC NÂNG CAO";
            // 
            // BasicLession
            // 
            this.BasicLession.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BasicLession.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BasicLession.Location = new System.Drawing.Point(333, 143);
            this.BasicLession.Name = "BasicLession";
            this.BasicLession.Size = new System.Drawing.Size(161, 74);
            this.BasicLession.TabIndex = 1;
            this.BasicLession.Text = "Cơ bản";
            this.BasicLession.UseVisualStyleBackColor = false;
            this.BasicLession.Click += new System.EventHandler(this.BasicLession_Click);
            // 
            // Advanced
            // 
            this.Advanced.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Advanced.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Advanced.Location = new System.Drawing.Point(333, 286);
            this.Advanced.Name = "Advanced";
            this.Advanced.Size = new System.Drawing.Size(161, 73);
            this.Advanced.TabIndex = 2;
            this.Advanced.Text = "Nâng cao";
            this.Advanced.UseVisualStyleBackColor = false;
            this.Advanced.Click += new System.EventHandler(this.Advanced_Click);
            // 
            // ChonBai3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Advanced);
            this.Controls.Add(this.BasicLession);
            this.Controls.Add(this.label1);
            this.Name = "ChonBai3";
            this.Text = "ChonBai3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BasicLession;
        private System.Windows.Forms.Button Advanced;
    }
}