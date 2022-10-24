using Catel.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using MessageBox = System.Windows.Forms.MessageBox;

namespace Nhom_247
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            dtp.Format = DateTimePickerFormat.Time;
            dtp.ShowUpDown = true;
        }
       

        private void Admin_FormClosed(object sender, FormClosedEventArgs e)
        {

            if (MessageBox.Show("Bạn Có Muốn Thoát không", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MainForm mF = new MainForm();
                mF.Show();
                this.Hide();
            }
        }

        
    }
}
