namespace Nhom_247.View.Admin_Area
{
    partial class Room
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
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxID_Room = new System.Windows.Forms.TextBox();
            this.tbxRoomNumber = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnAdd_Room = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Số Phòng";
            // 
            // tbxID_Room
            // 
            this.tbxID_Room.Location = new System.Drawing.Point(92, 12);
            this.tbxID_Room.Name = "tbxID_Room";
            this.tbxID_Room.Size = new System.Drawing.Size(208, 20);
            this.tbxID_Room.TabIndex = 8;
            // 
            // tbxRoomNumber
            // 
            this.tbxRoomNumber.Location = new System.Drawing.Point(92, 38);
            this.tbxRoomNumber.Name = "tbxRoomNumber";
            this.tbxRoomNumber.Size = new System.Drawing.Size(208, 20);
            this.tbxRoomNumber.TabIndex = 9;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(225, 129);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click_1);
            // 
            // btnAdd_Room
            // 
            this.btnAdd_Room.Location = new System.Drawing.Point(144, 129);
            this.btnAdd_Room.Name = "btnAdd_Room";
            this.btnAdd_Room.Size = new System.Drawing.Size(75, 23);
            this.btnAdd_Room.TabIndex = 5;
            this.btnAdd_Room.Text = "Save";
            this.btnAdd_Room.UseVisualStyleBackColor = true;
            this.btnAdd_Room.Click += new System.EventHandler(this.btnAdd_Room_Click);
            // 
            // Room
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 160);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxID_Room);
            this.Controls.Add(this.tbxRoomNumber);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnAdd_Room);
            this.Name = "Room";
            this.Text = "Room";
            this.Load += new System.EventHandler(this.Room_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxID_Room;
        private System.Windows.Forms.TextBox tbxRoomNumber;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnAdd_Room;
    }
}