namespace Lab3
{
    partial class UDPServer
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
            this.listen = new System.Windows.Forms.Button();
            this.p = new System.Windows.Forms.Label();
            this.port = new System.Windows.Forms.TextBox();
            this.receivedmessages = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listen
            // 
            this.listen.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listen.Location = new System.Drawing.Point(585, 33);
            this.listen.Name = "listen";
            this.listen.Size = new System.Drawing.Size(132, 42);
            this.listen.TabIndex = 0;
            this.listen.Text = "Listen";
            this.listen.UseVisualStyleBackColor = true;
            this.listen.Click += new System.EventHandler(this.listen_Click);
            // 
            // p
            // 
            this.p.AutoSize = true;
            this.p.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p.Location = new System.Drawing.Point(71, 41);
            this.p.Name = "p";
            this.p.Size = new System.Drawing.Size(51, 26);
            this.p.TabIndex = 1;
            this.p.Text = "Port";
            // 
            // port
            // 
            this.port.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.port.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.port.Location = new System.Drawing.Point(128, 33);
            this.port.Name = "port";
            this.port.Size = new System.Drawing.Size(220, 34);
            this.port.TabIndex = 2;
            // 
            // receivedmessages
            // 
            this.receivedmessages.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receivedmessages.HideSelection = false;
            this.receivedmessages.Location = new System.Drawing.Point(76, 183);
            this.receivedmessages.Name = "receivedmessages";
            this.receivedmessages.Size = new System.Drawing.Size(641, 242);
            this.receivedmessages.TabIndex = 3;
            this.receivedmessages.UseCompatibleStateImageBehavior = false;
            this.receivedmessages.View = System.Windows.Forms.View.List;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(71, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "Received messages";
            // 
            // UDPServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.receivedmessages);
            this.Controls.Add(this.port);
            this.Controls.Add(this.p);
            this.Controls.Add(this.listen);
            this.Name = "UDPServer";
            this.Text = "UDPServer";
            this.Load += new System.EventHandler(this.UDPServer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button listen;
        private System.Windows.Forms.Label p;
        private System.Windows.Forms.TextBox port;
        private System.Windows.Forms.ListView receivedmessages;
        private System.Windows.Forms.Label label2;
    }
}