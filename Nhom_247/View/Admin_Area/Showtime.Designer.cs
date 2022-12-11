namespace Nhom_247.View.Admin_Area
{
    partial class Showtime
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.cbxRoom = new System.Windows.Forms.ComboBox();
            this.cbxMovie = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxID_Movie = new System.Windows.Forms.ComboBox();
            this.cbxID_Room = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxID_Showtime = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(440, 61);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(78, 26);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(142, 93);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(291, 20);
            this.dtpDate.TabIndex = 10;
            this.dtpDate.Value = new System.DateTime(2022, 9, 22, 8, 42, 41, 0);
            // 
            // dtp
            // 
            this.dtp.Location = new System.Drawing.Point(142, 61);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(291, 20);
            this.dtp.TabIndex = 11;
            this.dtp.Value = new System.DateTime(2022, 9, 22, 8, 42, 41, 0);
            // 
            // cbxRoom
            // 
            this.cbxRoom.FormattingEnabled = true;
            this.cbxRoom.Location = new System.Drawing.Point(142, 125);
            this.cbxRoom.Name = "cbxRoom";
            this.cbxRoom.Size = new System.Drawing.Size(291, 21);
            this.cbxRoom.TabIndex = 8;
            this.cbxRoom.SelectedIndexChanged += new System.EventHandler(this.cbxRoom_SelectedIndexChanged);
            // 
            // cbxMovie
            // 
            this.cbxMovie.FormattingEnabled = true;
            this.cbxMovie.Location = new System.Drawing.Point(142, 34);
            this.cbxMovie.Name = "cbxMovie";
            this.cbxMovie.Size = new System.Drawing.Size(291, 21);
            this.cbxMovie.TabIndex = 9;
            this.cbxMovie.SelectedIndexChanged += new System.EventHandler(this.cbxMovie_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Chọn ngày chiếu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Chọn Phòng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Chọn giờ chiếu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Chọn phim";
            // 
            // cbxID_Movie
            // 
            this.cbxID_Movie.FormattingEnabled = true;
            this.cbxID_Movie.Location = new System.Drawing.Point(441, 34);
            this.cbxID_Movie.Name = "cbxID_Movie";
            this.cbxID_Movie.Size = new System.Drawing.Size(63, 21);
            this.cbxID_Movie.TabIndex = 15;
            // 
            // cbxID_Room
            // 
            this.cbxID_Room.FormattingEnabled = true;
            this.cbxID_Room.Location = new System.Drawing.Point(441, 125);
            this.cbxID_Room.Name = "cbxID_Room";
            this.cbxID_Room.Size = new System.Drawing.Size(63, 21);
            this.cbxID_Room.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "ID";
            // 
            // tbxID_Showtime
            // 
            this.tbxID_Showtime.Location = new System.Drawing.Point(142, 7);
            this.tbxID_Showtime.Name = "tbxID_Showtime";
            this.tbxID_Showtime.Size = new System.Drawing.Size(100, 20);
            this.tbxID_Showtime.TabIndex = 17;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(441, 91);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(78, 26);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Showtime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 170);
            this.Controls.Add(this.tbxID_Showtime);
            this.Controls.Add(this.cbxID_Room);
            this.Controls.Add(this.cbxID_Movie);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.dtp);
            this.Controls.Add(this.cbxRoom);
            this.Controls.Add(this.cbxMovie);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Name = "Showtime";
            this.Text = "Showtime";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Showtime_FormClosed);
            this.Load += new System.EventHandler(this.Showtime_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.DateTimePicker dtp;
        private System.Windows.Forms.ComboBox cbxRoom;
        private System.Windows.Forms.ComboBox cbxMovie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxID_Movie;
        private System.Windows.Forms.ComboBox cbxID_Room;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxID_Showtime;
        private System.Windows.Forms.Button btnClear;
    }
}