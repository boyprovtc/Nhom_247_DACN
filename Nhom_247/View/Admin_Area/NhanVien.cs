using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nhom_247.Controller;
using Nhom_247.Model;
using Nhom_247.View;

namespace Nhom_247
{
    public partial class NhanVien : Form
    {

        private readonly NhanVien_Info _parent;
        public string id, name, phone, gmail;
        public NhanVien(NhanVien_Info parent)
        {
            InitializeComponent();
            _parent = parent;
        }
       
        private void NhanVien_Load(object sender, EventArgs e)
        {
            tbxID.ReadOnly = true;
           
        }

        private void NhanVien_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Clear();
        }

        public void Clear()
        {
           btnAdd.Text = "Save";
           tbxID.Text = tbxName.Text = tbxGmail.Text = tbxPhone.Text = String.Empty;
        }
       
        public void update_info()
        {
            btnAdd.Text = "Update";
            tbxID.Text = id;
            tbxName.Text = name;
            tbxPhone.Text = phone;
            tbxGmail.Text = gmail;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tbxName.Text.Trim().Length < 1)
            {
                MessageBox.Show("Name is empty");
                return;
            }
            if(tbxPhone.Text.Trim().Length < 1)
            {
                MessageBox.Show("Phone number is empty");
                return;
            }
            if (tbxGmail.Text.Trim().Length < 1)
            {
                MessageBox.Show("Gmail is empty");
                return;
            }
            if(btnAdd.Text == "Save")
            {
                NhanVien_Model nv = new NhanVien_Model(tbxName.Text.Trim(), tbxPhone.Text.Trim(), tbxGmail.Text.Trim());
                NhanVien_Controller.add_NhanVien(nv);
                Clear();
                
            }
            if (btnAdd.Text == "Update")
            {
                NhanVien_Model nv = new NhanVien_Model(tbxName.Text.Trim(), tbxPhone.Text.Trim(), tbxGmail.Text.Trim());
                NhanVien_Controller.update_NhanVien(nv, id);
                Clear();
                
            }
            _parent.Display();
        }

        
    }
}
