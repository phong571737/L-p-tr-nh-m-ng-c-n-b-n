namespace Lab3
{
    partial class Dashboard
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
            this.UDPclient = new System.Windows.Forms.Button();
            this.UDPserver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UDPclient
            // 
            this.UDPclient.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UDPclient.Location = new System.Drawing.Point(37, 56);
            this.UDPclient.Name = "UDPclient";
            this.UDPclient.Size = new System.Drawing.Size(140, 52);
            this.UDPclient.TabIndex = 0;
            this.UDPclient.Text = "UDP Client";
            this.UDPclient.UseVisualStyleBackColor = true;
            this.UDPclient.Click += new System.EventHandler(this.UDPclient_Click);
            // 
            // UDPserver
            // 
            this.UDPserver.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UDPserver.Location = new System.Drawing.Point(286, 56);
            this.UDPserver.Name = "UDPserver";
            this.UDPserver.Size = new System.Drawing.Size(156, 52);
            this.UDPserver.TabIndex = 1;
            this.UDPserver.Text = "UDP Server";
            this.UDPserver.UseVisualStyleBackColor = true;
            this.UDPserver.Click += new System.EventHandler(this.UDPserver_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 162);
            this.Controls.Add(this.UDPserver);
            this.Controls.Add(this.UDPclient);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button UDPclient;
        private System.Windows.Forms.Button UDPserver;
    }
}