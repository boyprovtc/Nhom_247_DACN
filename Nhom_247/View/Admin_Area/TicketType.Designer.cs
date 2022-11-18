namespace Nhom_247.View.Admin
{
    partial class TicketType
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnTicketTypeAdd = new System.Windows.Forms.Button();
            this.tbxtickettypeprice = new System.Windows.Forms.TextBox();
            this.tbxtickettype = new System.Windows.Forms.TextBox();
            this.lbpremium = new System.Windows.Forms.Label();
            this.lbticket = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxIDTypeTicket = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(317, 72);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 26);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnTicketTypeAdd
            // 
            this.btnTicketTypeAdd.Location = new System.Drawing.Point(317, 39);
            this.btnTicketTypeAdd.Name = "btnTicketTypeAdd";
            this.btnTicketTypeAdd.Size = new System.Drawing.Size(110, 27);
            this.btnTicketTypeAdd.TabIndex = 10;
            this.btnTicketTypeAdd.Text = "Save";
            this.btnTicketTypeAdd.UseVisualStyleBackColor = true;
            this.btnTicketTypeAdd.Click += new System.EventHandler(this.btnTicketTypeAdd_Click);
            // 
            // tbxtickettypeprice
            // 
            this.tbxtickettypeprice.Location = new System.Drawing.Point(71, 72);
            this.tbxtickettypeprice.Name = "tbxtickettypeprice";
            this.tbxtickettypeprice.Size = new System.Drawing.Size(219, 20);
            this.tbxtickettypeprice.TabIndex = 7;
            // 
            // tbxtickettype
            // 
            this.tbxtickettype.Location = new System.Drawing.Point(71, 42);
            this.tbxtickettype.Name = "tbxtickettype";
            this.tbxtickettype.Size = new System.Drawing.Size(219, 20);
            this.tbxtickettype.TabIndex = 8;
            // 
            // lbpremium
            // 
            this.lbpremium.AutoSize = true;
            this.lbpremium.Location = new System.Drawing.Point(10, 76);
            this.lbpremium.Name = "lbpremium";
            this.lbpremium.Size = new System.Drawing.Size(38, 13);
            this.lbpremium.TabIndex = 5;
            this.lbpremium.Text = "Giá vé";
            // 
            // lbticket
            // 
            this.lbticket.AutoSize = true;
            this.lbticket.Location = new System.Drawing.Point(10, 46);
            this.lbticket.Name = "lbticket";
            this.lbticket.Size = new System.Drawing.Size(43, 13);
            this.lbticket.TabIndex = 6;
            this.lbticket.Text = "Loại Vé";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "ID Loại";
            // 
            // tbxIDTypeTicket
            // 
            this.tbxIDTypeTicket.Location = new System.Drawing.Point(71, 16);
            this.tbxIDTypeTicket.Name = "tbxIDTypeTicket";
            this.tbxIDTypeTicket.ReadOnly = true;
            this.tbxIDTypeTicket.Size = new System.Drawing.Size(219, 20);
            this.tbxIDTypeTicket.TabIndex = 8;
            // 
            // TicketType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 102);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnTicketTypeAdd);
            this.Controls.Add(this.tbxtickettypeprice);
            this.Controls.Add(this.tbxIDTypeTicket);
            this.Controls.Add(this.tbxtickettype);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbpremium);
            this.Controls.Add(this.lbticket);
            this.Name = "TicketType";
            this.Text = "Ticket";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnTicketTypeAdd;
        private System.Windows.Forms.TextBox tbxtickettypeprice;
        private System.Windows.Forms.TextBox tbxtickettype;
        private System.Windows.Forms.Label lbpremium;
        private System.Windows.Forms.Label lbticket;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxIDTypeTicket;
    }
}