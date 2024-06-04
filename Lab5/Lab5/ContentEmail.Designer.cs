namespace Lab5
{
    partial class ContentEmail
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
            this.rtbMail = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rtbMail
            // 
            this.rtbMail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbMail.Location = new System.Drawing.Point(2, 2);
            this.rtbMail.Name = "rtbMail";
            this.rtbMail.Size = new System.Drawing.Size(789, 443);
            this.rtbMail.TabIndex = 0;
            this.rtbMail.Text = "";
            // 
            // ContentEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtbMail);
            this.Name = "ContentEmail";
            this.Text = "ContentEmail";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbMail;
    }
}