namespace Lab4
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
            this.tbURL = new System.Windows.Forms.TextBox();
            this.tbPhysical = new System.Windows.Forms.TextBox();
            this.btDownload = new System.Windows.Forms.Button();
            this.rtbContent = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // tbURL
            // 
            this.tbURL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbURL.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbURL.Location = new System.Drawing.Point(25, 30);
            this.tbURL.Name = "tbURL";
            this.tbURL.Size = new System.Drawing.Size(554, 30);
            this.tbURL.TabIndex = 0;
            // 
            // tbPhysical
            // 
            this.tbPhysical.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPhysical.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPhysical.Location = new System.Drawing.Point(25, 66);
            this.tbPhysical.Name = "tbPhysical";
            this.tbPhysical.Size = new System.Drawing.Size(554, 30);
            this.tbPhysical.TabIndex = 1;
            // 
            // btDownload
            // 
            this.btDownload.BackColor = System.Drawing.Color.Fuchsia;
            this.btDownload.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDownload.ForeColor = System.Drawing.Color.Black;
            this.btDownload.Location = new System.Drawing.Point(625, 30);
            this.btDownload.Name = "btDownload";
            this.btDownload.Size = new System.Drawing.Size(174, 60);
            this.btDownload.TabIndex = 2;
            this.btDownload.Text = "DownLoad";
            this.btDownload.UseVisualStyleBackColor = false;
            this.btDownload.Click += new System.EventHandler(this.btDownload_Click);
            // 
            // rtbContent
            // 
            this.rtbContent.Location = new System.Drawing.Point(25, 102);
            this.rtbContent.Name = "rtbContent";
            this.rtbContent.Size = new System.Drawing.Size(774, 347);
            this.rtbContent.TabIndex = 3;
            this.rtbContent.Text = "";
            // 
            // Bai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Lab4.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(827, 461);
            this.Controls.Add(this.rtbContent);
            this.Controls.Add(this.btDownload);
            this.Controls.Add(this.tbPhysical);
            this.Controls.Add(this.tbURL);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Name = "Bai2";
            this.Text = "Bai2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbURL;
        private System.Windows.Forms.TextBox tbPhysical;
        private System.Windows.Forms.Button btDownload;
        private System.Windows.Forms.RichTextBox rtbContent;
    }
}