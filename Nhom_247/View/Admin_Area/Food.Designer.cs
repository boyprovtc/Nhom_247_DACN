namespace Nhom_247.View.Admin_Area
{
    partial class Food
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
            this.tbxFoodPrice = new System.Windows.Forms.TextBox();
            this.btnFood_add = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.tbxFoodName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxFoodID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbxFoodPrice
            // 
            this.tbxFoodPrice.Location = new System.Drawing.Point(166, 77);
            this.tbxFoodPrice.Name = "tbxFoodPrice";
            this.tbxFoodPrice.Size = new System.Drawing.Size(128, 20);
            this.tbxFoodPrice.TabIndex = 19;
            // 
            // btnFood_add
            // 
            this.btnFood_add.Location = new System.Drawing.Point(312, 12);
            this.btnFood_add.Name = "btnFood_add";
            this.btnFood_add.Size = new System.Drawing.Size(94, 27);
            this.btnFood_add.TabIndex = 15;
            this.btnFood_add.Text = "Save";
            this.btnFood_add.UseVisualStyleBackColor = true;
            this.btnFood_add.Click += new System.EventHandler(this.btnFood_add_Click);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Location = new System.Drawing.Point(312, 45);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(94, 26);
            this.button4.TabIndex = 16;
            this.button4.Text = "Hủy";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // tbxFoodName
            // 
            this.tbxFoodName.Location = new System.Drawing.Point(166, 51);
            this.tbxFoodName.Name = "tbxFoodName";
            this.tbxFoodName.Size = new System.Drawing.Size(128, 20);
            this.tbxFoodName.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Giá";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Tên thức ăn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "ID";
            // 
            // tbxFoodID
            // 
            this.tbxFoodID.Location = new System.Drawing.Point(166, 25);
            this.tbxFoodID.Name = "tbxFoodID";
            this.tbxFoodID.Size = new System.Drawing.Size(128, 20);
            this.tbxFoodID.TabIndex = 20;
            // 
            // Food
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 137);
            this.Controls.Add(this.tbxFoodPrice);
            this.Controls.Add(this.btnFood_add);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.tbxFoodID);
            this.Controls.Add(this.tbxFoodName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Name = "Food";
            this.Text = "Food";
            this.Load += new System.EventHandler(this.Food_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxFoodPrice;
        private System.Windows.Forms.Button btnFood_add;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox tbxFoodName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxFoodID;
    }
}