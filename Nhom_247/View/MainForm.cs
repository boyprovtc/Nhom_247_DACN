﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom_247
{
    public partial class MainForm : Form
    {
        string conStr = "Server = localhost; Database = 247_rapphim; Port = 3306; User ID = root; Password = ";
       
        public MainForm()
        {
            InitializeComponent();
        }
        
        private void MainForm_Load(object sender, EventArgs e)
        {
            pnMain.Size = new Size (465,510);
            pnMain.BorderStyle = BorderStyle.FixedSingle;
            WindowState = FormWindowState.Maximized;
            int Top = 0; //Vi tri Top
            for (char i = 'A'; i <= 'K'; i++)
            {
                int Left = 0; //Vi tri Left
                for (int j = 1; j <= 10 ; j++)
                {
                    //Taoj 1 button mới
                    Button bt = new Button();
                    //Thêm thuộc tính
                    bt.Name = string.Format("bt{0}{1}", i, j);
                    bt.Tag = string.Format("[{0}{1}]", i, j);
                    bt.Text = string.Format("{0}{1}", i, j);
                    bt.Size = new Size(40, 40);

                    bt.Top = Top;
                    bt.Left = Left;

                    Left += 50;

                    bt.BackColor = Color.AliceBlue;
                    bt.ForeColor = Color.Black;
                    
                   

                    //Phải thêm nút vào panel để hiển thị luôn
                    pnMain.Controls.Add(bt);
                }
                Top += 50;
            }

           

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admin ad = new Admin();
            ad.Show();
            this.Hide();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (MessageBox.Show("Bạn Có Muốn Thoát không", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {

                this.Dispose();
            }
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn Có Muốn Thoát không", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Login login = new Login();
                login.Show();
                this.Hide();
            }
        }

        private void nhanVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NhanVien nv = new NhanVien();
            nv.Show();
            this.Hide();
        }
    }
}