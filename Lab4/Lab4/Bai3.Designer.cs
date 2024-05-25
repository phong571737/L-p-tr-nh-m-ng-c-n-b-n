namespace Lab4
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
            this.btLoad = new System.Windows.Forms.Button();
            this.btDFile = new System.Windows.Forms.Button();
            this.btReload = new System.Windows.Forms.Button();
            this.btDResources = new System.Windows.Forms.Button();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.wbContent = new Microsoft.Web.WebView2.WinForms.WebView2();
            ((System.ComponentModel.ISupportInitialize)(this.wbContent)).BeginInit();
            this.SuspendLayout();
            // 
            // btLoad
            // 
            this.btLoad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btLoad.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLoad.Location = new System.Drawing.Point(12, 12);
            this.btLoad.Name = "btLoad";
            this.btLoad.Size = new System.Drawing.Size(107, 33);
            this.btLoad.TabIndex = 0;
            this.btLoad.Text = "Load";
            this.btLoad.UseVisualStyleBackColor = false;
            this.btLoad.Click += new System.EventHandler(this.btLoad_Click);
            // 
            // btDFile
            // 
            this.btDFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btDFile.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDFile.Location = new System.Drawing.Point(473, 64);
            this.btDFile.Name = "btDFile";
            this.btDFile.Size = new System.Drawing.Size(107, 33);
            this.btDFile.TabIndex = 1;
            this.btDFile.Text = "Down File";
            this.btDFile.UseVisualStyleBackColor = false;
            this.btDFile.Click += new System.EventHandler(this.btDFile_Click);
            // 
            // btReload
            // 
            this.btReload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btReload.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btReload.Location = new System.Drawing.Point(681, 12);
            this.btReload.Name = "btReload";
            this.btReload.Size = new System.Drawing.Size(107, 33);
            this.btReload.TabIndex = 2;
            this.btReload.Text = "Reload";
            this.btReload.UseVisualStyleBackColor = false;
            this.btReload.Click += new System.EventHandler(this.btReload_Click);
            // 
            // btDResources
            // 
            this.btDResources.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btDResources.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDResources.Location = new System.Drawing.Point(609, 64);
            this.btDResources.Name = "btDResources";
            this.btDResources.Size = new System.Drawing.Size(179, 33);
            this.btDResources.TabIndex = 3;
            this.btDResources.Text = "Down Resources";
            this.btDResources.UseVisualStyleBackColor = false;
            this.btDResources.Click += new System.EventHandler(this.btDResources_Click);
            // 
            // txtURL
            // 
            this.txtURL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtURL.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtURL.Location = new System.Drawing.Point(139, 15);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(516, 30);
            this.txtURL.TabIndex = 4;
            this.txtURL.TextChanged += new System.EventHandler(this.txtURL_TextChanged);
            // 
            // wbContent
            // 
            this.wbContent.AllowExternalDrop = true;
            this.wbContent.CreationProperties = null;
            this.wbContent.DefaultBackgroundColor = System.Drawing.Color.White;
            this.wbContent.Location = new System.Drawing.Point(12, 108);
            this.wbContent.Name = "wbContent";
            this.wbContent.Size = new System.Drawing.Size(776, 330);
            this.wbContent.TabIndex = 5;
            this.wbContent.ZoomFactor = 1D;
            // 
            // Bai3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Lab4.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.wbContent);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.btDResources);
            this.Controls.Add(this.btReload);
            this.Controls.Add(this.btDFile);
            this.Controls.Add(this.btLoad);
            this.Name = "Bai3";
            this.Text = "Bai3";
            ((System.ComponentModel.ISupportInitialize)(this.wbContent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btLoad;
        private System.Windows.Forms.Button btDFile;
        private System.Windows.Forms.Button btReload;
        private System.Windows.Forms.Button btDResources;
        private System.Windows.Forms.TextBox txtURL;
        private Microsoft.Web.WebView2.WinForms.WebView2 wbContent;
    }
}