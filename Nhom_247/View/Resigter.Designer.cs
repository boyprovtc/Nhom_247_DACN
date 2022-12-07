namespace Nhom_247.View
{
    partial class Resigter
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
            this.tbxUsername = new System.Windows.Forms.TextBox();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.tbxConfirm = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnResigter = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxAdminCode = new System.Windows.Forms.TextBox();
            this.btnXacThuc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxUsername
            // 
            this.tbxUsername.Location = new System.Drawing.Point(123, 89);
            this.tbxUsername.Name = "tbxUsername";
            this.tbxUsername.Size = new System.Drawing.Size(225, 20);
            this.tbxUsername.TabIndex = 0;
            // 
            // tbxPassword
            // 
            this.tbxPassword.Location = new System.Drawing.Point(123, 115);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.Size = new System.Drawing.Size(225, 20);
            this.tbxPassword.TabIndex = 0;
            // 
            // tbxConfirm
            // 
            this.tbxConfirm.Location = new System.Drawing.Point(123, 141);
            this.tbxConfirm.Name = "tbxConfirm";
            this.tbxConfirm.Size = new System.Drawing.Size(225, 20);
            this.tbxConfirm.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Confirm Password";
            // 
            // btnResigter
            // 
            this.btnResigter.Location = new System.Drawing.Point(272, 167);
            this.btnResigter.Name = "btnResigter";
            this.btnResigter.Size = new System.Drawing.Size(75, 23);
            this.btnResigter.TabIndex = 2;
            this.btnResigter.Text = "Resigter";
            this.btnResigter.UseVisualStyleBackColor = true;
            this.btnResigter.Click += new System.EventHandler(this.btnResigter_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(206, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "*Vui lòng xác thực admin trước khi tiếp tục";
            // 
            // tbxAdminCode
            // 
            this.tbxAdminCode.Location = new System.Drawing.Point(123, 25);
            this.tbxAdminCode.Name = "tbxAdminCode";
            this.tbxAdminCode.Size = new System.Drawing.Size(100, 20);
            this.tbxAdminCode.TabIndex = 4;
            // 
            // btnXacThuc
            // 
            this.btnXacThuc.Location = new System.Drawing.Point(123, 51);
            this.btnXacThuc.Name = "btnXacThuc";
            this.btnXacThuc.Size = new System.Drawing.Size(100, 23);
            this.btnXacThuc.TabIndex = 5;
            this.btnXacThuc.Text = "Xác Thực";
            this.btnXacThuc.UseVisualStyleBackColor = true;
            this.btnXacThuc.Click += new System.EventHandler(this.btnXacThuc_Click);
            // 
            // Resigter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 202);
            this.Controls.Add(this.btnXacThuc);
            this.Controls.Add(this.tbxAdminCode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnResigter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxConfirm);
            this.Controls.Add(this.tbxPassword);
            this.Controls.Add(this.tbxUsername);
            this.Name = "Resigter";
            this.Text = "Resigter";
            this.Load += new System.EventHandler(this.Resigter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxUsername;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.TextBox tbxConfirm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnResigter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxAdminCode;
        private System.Windows.Forms.Button btnXacThuc;
    }
}