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
            this.btnAddShowTime = new System.Windows.Forms.Button();
            this.dgvShowtime = new System.Windows.Forms.DataGridView();
            this.Edit_Showtimes = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete_showtime = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tbnNhanVien = new System.Windows.Forms.Button();
            this.btnRoom = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.gbMovie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovie)).BeginInit();
            this.gbFastFood.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFood)).BeginInit();
            this.gbSuatChieu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowtime)).BeginInit();
            this.SuspendLayout();
            // 
            // HelloLable
            // 
            this.HelloLable.AutoSize = true;
            this.HelloLable.Font = new System.Drawing.Font("Mongolian Baiti", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelloLable.Location = new System.Drawing.Point(167, 9);
            this.HelloLable.Name = "HelloLable";
            this.HelloLable.Size = new System.Drawing.Size(660, 40);
            this.HelloLable.TabIndex = 0;
            this.HelloLable.Text = "Chào mừng đến nơi làm việc của Admin";
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
            this.gbMovie.Location = new System.Drawing.Point(12, 358);
            this.gbMovie.Name = "gbMovie";
            this.gbMovie.Size = new System.Drawing.Size(737, 315);
            this.gbMovie.TabIndex = 2;
            this.gbMovie.TabStop = false;
            this.gbMovie.Text = "Chỉnh sửa Phim";
            // 
            // btnMovieAdd
            // 
            this.btnMovieAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMovieAdd.Location = new System.Drawing.Point(622, 23);
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
            this.dgvMovie.Size = new System.Drawing.Size(725, 248);
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
            this.gbFastFood.Location = new System.Drawing.Point(755, 358);
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
            this.gbSuatChieu.Controls.Add(this.btnAddShowTime);
            this.gbSuatChieu.Controls.Add(this.dgvShowtime);
            this.gbSuatChieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSuatChieu.Location = new System.Drawing.Point(12, 74);
            this.gbSuatChieu.Name = "gbSuatChieu";
            this.gbSuatChieu.Size = new System.Drawing.Size(1151, 269);
            this.gbSuatChieu.TabIndex = 4;
            this.gbSuatChieu.TabStop = false;
            this.gbSuatChieu.Text = "Cài đặt suất chiếu";
            // 
            // btnAddShowTime
            // 
            this.btnAddShowTime.Location = new System.Drawing.Point(1033, 25);
            this.btnAddShowTime.Name = "btnAddShowTime";
            this.btnAddShowTime.Size = new System.Drawing.Size(109, 31);
            this.btnAddShowTime.TabIndex = 5;
            this.btnAddShowTime.Text = "Them";
            this.btnAddShowTime.UseVisualStyleBackColor = true;
            this.btnAddShowTime.Click += new System.EventHandler(this.btnAddShowTime_Click);
            // 
            // dgvShowtime
            // 
            this.dgvShowtime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvShowtime.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvShowtime.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowtime.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Edit_Showtimes,
            this.Delete_showtime});
            this.dgvShowtime.Location = new System.Drawing.Point(10, 62);
            this.dgvShowtime.Name = "dgvShowtime";
            this.dgvShowtime.Size = new System.Drawing.Size(1135, 201);
            this.dgvShowtime.TabIndex = 0;
            this.dgvShowtime.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvShowtime_CellClick);
            // 
            // Edit_Showtimes
            // 
            this.Edit_Showtimes.HeaderText = "";
            this.Edit_Showtimes.Name = "Edit_Showtimes";
            this.Edit_Showtimes.Text = "Edit";
            this.Edit_Showtimes.UseColumnTextForButtonValue = true;
            // 
            // Delete_showtime
            // 
            this.Delete_showtime.HeaderText = "";
            this.Delete_showtime.Name = "Delete_showtime";
            this.Delete_showtime.Text = "Delete";
            this.Delete_showtime.UseColumnTextForButtonValue = true;
            // 
            // tbnNhanVien
            // 
            this.tbnNhanVien.Location = new System.Drawing.Point(948, 37);
            this.tbnNhanVien.Name = "tbnNhanVien";
            this.tbnNhanVien.Size = new System.Drawing.Size(102, 31);
            this.tbnNhanVien.TabIndex = 5;
            this.tbnNhanVien.Text = "Nhân Viên";
            this.tbnNhanVien.UseVisualStyleBackColor = true;
            this.tbnNhanVien.Click += new System.EventHandler(this.tbnNhanVien_Click);
            // 
            // btnRoom
            // 
            this.btnRoom.Location = new System.Drawing.Point(1056, 37);
            this.btnRoom.Name = "btnRoom";
            this.btnRoom.Size = new System.Drawing.Size(102, 31);
            this.btnRoom.TabIndex = 5;
            this.btnRoom.Text = "Chỉnh số phòng";
            this.btnRoom.UseVisualStyleBackColor = true;
            this.btnRoom.Click += new System.EventHandler(this.btnRoom_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(12, 9);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Thoat";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 676);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRoom);
            this.Controls.Add(this.tbnNhanVien);
            this.Controls.Add(this.gbSuatChieu);
            this.Controls.Add(this.gbFastFood);
            this.Controls.Add(this.gbMovie);
            this.Controls.Add(this.HelloLable);
            this.Name = "FormAdmin";
            this.Text = "Admin";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Admin_FormClosed);
            this.Load += new System.EventHandler(this.Admin_Load);
            this.gbMovie.ResumeLayout(false);
            this.gbMovie.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovie)).EndInit();
            this.gbFastFood.ResumeLayout(false);
            this.gbFastFood.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFood)).EndInit();
            this.gbSuatChieu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowtime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HelloLable;
        private System.Windows.Forms.GroupBox gbMovie;
        private System.Windows.Forms.GroupBox gbFastFood;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.DataGridView dgvMovie;
        private System.Windows.Forms.DataGridView dgvFood;
        private System.Windows.Forms.Button btnMovieAdd;
        private System.Windows.Forms.Label lblMovieNow;
        private System.Windows.Forms.Button btnAddFood;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbSuatChieu;
        private System.Windows.Forms.DataGridView dgvShowtime;
        private System.Windows.Forms.Button tbnNhanVien;
        private System.Windows.Forms.DataGridViewButtonColumn Edit_Food;
        private System.Windows.Forms.DataGridViewButtonColumn Delete_Food;
        private System.Windows.Forms.DataGridViewButtonColumn Edit_Movie;
        private System.Windows.Forms.DataGridViewButtonColumn Delete_Movie;
        private System.Windows.Forms.Button btnRoom;
        private System.Windows.Forms.Button btnAddShowTime;
        private System.Windows.Forms.DataGridViewButtonColumn Edit_Showtimes;
        private System.Windows.Forms.DataGridViewButtonColumn Delete_showtime;
        private System.Windows.Forms.Button btnExit;
    }
}