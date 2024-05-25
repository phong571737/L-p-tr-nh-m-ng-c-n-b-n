namespace Lab3
{
    partial class TCPClient
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
            this.btconnect = new System.Windows.Forms.Button();
            this.btsend = new System.Windows.Forms.Button();
            this.btdisconnect = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.tbhost = new System.Windows.Forms.TextBox();
            this.tbport = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btconnect
            // 
            this.btconnect.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btconnect.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btconnect.Location = new System.Drawing.Point(622, 74);
            this.btconnect.Name = "btconnect";
            this.btconnect.Size = new System.Drawing.Size(130, 53);
            this.btconnect.TabIndex = 0;
            this.btconnect.Text = "Connect";
            this.btconnect.UseVisualStyleBackColor = false;
            // 
            // btsend
            // 
            this.btsend.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btsend.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsend.Location = new System.Drawing.Point(622, 171);
            this.btsend.Name = "btsend";
            this.btsend.Size = new System.Drawing.Size(130, 53);
            this.btsend.TabIndex = 1;
            this.btsend.Text = "Send";
            this.btsend.UseVisualStyleBackColor = false;
            this.btsend.Click += new System.EventHandler(this.btsend_Click);
            // 
            // btdisconnect
            // 
            this.btdisconnect.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btdisconnect.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btdisconnect.Location = new System.Drawing.Point(622, 254);
            this.btdisconnect.Name = "btdisconnect";
            this.btdisconnect.Size = new System.Drawing.Size(130, 53);
            this.btdisconnect.TabIndex = 2;
            this.btdisconnect.Text = "Disconnect";
            this.btdisconnect.UseVisualStyleBackColor = false;
            this.btdisconnect.Click += new System.EventHandler(this.btdisconnect_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox1.Location = new System.Drawing.Point(12, 74);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(555, 233);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // tbhost
            // 
            this.tbhost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbhost.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbhost.Location = new System.Drawing.Point(81, 22);
            this.tbhost.Name = "tbhost";
            this.tbhost.Size = new System.Drawing.Size(169, 30);
            this.tbhost.TabIndex = 4;
            this.tbhost.Text = "127.0.0.1";
            // 
            // tbport
            // 
            this.tbport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbport.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbport.Location = new System.Drawing.Point(415, 22);
            this.tbport.Name = "tbport";
            this.tbport.Size = new System.Drawing.Size(152, 30);
            this.tbport.TabIndex = 5;
            this.tbport.Text = "8080";
            this.tbport.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "Host";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(359, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "Port";
            // 
            // TCPClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 329);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbport);
            this.Controls.Add(this.tbhost);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btdisconnect);
            this.Controls.Add(this.btsend);
            this.Controls.Add(this.btconnect);
            this.Name = "TCPClient";
            this.Text = "TCPClient";
            this.Load += new System.EventHandler(this.TCPClient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btconnect;
        private System.Windows.Forms.Button btsend;
        private System.Windows.Forms.Button btdisconnect;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox tbhost;
        private System.Windows.Forms.TextBox tbport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}