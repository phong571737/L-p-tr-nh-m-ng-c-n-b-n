namespace Lab3
{
    partial class TCPServer
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbport = new System.Windows.Forms.TextBox();
            this.tbhost = new System.Windows.Forms.TextBox();
            this.btlisten = new System.Windows.Forms.Button();
            this.rtbReceived = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(362, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 22);
            this.label2.TabIndex = 11;
            this.label2.Text = "Port";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 22);
            this.label1.TabIndex = 10;
            this.label1.Text = "Host";
            // 
            // tbport
            // 
            this.tbport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbport.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbport.Location = new System.Drawing.Point(422, 29);
            this.tbport.Name = "tbport";
            this.tbport.Size = new System.Drawing.Size(152, 30);
            this.tbport.TabIndex = 9;
            this.tbport.Text = "8080";
            // 
            // tbhost
            // 
            this.tbhost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbhost.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbhost.Location = new System.Drawing.Point(86, 29);
            this.tbhost.Name = "tbhost";
            this.tbhost.Size = new System.Drawing.Size(169, 30);
            this.tbhost.TabIndex = 8;
            this.tbhost.Text = "127.0.0.1";
            // 
            // btlisten
            // 
            this.btlisten.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btlisten.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btlisten.Location = new System.Drawing.Point(658, 16);
            this.btlisten.Name = "btlisten";
            this.btlisten.Size = new System.Drawing.Size(130, 53);
            this.btlisten.TabIndex = 12;
            this.btlisten.Text = "Listen";
            this.btlisten.UseVisualStyleBackColor = false;
            this.btlisten.Click += new System.EventHandler(this.btlisten_Click);
            // 
            // rtbReceived
            // 
            this.rtbReceived.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbReceived.Location = new System.Drawing.Point(12, 94);
            this.rtbReceived.Name = "rtbReceived";
            this.rtbReceived.Size = new System.Drawing.Size(776, 324);
            this.rtbReceived.TabIndex = 13;
            this.rtbReceived.Text = "";
            // 
            // TCPServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtbReceived);
            this.Controls.Add(this.btlisten);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbport);
            this.Controls.Add(this.tbhost);
            this.Name = "TCPServer";
            this.Text = "TCPServer";
            this.Load += new System.EventHandler(this.TCPServer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbport;
        private System.Windows.Forms.TextBox tbhost;
        private System.Windows.Forms.Button btlisten;
        private System.Windows.Forms.RichTextBox rtbReceived;
    }
}