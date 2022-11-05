using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom_247
{
    public partial class NhanVien : Form
    {
        string conStr = "Server = localhost; Database = 247_rapphim; Port = 3306; User ID = root; Password = ";
       
        public NhanVien()
        {
            InitializeComponent();
        }

        private void NhanVien_Load(object sender, EventArgs e)
        {
           
        }

        private void NhanVien_FormClosed(object sender, FormClosedEventArgs e)
        {
            
                MainForm mF = new MainForm();
                mF.Show();
                this.Dispose();
            
        }

      
    }
}
