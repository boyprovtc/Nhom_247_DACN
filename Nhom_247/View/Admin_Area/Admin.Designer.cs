namespace Nhom_247
{
    partial class FormAdmin
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
            this.HelloLable = new System.Windows.Forms.Label();
            this.gbTicket = new System.Windows.Forms.GroupBox();
            this.btnNewTicketType = new System.Windows.Forms.Button();
            this.lbticketnow = new System.Windows.Forms.Label();
            this.dgvTicket = new System.Windows.Forms.DataGridView();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.gbMovie = new System.Windows.Forms.GroupBox();
            this.btnMovieAdd = new System.Windows.Forms.Button();
            this.lblMovieNow = new System.Windows.Forms.Label();
            this.dgvMovie = new System.Windows.Forms.DataGridView();
            this.Edit_Movie = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete_Movie = new System.Windows.Forms.DataGridViewButtonColumn();
            this.gbFastFood = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddFood = new System.Windows.Forms.Button();
            this.dgvFood = new System.Windows.Forms.DataGridView();
            this.Edit_Food = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete_Food = new System.Windows.Forms.DataGridViewButtonColumn();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.gbSuatChieu = new System.Windows.Forms.GroupBox();
            this.tbxID_Movie = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.cbxRoom = new System.Windows.Forms.ComboBox();
            this.cbxMovie = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvSuatChieu = new System.Windows.Forms.DataGridView();
            this.MovieName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Room = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbnNhanVien = new System.Windows.Forms.Button();
            this.btnRoom = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.gbTicket.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTicket)).BeginInit();
            this.gbMovie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovie)).BeginInit();
            this.gbFastFood.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFood)).BeginInit();
            this.gbSuatChieu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuatChieu)).BeginInit();
            this.SuspendLayout();
            // 
            // HelloLable
            // 
            this.HelloLable.AutoSize = true;
            this.HelloLable.Font = new System.Drawing.Font("Mongolian Baiti", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelloLable.Location = new System.Drawing.Point(470, 9);
            this.HelloLable.Name = "HelloLable";
            this.HelloLable.Size = new System.Drawing.Size(660, 40);
            this.HelloLable.TabIndex = 0;
            this.HelloLable.Text = "Chào mừng đến nơi làm việc của Admin";
            // 
            // gbTicket
            // 
            this.gbTicket.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gbTicket.Controls.Add(this.btnNewTicketType);
            this.gbTicket.Controls.Add(this.lbticketnow);
            this.gbTicket.Controls.Add(this.dgvTicket);
            this.gbTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTicket.Location = new System.Drawing.Point(12, 349);
            this.gbTicket.Name = "gbTicket";
            this.gbTicket.Size = new System.Drawing.Size(520, 315);
            this.gbTicket.TabIndex = 1;
            this.gbTicket.TabStop = false;
            this.gbTicket.Text = "Chỉnh sửa Vé và Dịch Vụ";
            // 
            // btnNewTicketType
            // 
            this.btnNewTicketType.Location = new System.Drawing.Point(405, 23);
            this.btnNewTicketType.Name = "btnNewTicketType";
            this.btnNewTicketType.Size = new System.Drawing.Size(109, 31);
            this.btnNewTicketType.TabIndex = 5;
            this.btnNewTicketType.Text = "Them";
            this.btnNewTicketType.UseVisualStyleBackColor = true;
            this.btnNewTicketType.Click += new System.EventHandler(this.btnNewTicketType_Click);
            // 
            // lbticketnow
            // 
            this.lbticketnow.AutoSize = true;
            this.lbticketnow.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbticketnow.Location = new System.Drawing.Point(9, 31);
            this.lbticketnow.Name = "lbticketnow";
            this.lbticketnow.Size = new System.Drawing.Size(143, 24);
            this.lbticketnow.TabIndex = 3;
            this.lbticketnow.Text = "Giá vé hiện tại";
            // 
            // dgvTicket
            // 
            this.dgvTicket.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTicket.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTicket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTicket.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Edit,
            this.Delete});
            this.dgvTicket.Location = new System.Drawing.Point(6, 60);
            this.dgvTicket.Name = "dgvTicket";
            this.dgvTicket.Size = new System.Drawing.Size(508, 249);
            this.dgvTicket.TabIndex = 2;
            this.dgvTicket.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTicket_CellClick);
            // 
            // Edit
            // 
            this.Edit.HeaderText = "";
            this.Edit.Name = "Edit";
            this.Edit.Text = "Edit";
            this.Edit.UseColumnTextForButtonValue = true;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "";
            this.Delete.Name = "Delete";
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // gbMovie
            // 
            this.gbMovie.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbMovie.Controls.Add(this.btnMovieAdd);
            this.gbMovie.Controls.Add(this.lblMovieNow);
            this.gbMovie.Controls.Add(this.dgvMovie);
            this.gbMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbMovie.Location = new System.Drawing.Point(538, 349);
            this.gbMovie.Name = "gbMovie";
            this.gbMovie.Size = new System.Drawing.Size(733, 315);
            this.gbMovie.TabIndex = 2;
            this.gbMovie.TabStop = false;
            this.gbMovie.Text = "Chỉnh sửa Phim";
            // 
            // btnMovieAdd
            // 
            this.btnMovieAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMovieAdd.Location = new System.Drawing.Point(618, 23);
            this.btnMovieAdd.Name = "btnMovieAdd";
            this.btnMovieAdd.Size = new System.Drawing.Size(109, 31);
            this.btnMovieAdd.TabIndex = 5;
            this.btnMovieAdd.Text = "Them";
            this.btnMovieAdd.UseVisualStyleBackColor = true;
            this.btnMovieAdd.Click += new System.EventHandler(this.btnMovieAdd_Click);
            // 
            // lblMovieNow
            // 
            this.lblMovieNow.AutoSize = true;
            this.lblMovieNow.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovieNow.Location = new System.Drawing.Point(6, 31);
            this.lblMovieNow.Name = "lblMovieNow";
            this.lblMovieNow.Size = new System.Drawing.Size(142, 24);
            this.lblMovieNow.TabIndex = 3;
            this.lblMovieNow.Text = "Phim Hiện Tại";
            // 
            // dgvMovie
            // 
            this.dgvMovie.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMovie.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMovie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMovie.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Edit_Movie,
            this.Delete_Movie});
            this.dgvMovie.Location = new System.Drawing.Point(6, 61);
            this.dgvMovie.Name = "dgvMovie";
            this.dgvMovie.Size = new System.Drawing.Size(728, 248);
            this.dgvMovie.TabIndex = 0;
            this.dgvMovie.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMovie_CellClick);
            // 
            // Edit_Movie
            // 
            this.Edit_Movie.HeaderText = "";
            this.Edit_Movie.Name = "Edit_Movie";
            this.Edit_Movie.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Edit_Movie.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Edit_Movie.Text = "Edit";
            this.Edit_Movie.UseColumnTextForButtonValue = true;
            // 
            // Delete_Movie
            // 
            this.Delete_Movie.HeaderText = "";
            this.Delete_Movie.Name = "Delete_Movie";
            this.Delete_Movie.Text = "Delete";
            this.Delete_Movie.UseColumnTextForButtonValue = true;
            // 
            // gbFastFood
            // 
            this.gbFastFood.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbFastFood.Controls.Add(this.label2);
            this.gbFastFood.Controls.Add(this.btnAddFood);
            this.gbFastFood.Controls.Add(this.dgvFood);
            this.gbFastFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFastFood.Location = new System.Drawing.Point(1277, 349);
            this.gbFastFood.Name = "gbFastFood";
            this.gbFastFood.Size = new System.Drawing.Size(408, 315);
            this.gbFastFood.TabIndex = 3;
            this.gbFastFood.TabStop = false;
            this.gbFastFood.Text = "Chỉnh sửa thức ăn nhanh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Thức ăn hiện tại";
            // 
            // btnAddFood
            // 
            this.btnAddFood.Location = new System.Drawing.Point(304, 23);
            this.btnAddFood.Name = "btnAddFood";
            this.btnAddFood.Size = new System.Drawing.Size(98, 31);
            this.btnAddFood.TabIndex = 5;
            this.btnAddFood.Text = "Them";
            this.btnAddFood.UseVisualStyleBackColor = true;
            this.btnAddFood.Click += new System.EventHandler(this.btnAddFood_Click);
            // 
            // dgvFood
            // 
            this.dgvFood.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFood.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFood.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Edit_Food,
            this.Delete_Food});
            this.dgvFood.Location = new System.Drawing.Point(6, 60);
            this.dgvFood.Name = "dgvFood";
            this.dgvFood.Size = new System.Drawing.Size(396, 249);
            this.dgvFood.TabIndex = 0;
            this.dgvFood.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFood_CellClick);
            // 
            // Edit_Food
            // 
            this.Edit_Food.HeaderText = "";
            this.Edit_Food.Name = "Edit_Food";
            this.Edit_Food.Text = "Edit";
            this.Edit_Food.UseColumnTextForButtonValue = true;
            // 
            // Delete_Food
            // 
            this.Delete_Food.HeaderText = "";
            this.Delete_Food.Name = "Delete_Food";
            this.Delete_Food.Text = "Delete";
            this.Delete_Food.UseColumnTextForButtonValue = true;
            // 
            // gbSuatChieu
            // 
            this.gbSuatChieu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbSuatChieu.Controls.Add(this.tbxID_Movie);
            this.gbSuatChieu.Controls.Add(this.btnAdd);
            this.gbSuatChieu.Controls.Add(this.dtpDate);
            this.gbSuatChieu.Controls.Add(this.dtp);
            this.gbSuatChieu.Controls.Add(this.cbxRoom);
            this.gbSuatChieu.Controls.Add(this.cbxMovie);
            this.gbSuatChieu.Controls.Add(this.label1);
            this.gbSuatChieu.Controls.Add(this.dgvSuatChieu);
            this.gbSuatChieu.Controls.Add(this.label4);
            this.gbSuatChieu.Controls.Add(this.label5);
            this.gbSuatChieu.Controls.Add(this.label3);
            this.gbSuatChieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSuatChieu.Location = new System.Drawing.Point(12, 74);
            this.gbSuatChieu.Name = "gbSuatChieu";
            this.gbSuatChieu.Size = new System.Drawing.Size(1673, 269);
            this.gbSuatChieu.TabIndex = 4;
            this.gbSuatChieu.TabStop = false;
            this.gbSuatChieu.Text = "Cài đặt suất chiếu";
            // 
            // tbxID_Movie
            // 
            this.tbxID_Movie.Location = new System.Drawing.Point(437, 39);
            this.tbxID_Movie.Name = "tbxID_Movie";
            this.tbxID_Movie.Size = new System.Drawing.Size(77, 26);
            this.tbxID_Movie.TabIndex = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(437, 88);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(33, 26);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(139, 120);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(291, 26);
            this.dtpDate.TabIndex = 2;
            this.dtpDate.Value = new System.DateTime(2022, 9, 22, 8, 42, 41, 0);
            // 
            // dtp
            // 
            this.dtp.Location = new System.Drawing.Point(139, 88);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(291, 26);
            this.dtp.TabIndex = 2;
            this.dtp.Value = new System.DateTime(2022, 9, 22, 8, 42, 41, 0);
            // 
            // cbxRoom
            // 
            this.cbxRoom.FormattingEnabled = true;
            this.cbxRoom.Location = new System.Drawing.Point(139, 152);
            this.cbxRoom.Name = "cbxRoom";
            this.cbxRoom.Size = new System.Drawing.Size(291, 28);
            this.cbxRoom.TabIndex = 1;
            // 
            // cbxMovie
            // 
            this.cbxMovie.FormattingEnabled = true;
            this.cbxMovie.Location = new System.Drawing.Point(139, 39);
            this.cbxMovie.Name = "cbxMovie";
            this.cbxMovie.Size = new System.Drawing.Size(291, 28);
            this.cbxMovie.TabIndex = 1;
            this.cbxMovie.SelectedIndexChanged += new System.EventHandler(this.cbxMovie_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chọn giờ chiếu";
            // 
            // dgvSuatChieu
            // 
            this.dgvSuatChieu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSuatChieu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSuatChieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSuatChieu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MovieName,
            this.Time,
            this.Date,
            this.Room});
            this.dgvSuatChieu.Location = new System.Drawing.Point(583, 11);
            this.dgvSuatChieu.Name = "dgvSuatChieu";
            this.dgvSuatChieu.Size = new System.Drawing.Size(1090, 252);
            this.dgvSuatChieu.TabIndex = 0;
            // 
            // MovieName
            // 
            this.MovieName.HeaderText = "";
            this.MovieName.Name = "MovieName";
            // 
            // Time
            // 
            this.Time.HeaderText = "";
            this.Time.Name = "Time";
            // 
            // Date
            // 
            this.Date.HeaderText = "";
            this.Date.Name = "Date";
            // 
            // Room
            // 
            this.Room.HeaderText = "";
            this.Room.Name = "Room";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Chọn Phòng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Chọn giờ chiếu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Chọn phim";
            // 
            // tbnNhanVien
            // 
            this.tbnNhanVien.Location = new System.Drawing.Point(1380, 37);
            this.tbnNhanVien.Name = "tbnNhanVien";
            this.tbnNhanVien.Size = new System.Drawing.Size(102, 31);
            this.tbnNhanVien.TabIndex = 5;
            this.tbnNhanVien.Text = "Nhân Viên";
            this.tbnNhanVien.UseVisualStyleBackColor = true;
            this.tbnNhanVien.Click += new System.EventHandler(this.tbnNhanVien_Click);
            // 
            // btnRoom
            // 
            this.btnRoom.Location = new System.Drawing.Point(1488, 37);
            this.btnRoom.Name = "btnRoom";
            this.btnRoom.Size = new System.Drawing.Size(102, 31);
            this.btnRoom.TabIndex = 5;
            this.btnRoom.Text = "Chỉnh số phòng";
            this.btnRoom.UseVisualStyleBackColor = true;
            this.btnRoom.Click += new System.EventHandler(this.btnRoom_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 31);
            this.button1.TabIndex = 5;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1687, 676);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnRoom);
            this.Controls.Add(this.tbnNhanVien);
            this.Controls.Add(this.gbSuatChieu);
            this.Controls.Add(this.gbFastFood);
            this.Controls.Add(this.gbMovie);
            this.Controls.Add(this.gbTicket);
            this.Controls.Add(this.HelloLable);
            this.Name = "FormAdmin";
            this.Text = "Admin";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Admin_FormClosed);
            this.Load += new System.EventHandler(this.Admin_Load);
            this.gbTicket.ResumeLayout(false);
            this.gbTicket.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTicket)).EndInit();
            this.gbMovie.ResumeLayout(false);
            this.gbMovie.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovie)).EndInit();
            this.gbFastFood.ResumeLayout(false);
            this.gbFastFood.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFood)).EndInit();
            this.gbSuatChieu.ResumeLayout(false);
            this.gbSuatChieu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuatChieu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HelloLable;
        private System.Windows.Forms.GroupBox gbTicket;
        private System.Windows.Forms.GroupBox gbMovie;
        private System.Windows.Forms.GroupBox gbFastFood;
        private System.Windows.Forms.Label lbticketnow;
        private System.Windows.Forms.DataGridView dgvTicket;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.DataGridView dgvMovie;
        private System.Windows.Forms.DataGridView dgvFood;
        private System.Windows.Forms.Button btnMovieAdd;
        private System.Windows.Forms.Label lblMovieNow;
        private System.Windows.Forms.Button btnAddFood;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbSuatChieu;
        private System.Windows.Forms.DataGridView dgvSuatChieu;
        private System.Windows.Forms.ComboBox cbxMovie;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DateTimePicker dtp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button tbnNhanVien;
        private System.Windows.Forms.Button btnNewTicketType;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.DataGridViewButtonColumn Edit_Food;
        private System.Windows.Forms.DataGridViewButtonColumn Delete_Food;
        private System.Windows.Forms.DataGridViewButtonColumn Edit_Movie;
        private System.Windows.Forms.DataGridViewButtonColumn Delete_Movie;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.ComboBox cbxRoom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRoom;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbxID_Movie;
        private System.Windows.Forms.DataGridViewTextBoxColumn MovieName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Room;
    }
}