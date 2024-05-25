namespace Lab2
{
    partial class Bai5
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
            this.Pay = new System.Windows.Forms.Button();
            this.comboBoxMovie = new System.Windows.Forms.ComboBox();
            this.checkedListBoxSeat = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxTicket = new System.Windows.Forms.ComboBox();
            this.WName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.RName = new System.Windows.Forms.TextBox();
            this.Ticket = new System.Windows.Forms.TextBox();
            this.SumPay = new System.Windows.Forms.TextBox();
            this.RMovie = new System.Windows.Forms.TextBox();
            this.RoomMovie = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Pay
            // 
            this.Pay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Pay.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pay.Location = new System.Drawing.Point(591, 22);
            this.Pay.Name = "Pay";
            this.Pay.Size = new System.Drawing.Size(176, 45);
            this.Pay.TabIndex = 0;
            this.Pay.Text = "Thanh toán";
            this.Pay.UseVisualStyleBackColor = false;
            this.Pay.Click += new System.EventHandler(this.Pay_Click);
            // 
            // comboBoxMovie
            // 
            this.comboBoxMovie.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxMovie.FormattingEnabled = true;
            this.comboBoxMovie.Location = new System.Drawing.Point(35, 130);
            this.comboBoxMovie.Name = "comboBoxMovie";
            this.comboBoxMovie.Size = new System.Drawing.Size(175, 33);
            this.comboBoxMovie.TabIndex = 1;
            this.comboBoxMovie.SelectedIndexChanged += new System.EventHandler(this.comboBoxMovie_SelectedIndexChanged);
            // 
            // checkedListBoxSeat
            // 
            this.checkedListBoxSeat.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBoxSeat.FormattingEnabled = true;
            this.checkedListBoxSeat.Location = new System.Drawing.Point(591, 131);
            this.checkedListBoxSeat.Name = "checkedListBoxSeat";
            this.checkedListBoxSeat.Size = new System.Drawing.Size(176, 32);
            this.checkedListBoxSeat.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Họ tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(325, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Chọn loại vé";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(66, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Chọn phim";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(605, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Chọn ghế ngồi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(304, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(220, 33);
            this.label5.TabIndex = 7;
            this.label5.Text = "Thông tin hóa đơn";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(34, 349);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "Loại vé";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(30, 298);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 25);
            this.label7.TabIndex = 9;
            this.label7.Text = "Tên phim";
            // 
            // comboBoxTicket
            // 
            this.comboBoxTicket.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTicket.FormattingEnabled = true;
            this.comboBoxTicket.Location = new System.Drawing.Point(286, 130);
            this.comboBoxTicket.Name = "comboBoxTicket";
            this.comboBoxTicket.Size = new System.Drawing.Size(188, 33);
            this.comboBoxTicket.TabIndex = 10;
            // 
            // WName
            // 
            this.WName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WName.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WName.Location = new System.Drawing.Point(164, 24);
            this.WName.Name = "WName";
            this.WName.Size = new System.Drawing.Size(297, 33);
            this.WName.TabIndex = 11;
            this.WName.TextChanged += new System.EventHandler(this.WName_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(30, 248);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 25);
            this.label8.TabIndex = 12;
            this.label8.Text = "Họ tên";
            // 
            // RName
            // 
            this.RName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RName.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RName.Location = new System.Drawing.Point(136, 240);
            this.RName.Name = "RName";
            this.RName.Size = new System.Drawing.Size(297, 33);
            this.RName.TabIndex = 13;
            // 
            // Ticket
            // 
            this.Ticket.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Ticket.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ticket.Location = new System.Drawing.Point(136, 341);
            this.Ticket.Name = "Ticket";
            this.Ticket.Size = new System.Drawing.Size(175, 33);
            this.Ticket.TabIndex = 14;
            // 
            // SumPay
            // 
            this.SumPay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SumPay.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SumPay.Location = new System.Drawing.Point(286, 397);
            this.SumPay.Name = "SumPay";
            this.SumPay.Size = new System.Drawing.Size(297, 33);
            this.SumPay.TabIndex = 15;
            // 
            // RMovie
            // 
            this.RMovie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RMovie.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RMovie.Location = new System.Drawing.Point(136, 290);
            this.RMovie.Name = "RMovie";
            this.RMovie.Size = new System.Drawing.Size(297, 33);
            this.RMovie.TabIndex = 16;
            // 
            // RoomMovie
            // 
            this.RoomMovie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RoomMovie.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomMovie.Location = new System.Drawing.Point(570, 341);
            this.RoomMovie.Name = "RoomMovie";
            this.RoomMovie.Size = new System.Drawing.Size(127, 33);
            this.RoomMovie.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(406, 349);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 25);
            this.label9.TabIndex = 18;
            this.label9.Text = "Phòng chiếu";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(34, 405);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(216, 25);
            this.label10.TabIndex = 19;
            this.label10.Text = "Tổng số tiến thanh toán";
            // 
            // Bai5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.RoomMovie);
            this.Controls.Add(this.RMovie);
            this.Controls.Add(this.SumPay);
            this.Controls.Add(this.Ticket);
            this.Controls.Add(this.RName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.WName);
            this.Controls.Add(this.comboBoxTicket);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkedListBoxSeat);
            this.Controls.Add(this.comboBoxMovie);
            this.Controls.Add(this.Pay);
            this.Name = "Bai5";
            this.Text = "Bai5";
            this.Load += new System.EventHandler(this.Bai5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Pay;
        private System.Windows.Forms.ComboBox comboBoxMovie;
        private System.Windows.Forms.CheckedListBox checkedListBoxSeat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxTicket;
        private System.Windows.Forms.TextBox WName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox RName;
        private System.Windows.Forms.TextBox Ticket;
        private System.Windows.Forms.TextBox SumPay;
        private System.Windows.Forms.TextBox RMovie;
        private System.Windows.Forms.TextBox RoomMovie;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}