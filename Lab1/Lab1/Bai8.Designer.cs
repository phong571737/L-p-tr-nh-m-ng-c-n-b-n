namespace Lab1
{
    partial class Bai8
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
            this.Label2 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.AddDish = new System.Windows.Forms.Button();
            this.FindDish = new System.Windows.Forms.Button();
            this.DelDish = new System.Windows.Forms.Button();
            this.ClsPro = new System.Windows.Forms.Button();
            this.OutDish = new System.Windows.Forms.TextBox();
            this.InpDish = new System.Windows.Forms.TextBox();
            this.listDishAdd = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(220, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "HÔM NAY ĂN GÌ?";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(23, 79);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(163, 33);
            this.Label2.TabIndex = 1;
            this.Label2.Text = "Nhập món ăn";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Label5.Location = new System.Drawing.Point(262, 295);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(202, 33);
            this.Label5.TabIndex = 2;
            this.Label5.Text = "Món ăn hôm nay";
            // 
            // AddDish
            // 
            this.AddDish.BackColor = System.Drawing.Color.Aqua;
            this.AddDish.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddDish.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.AddDish.Location = new System.Drawing.Point(267, 133);
            this.AddDish.Name = "AddDish";
            this.AddDish.Size = new System.Drawing.Size(104, 48);
            this.AddDish.TabIndex = 3;
            this.AddDish.Text = "Thêm";
            this.AddDish.UseVisualStyleBackColor = false;
            this.AddDish.Click += new System.EventHandler(this.AddDish_Click);
            // 
            // FindDish
            // 
            this.FindDish.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.FindDish.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FindDish.Location = new System.Drawing.Point(41, 232);
            this.FindDish.Name = "FindDish";
            this.FindDish.Size = new System.Drawing.Size(178, 42);
            this.FindDish.TabIndex = 4;
            this.FindDish.Text = "Tìm món ăn";
            this.FindDish.UseVisualStyleBackColor = false;
            this.FindDish.Click += new System.EventHandler(this.FindDish_Click);
            // 
            // DelDish
            // 
            this.DelDish.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.DelDish.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DelDish.Location = new System.Drawing.Point(294, 232);
            this.DelDish.Name = "DelDish";
            this.DelDish.Size = new System.Drawing.Size(114, 42);
            this.DelDish.TabIndex = 5;
            this.DelDish.Text = "Xóa";
            this.DelDish.UseVisualStyleBackColor = false;
            this.DelDish.Click += new System.EventHandler(this.DelDish_Click);
            // 
            // ClsPro
            // 
            this.ClsPro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClsPro.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClsPro.Location = new System.Drawing.Point(513, 232);
            this.ClsPro.Name = "ClsPro";
            this.ClsPro.Size = new System.Drawing.Size(129, 42);
            this.ClsPro.TabIndex = 6;
            this.ClsPro.Text = "Thoát";
            this.ClsPro.UseVisualStyleBackColor = false;
            this.ClsPro.Click += new System.EventHandler(this.ClsPro_Click);
            // 
            // OutDish
            // 
            this.OutDish.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OutDish.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutDish.Location = new System.Drawing.Point(99, 351);
            this.OutDish.Name = "OutDish";
            this.OutDish.Size = new System.Drawing.Size(482, 39);
            this.OutDish.TabIndex = 7;
            // 
            // InpDish
            // 
            this.InpDish.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InpDish.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InpDish.Location = new System.Drawing.Point(184, 73);
            this.InpDish.Name = "InpDish";
            this.InpDish.Size = new System.Drawing.Size(215, 34);
            this.InpDish.TabIndex = 8;
            this.InpDish.TextChanged += new System.EventHandler(this.InpDish_TextChanged);
            // 
            // listDishAdd
            // 
            this.listDishAdd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listDishAdd.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listDishAdd.FullRowSelect = true;
            this.listDishAdd.HideSelection = false;
            this.listDishAdd.Location = new System.Drawing.Point(405, 73);
            this.listDishAdd.Name = "listDishAdd";
            this.listDishAdd.ShowItemToolTips = true;
            this.listDishAdd.Size = new System.Drawing.Size(285, 141);
            this.listDishAdd.TabIndex = 9;
            this.listDishAdd.UseCompatibleStateImageBehavior = false;
            this.listDishAdd.SelectedIndexChanged += new System.EventHandler(this.listDishAdd_SelectedIndexChanged);
            // 
            // Bai8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 422);
            this.Controls.Add(this.listDishAdd);
            this.Controls.Add(this.InpDish);
            this.Controls.Add(this.OutDish);
            this.Controls.Add(this.ClsPro);
            this.Controls.Add(this.DelDish);
            this.Controls.Add(this.FindDish);
            this.Controls.Add(this.AddDish);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelpButton = true;
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Name = "Bai8";
            this.Text = "Bai8";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Label Label5;
        private System.Windows.Forms.Button AddDish;
        private System.Windows.Forms.Button FindDish;
        private System.Windows.Forms.Button DelDish;
        private System.Windows.Forms.Button ClsPro;
        private System.Windows.Forms.TextBox OutDish;
        private System.Windows.Forms.TextBox InpDish;
        private System.Windows.Forms.ListView listDishAdd;
    }
}