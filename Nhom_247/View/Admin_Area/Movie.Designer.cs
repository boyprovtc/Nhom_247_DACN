namespace Nhom_247.View.Admin_Area
{
    partial class Movie
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
            this.btn_addMovie = new System.Windows.Forms.Button();
            this.tbxMovieName = new System.Windows.Forms.TextBox();
            this.lblMovieName = new System.Windows.Forms.Label();
            this.lblDicribe = new System.Windows.Forms.Label();
            this.tbxMovieAbout = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxIDMovie = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_addMovie
            // 
            this.btn_addMovie.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_addMovie.Location = new System.Drawing.Point(279, 59);
            this.btn_addMovie.Name = "btn_addMovie";
            this.btn_addMovie.Size = new System.Drawing.Size(102, 27);
            this.btn_addMovie.TabIndex = 10;
            this.btn_addMovie.Text = "Save";
            this.btn_addMovie.UseVisualStyleBackColor = true;
            this.btn_addMovie.Click += new System.EventHandler(this.btn_addMovie_Click);
            // 
            // tbxMovieName
            // 
            this.tbxMovieName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxMovieName.Location = new System.Drawing.Point(92, 59);
            this.tbxMovieName.Name = "tbxMovieName";
            this.tbxMovieName.Size = new System.Drawing.Size(181, 20);
            this.tbxMovieName.TabIndex = 7;
            // 
            // lblMovieName
            // 
            this.lblMovieName.AutoSize = true;
            this.lblMovieName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovieName.Location = new System.Drawing.Point(13, 59);
            this.lblMovieName.Name = "lblMovieName";
            this.lblMovieName.Size = new System.Drawing.Size(71, 18);
            this.lblMovieName.TabIndex = 5;
            this.lblMovieName.Text = "Tên Phim";
            // 
            // lblDicribe
            // 
            this.lblDicribe.AutoSize = true;
            this.lblDicribe.Location = new System.Drawing.Point(13, 94);
            this.lblDicribe.Name = "lblDicribe";
            this.lblDicribe.Size = new System.Drawing.Size(76, 13);
            this.lblDicribe.TabIndex = 6;
            this.lblDicribe.Text = "Giới thiệu phim";
            // 
            // tbxMovieAbout
            // 
            this.tbxMovieAbout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxMovieAbout.Location = new System.Drawing.Point(92, 94);
            this.tbxMovieAbout.Multiline = true;
            this.tbxMovieAbout.Name = "tbxMovieAbout";
            this.tbxMovieAbout.Size = new System.Drawing.Size(181, 65);
            this.tbxMovieAbout.TabIndex = 8;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(279, 94);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(102, 26);
            this.button3.TabIndex = 9;
            this.button3.Text = "Hủy";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "ID Movie";
            // 
            // tbxIDMovie
            // 
            this.tbxIDMovie.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxIDMovie.Location = new System.Drawing.Point(91, 30);
            this.tbxIDMovie.Name = "tbxIDMovie";
            this.tbxIDMovie.Size = new System.Drawing.Size(181, 20);
            this.tbxIDMovie.TabIndex = 7;
            // 
            // Movie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 215);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btn_addMovie);
            this.Controls.Add(this.tbxIDMovie);
            this.Controls.Add(this.tbxMovieName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMovieName);
            this.Controls.Add(this.lblDicribe);
            this.Controls.Add(this.tbxMovieAbout);
            this.Name = "Movie";
            this.Text = "Movie";
            this.Load += new System.EventHandler(this.Movie_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_addMovie;
        private System.Windows.Forms.TextBox tbxMovieName;
        private System.Windows.Forms.Label lblMovieName;
        private System.Windows.Forms.Label lblDicribe;
        private System.Windows.Forms.TextBox tbxMovieAbout;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxIDMovie;
    }
}