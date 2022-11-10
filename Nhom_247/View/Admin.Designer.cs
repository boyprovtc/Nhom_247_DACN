namespace Nhom_247
{
    partial class Admin
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
            this.btnDeleteTicket = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnTicketAdd = new System.Windows.Forms.Button();
            this.lbticketnow = new System.Windows.Forms.Label();
            this.dgvTicket = new System.Windows.Forms.DataGridView();
            this.tbxDiscount = new System.Windows.Forms.TextBox();
            this.tbxService = new System.Windows.Forms.TextBox();
            this.tbxticketprice = new System.Windows.Forms.TextBox();
            this.tbxtickettype = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblService = new System.Windows.Forms.Label();
            this.lbpremium = new System.Windows.Forms.Label();
            this.lbticket = new System.Windows.Forms.Label();
            this.gbMovie = new System.Windows.Forms.GroupBox();
            this.btnImage = new System.Windows.Forms.Button();
            this.btnDeleteMovie = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lblMovieNow = new System.Windows.Forms.Label();
            this.btn_addMovie = new System.Windows.Forms.Button();
            this.dgvMovie = new System.Windows.Forms.DataGridView();
            this.tbxImage = new System.Windows.Forms.TextBox();
            this.tbxMovieName = new System.Windows.Forms.TextBox();
            this.lblMovieName = new System.Windows.Forms.Label();
            this.lblImage = new System.Windows.Forms.Label();
            this.lblKind = new System.Windows.Forms.Label();
            this.lblDicribe = new System.Windows.Forms.Label();
            this.tbxMovieAbout = new System.Windows.Forms.TextBox();
            this.gbFastFood = new System.Windows.Forms.GroupBox();
            this.tbxFoodPrice = new System.Windows.Forms.TextBox();
            this.btnFood_add = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxFoodName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.DeleteFood = new System.Windows.Forms.Button();
            this.dgvFood = new System.Windows.Forms.DataGridView();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.gbSuatChieu = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dgvSuatChieu = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
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
            this.gbTicket.Controls.Add(this.btnDeleteTicket);
            this.gbTicket.Controls.Add(this.btnCancel);
            this.gbTicket.Controls.Add(this.btnTicketAdd);
            this.gbTicket.Controls.Add(this.lbticketnow);
            this.gbTicket.Controls.Add(this.dgvTicket);
            this.gbTicket.Controls.Add(this.tbxDiscount);
            this.gbTicket.Controls.Add(this.tbxService);
            this.gbTicket.Controls.Add(this.tbxticketprice);
            this.gbTicket.Controls.Add(this.tbxtickettype);
            this.gbTicket.Controls.Add(this.label1);
            this.gbTicket.Controls.Add(this.lblDiscount);
            this.gbTicket.Controls.Add(this.lblService);
            this.gbTicket.Controls.Add(this.lbpremium);
            this.gbTicket.Controls.Add(this.lbticket);
            this.gbTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTicket.Location = new System.Drawing.Point(12, 349);
            this.gbTicket.Name = "gbTicket";
            this.gbTicket.Size = new System.Drawing.Size(520, 315);
            this.gbTicket.TabIndex = 1;
            this.gbTicket.TabStop = false;
            this.gbTicket.Text = "Chỉnh sửa Vé và Dịch Vụ";
            // 
            // btnDeleteTicket
            // 
            this.btnDeleteTicket.Location = new System.Drawing.Point(405, 203);
            this.btnDeleteTicket.Name = "btnDeleteTicket";
            this.btnDeleteTicket.Size = new System.Drawing.Size(109, 31);
            this.btnDeleteTicket.TabIndex = 5;
            this.btnDeleteTicket.Text = "Xóa";
            this.btnDeleteTicket.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(405, 64);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 26);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnTicketAdd
            // 
            this.btnTicketAdd.Location = new System.Drawing.Point(405, 31);
            this.btnTicketAdd.Name = "btnTicketAdd";
            this.btnTicketAdd.Size = new System.Drawing.Size(110, 27);
            this.btnTicketAdd.TabIndex = 4;
            this.btnTicketAdd.Text = "Save";
            this.btnTicketAdd.UseVisualStyleBackColor = true;
            this.btnTicketAdd.Click += new System.EventHandler(this.btnTicketAdd_Click);
            // 
            // lbticketnow
            // 
            this.lbticketnow.AutoSize = true;
            this.lbticketnow.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbticketnow.Location = new System.Drawing.Point(6, 205);
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
            this.dgvTicket.Location = new System.Drawing.Point(6, 236);
            this.dgvTicket.Name = "dgvTicket";
            this.dgvTicket.Size = new System.Drawing.Size(508, 73);
            this.dgvTicket.TabIndex = 2;
            // 
            // tbxDiscount
            // 
            this.tbxDiscount.Location = new System.Drawing.Point(159, 133);
            this.tbxDiscount.Name = "tbxDiscount";
            this.tbxDiscount.Size = new System.Drawing.Size(132, 24);
            this.tbxDiscount.TabIndex = 1;
            // 
            // tbxService
            // 
            this.tbxService.Location = new System.Drawing.Point(159, 98);
            this.tbxService.Name = "tbxService";
            this.tbxService.Size = new System.Drawing.Size(219, 24);
            this.tbxService.TabIndex = 1;
            // 
            // tbxticketprice
            // 
            this.tbxticketprice.Location = new System.Drawing.Point(159, 64);
            this.tbxticketprice.Name = "tbxticketprice";
            this.tbxticketprice.Size = new System.Drawing.Size(219, 24);
            this.tbxticketprice.TabIndex = 1;
            // 
            // tbxtickettype
            // 
            this.tbxtickettype.Location = new System.Drawing.Point(159, 34);
            this.tbxtickettype.Name = "tbxtickettype";
            this.tbxtickettype.Size = new System.Drawing.Size(219, 24);
            this.tbxtickettype.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(297, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "VNĐ";
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Location = new System.Drawing.Point(7, 139);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(75, 18);
            this.lblDiscount.TabIndex = 0;
            this.lblDiscount.Text = "Giảm giá";
            // 
            // lblService
            // 
            this.lblService.AutoSize = true;
            this.lblService.Location = new System.Drawing.Point(8, 104);
            this.lblService.Name = "lblService";
            this.lblService.Size = new System.Drawing.Size(95, 18);
            this.lblService.TabIndex = 0;
            this.lblService.Text = "Khuyến mãi";
            // 
            // lbpremium
            // 
            this.lbpremium.AutoSize = true;
            this.lbpremium.Location = new System.Drawing.Point(7, 72);
            this.lbpremium.Name = "lbpremium";
            this.lbpremium.Size = new System.Drawing.Size(56, 18);
            this.lbpremium.TabIndex = 0;
            this.lbpremium.Text = "Giá vé";
            // 
            // lbticket
            // 
            this.lbticket.AutoSize = true;
            this.lbticket.Location = new System.Drawing.Point(7, 37);
            this.lbticket.Name = "lbticket";
            this.lbticket.Size = new System.Drawing.Size(64, 18);
            this.lbticket.TabIndex = 0;
            this.lbticket.Text = "Loại Vé";
            // 
            // gbMovie
            // 
            this.gbMovie.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbMovie.Controls.Add(this.btnImage);
            this.gbMovie.Controls.Add(this.btnDeleteMovie);
            this.gbMovie.Controls.Add(this.button3);
            this.gbMovie.Controls.Add(this.lblMovieNow);
            this.gbMovie.Controls.Add(this.btn_addMovie);
            this.gbMovie.Controls.Add(this.dgvMovie);
            this.gbMovie.Controls.Add(this.tbxImage);
            this.gbMovie.Controls.Add(this.tbxMovieName);
            this.gbMovie.Controls.Add(this.lblMovieName);
            this.gbMovie.Controls.Add(this.lblImage);
            this.gbMovie.Controls.Add(this.lblKind);
            this.gbMovie.Controls.Add(this.lblDicribe);
            this.gbMovie.Controls.Add(this.tbxMovieAbout);
            this.gbMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbMovie.Location = new System.Drawing.Point(538, 349);
            this.gbMovie.Name = "gbMovie";
            this.gbMovie.Size = new System.Drawing.Size(656, 315);
            this.gbMovie.TabIndex = 2;
            this.gbMovie.TabStop = false;
            this.gbMovie.Text = "Chỉnh sửa Phim";
            // 
            // btnImage
            // 
            this.btnImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImage.Location = new System.Drawing.Point(541, 162);
            this.btnImage.Name = "btnImage";
            this.btnImage.Size = new System.Drawing.Size(109, 30);
            this.btnImage.TabIndex = 6;
            this.btnImage.Text = "Chọn hình";
            this.btnImage.UseVisualStyleBackColor = true;
            // 
            // btnDeleteMovie
            // 
            this.btnDeleteMovie.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteMovie.Location = new System.Drawing.Point(541, 198);
            this.btnDeleteMovie.Name = "btnDeleteMovie";
            this.btnDeleteMovie.Size = new System.Drawing.Size(109, 31);
            this.btnDeleteMovie.TabIndex = 5;
            this.btnDeleteMovie.Text = "Xóa";
            this.btnDeleteMovie.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(548, 64);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(102, 26);
            this.button3.TabIndex = 4;
            this.button3.Text = "Hủy";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // lblMovieNow
            // 
            this.lblMovieNow.AutoSize = true;
            this.lblMovieNow.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovieNow.Location = new System.Drawing.Point(6, 206);
            this.lblMovieNow.Name = "lblMovieNow";
            this.lblMovieNow.Size = new System.Drawing.Size(142, 24);
            this.lblMovieNow.TabIndex = 3;
            this.lblMovieNow.Text = "Phim Hiện Tại";
            // 
            // btn_addMovie
            // 
            this.btn_addMovie.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_addMovie.Location = new System.Drawing.Point(548, 31);
            this.btn_addMovie.Name = "btn_addMovie";
            this.btn_addMovie.Size = new System.Drawing.Size(102, 27);
            this.btn_addMovie.TabIndex = 4;
            this.btn_addMovie.Text = "Save";
            this.btn_addMovie.UseVisualStyleBackColor = true;
            this.btn_addMovie.Click += new System.EventHandler(this.btn_addMovie_Click);
            // 
            // dgvMovie
            // 
            this.dgvMovie.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMovie.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMovie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMovie.Location = new System.Drawing.Point(6, 236);
            this.dgvMovie.Name = "dgvMovie";
            this.dgvMovie.Size = new System.Drawing.Size(651, 73);
            this.dgvMovie.TabIndex = 0;
            // 
            // tbxImage
            // 
            this.tbxImage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxImage.Location = new System.Drawing.Point(159, 165);
            this.tbxImage.Name = "tbxImage";
            this.tbxImage.Size = new System.Drawing.Size(363, 24);
            this.tbxImage.TabIndex = 1;
            // 
            // tbxMovieName
            // 
            this.tbxMovieName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxMovieName.Location = new System.Drawing.Point(159, 31);
            this.tbxMovieName.Name = "tbxMovieName";
            this.tbxMovieName.Size = new System.Drawing.Size(363, 24);
            this.tbxMovieName.TabIndex = 1;
            // 
            // lblMovieName
            // 
            this.lblMovieName.AutoSize = true;
            this.lblMovieName.Location = new System.Drawing.Point(7, 34);
            this.lblMovieName.Name = "lblMovieName";
            this.lblMovieName.Size = new System.Drawing.Size(79, 18);
            this.lblMovieName.TabIndex = 0;
            this.lblMovieName.Text = "Tên Phim";
            // 
            // lblImage
            // 
            this.lblImage.AutoSize = true;
            this.lblImage.Location = new System.Drawing.Point(7, 168);
            this.lblImage.Name = "lblImage";
            this.lblImage.Size = new System.Drawing.Size(142, 18);
            this.lblImage.TabIndex = 0;
            this.lblImage.Text = "Đường dẫn poster";
            // 
            // lblKind
            // 
            this.lblKind.AutoSize = true;
            this.lblKind.Location = new System.Drawing.Point(7, 139);
            this.lblKind.Name = "lblKind";
            this.lblKind.Size = new System.Drawing.Size(109, 18);
            this.lblKind.TabIndex = 0;
            this.lblKind.Text = "Thể loại phim";
            // 
            // lblDicribe
            // 
            this.lblDicribe.AutoSize = true;
            this.lblDicribe.Location = new System.Drawing.Point(7, 69);
            this.lblDicribe.Name = "lblDicribe";
            this.lblDicribe.Size = new System.Drawing.Size(121, 18);
            this.lblDicribe.TabIndex = 0;
            this.lblDicribe.Text = "Giới thiệu phim";
            // 
            // tbxMovieAbout
            // 
            this.tbxMovieAbout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxMovieAbout.Location = new System.Drawing.Point(159, 66);
            this.tbxMovieAbout.Multiline = true;
            this.tbxMovieAbout.Name = "tbxMovieAbout";
            this.tbxMovieAbout.Size = new System.Drawing.Size(363, 65);
            this.tbxMovieAbout.TabIndex = 1;
            // 
            // gbFastFood
            // 
            this.gbFastFood.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbFastFood.Controls.Add(this.tbxFoodPrice);
            this.gbFastFood.Controls.Add(this.btnFood_add);
            this.gbFastFood.Controls.Add(this.button4);
            this.gbFastFood.Controls.Add(this.label2);
            this.gbFastFood.Controls.Add(this.tbxFoodName);
            this.gbFastFood.Controls.Add(this.label4);
            this.gbFastFood.Controls.Add(this.label6);
            this.gbFastFood.Controls.Add(this.DeleteFood);
            this.gbFastFood.Controls.Add(this.dgvFood);
            this.gbFastFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFastFood.Location = new System.Drawing.Point(1200, 349);
            this.gbFastFood.Name = "gbFastFood";
            this.gbFastFood.Size = new System.Drawing.Size(408, 315);
            this.gbFastFood.TabIndex = 3;
            this.gbFastFood.TabStop = false;
            this.gbFastFood.Text = "Chỉnh sửa thức ăn nhanh";
            // 
            // tbxFoodPrice
            // 
            this.tbxFoodPrice.Location = new System.Drawing.Point(158, 96);
            this.tbxFoodPrice.Name = "tbxFoodPrice";
            this.tbxFoodPrice.Size = new System.Drawing.Size(128, 24);
            this.tbxFoodPrice.TabIndex = 12;
            // 
            // btnFood_add
            // 
            this.btnFood_add.Location = new System.Drawing.Point(304, 31);
            this.btnFood_add.Name = "btnFood_add";
            this.btnFood_add.Size = new System.Drawing.Size(94, 27);
            this.btnFood_add.TabIndex = 4;
            this.btnFood_add.Text = "Save";
            this.btnFood_add.UseVisualStyleBackColor = true;
            this.btnFood_add.Click += new System.EventHandler(this.btnFood_add_Click);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Location = new System.Drawing.Point(304, 69);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(94, 26);
            this.button4.TabIndex = 4;
            this.button4.Text = "Hủy";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Thức ăn hiện tại";
            // 
            // tbxFoodName
            // 
            this.tbxFoodName.Location = new System.Drawing.Point(158, 32);
            this.tbxFoodName.Name = "tbxFoodName";
            this.tbxFoodName.Size = new System.Drawing.Size(128, 24);
            this.tbxFoodName.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Giá";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "Tên thức ăn";
            // 
            // DeleteFood
            // 
            this.DeleteFood.Location = new System.Drawing.Point(304, 199);
            this.DeleteFood.Name = "DeleteFood";
            this.DeleteFood.Size = new System.Drawing.Size(98, 31);
            this.DeleteFood.TabIndex = 5;
            this.DeleteFood.Text = "Xóa";
            this.DeleteFood.UseVisualStyleBackColor = true;
            // 
            // dgvFood
            // 
            this.dgvFood.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFood.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFood.Location = new System.Drawing.Point(6, 236);
            this.dgvFood.Name = "dgvFood";
            this.dgvFood.Size = new System.Drawing.Size(396, 73);
            this.dgvFood.TabIndex = 0;
            // 
            // gbSuatChieu
            // 
            this.gbSuatChieu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbSuatChieu.Controls.Add(this.btnAdd);
            this.gbSuatChieu.Controls.Add(this.dtp);
            this.gbSuatChieu.Controls.Add(this.comboBox1);
            this.gbSuatChieu.Controls.Add(this.dgvSuatChieu);
            this.gbSuatChieu.Controls.Add(this.label5);
            this.gbSuatChieu.Controls.Add(this.label3);
            this.gbSuatChieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSuatChieu.Location = new System.Drawing.Point(12, 74);
            this.gbSuatChieu.Name = "gbSuatChieu";
            this.gbSuatChieu.Size = new System.Drawing.Size(1596, 269);
            this.gbSuatChieu.TabIndex = 4;
            this.gbSuatChieu.TabStop = false;
            this.gbSuatChieu.Text = "Cài đặt suất chiếu";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(437, 88);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(33, 26);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // dtp
            // 
            this.dtp.Location = new System.Drawing.Point(139, 88);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(291, 26);
            this.dtp.TabIndex = 2;
            this.dtp.Value = new System.DateTime(2022, 9, 22, 8, 42, 41, 0);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(139, 39);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(291, 28);
            this.comboBox1.TabIndex = 1;
            // 
            // dgvSuatChieu
            // 
            this.dgvSuatChieu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSuatChieu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSuatChieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSuatChieu.Location = new System.Drawing.Point(583, 11);
            this.dgvSuatChieu.Name = "dgvSuatChieu";
            this.dgvSuatChieu.Size = new System.Drawing.Size(1013, 252);
            this.dgvSuatChieu.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 88);
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
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1610, 676);
            this.Controls.Add(this.gbSuatChieu);
            this.Controls.Add(this.gbFastFood);
            this.Controls.Add(this.gbMovie);
            this.Controls.Add(this.gbTicket);
            this.Controls.Add(this.HelloLable);
            this.Name = "Admin";
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
        private System.Windows.Forms.TextBox tbxticketprice;
        private System.Windows.Forms.TextBox tbxtickettype;
        private System.Windows.Forms.Label lbpremium;
        private System.Windows.Forms.Label lbticket;
        private System.Windows.Forms.Button btnDeleteTicket;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnTicketAdd;
        private System.Windows.Forms.Label lbticketnow;
        private System.Windows.Forms.DataGridView dgvTicket;
        private System.Windows.Forms.TextBox tbxService;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label lblService;
        private System.Windows.Forms.TextBox tbxDiscount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.DataGridView dgvMovie;
        private System.Windows.Forms.DataGridView dgvFood;
        private System.Windows.Forms.Button btnDeleteMovie;
        private System.Windows.Forms.Button btnImage;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lblMovieNow;
        private System.Windows.Forms.Button btn_addMovie;
        private System.Windows.Forms.TextBox tbxMovieName;
        private System.Windows.Forms.Label lblMovieName;
        private System.Windows.Forms.Label lblKind;
        private System.Windows.Forms.Label lblDicribe;
        private System.Windows.Forms.TextBox tbxMovieAbout;
        private System.Windows.Forms.Button DeleteFood;
        private System.Windows.Forms.TextBox tbxImage;
        private System.Windows.Forms.Label lblImage;
        private System.Windows.Forms.TextBox tbxFoodPrice;
        private System.Windows.Forms.Button btnFood_add;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxFoodName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox gbSuatChieu;
        private System.Windows.Forms.DataGridView dgvSuatChieu;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DateTimePicker dtp;
        private System.Windows.Forms.Label label5;
    }
}