namespace Lab2
{
    partial class Bai6
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
            this.FindDish = new System.Windows.Forms.Button();
            this.DelDish = new System.Windows.Forms.Button();
            this.ExitProc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NameDish = new System.Windows.Forms.TextBox();
            this.NameProvider = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // FindDish
            // 
            this.FindDish.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.FindDish.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FindDish.Location = new System.Drawing.Point(421, 12);
            this.FindDish.Name = "FindDish";
            this.FindDish.Size = new System.Drawing.Size(167, 44);
            this.FindDish.TabIndex = 3;
            this.FindDish.Text = "Tìm món ăn";
            this.FindDish.UseVisualStyleBackColor = false;
            this.FindDish.Click += new System.EventHandler(this.FindDish_Click);
            // 
            // DelDish
            // 
            this.DelDish.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.DelDish.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DelDish.Location = new System.Drawing.Point(421, 101);
            this.DelDish.Name = "DelDish";
            this.DelDish.Size = new System.Drawing.Size(167, 44);
            this.DelDish.TabIndex = 4;
            this.DelDish.Text = "Xóa";
            this.DelDish.UseVisualStyleBackColor = false;
            this.DelDish.Click += new System.EventHandler(this.DelDish_Click);
            // 
            // ExitProc
            // 
            this.ExitProc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ExitProc.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitProc.Location = new System.Drawing.Point(421, 195);
            this.ExitProc.Name = "ExitProc";
            this.ExitProc.Size = new System.Drawing.Size(167, 44);
            this.ExitProc.TabIndex = 5;
            this.ExitProc.Text = "Thoát";
            this.ExitProc.UseVisualStyleBackColor = false;
            this.ExitProc.Click += new System.EventHandler(this.ExitProc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 322);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Món ăn hôm nay";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 387);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Người đóng góp món ăn";
            // 
            // NameDish
            // 
            this.NameDish.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NameDish.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameDish.Location = new System.Drawing.Point(248, 322);
            this.NameDish.Name = "NameDish";
            this.NameDish.Size = new System.Drawing.Size(395, 33);
            this.NameDish.TabIndex = 8;
            // 
            // NameProvider
            // 
            this.NameProvider.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NameProvider.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameProvider.Location = new System.Drawing.Point(248, 379);
            this.NameProvider.Name = "NameProvider";
            this.NameProvider.Size = new System.Drawing.Size(395, 33);
            this.NameProvider.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(274, 292);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Bai6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.NameProvider);
            this.Controls.Add(this.NameDish);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ExitProc);
            this.Controls.Add(this.DelDish);
            this.Controls.Add(this.FindDish);
            this.Name = "Bai6";
            this.Text = "Bai6";
            this.Load += new System.EventHandler(this.Bai6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button FindDish;
        private System.Windows.Forms.Button DelDish;
        private System.Windows.Forms.Button ExitProc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NameDish;
        private System.Windows.Forms.TextBox NameProvider;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}