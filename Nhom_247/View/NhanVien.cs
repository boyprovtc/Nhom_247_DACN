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

namespace Nhom_247
{
    public partial class NhanVien : Form
    {
       
       
        public NhanVien()
        {
            InitializeComponent();
        }
        public void Display()
        {
            NhanVien_Controller.DisplayNSearch("SELECT * FROM tbl_nhanvien",dtNhanVien);
        }
        private void NhanVien_Load(object sender, EventArgs e)
        {
            Display();
        }

        private void NhanVien_FormClosed(object sender, FormClosedEventArgs e)
        {
            
                MainForm mF = new MainForm();
                mF.Show();
               this.Hide();
            
        }

        public void Clear()
        {
           tbxID.Text = tbxName.Text = tbxGmail.Text = tbxPhone.Text = String.Empty;
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
                Display();
            }
           
        }

       

        private void dtNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dtNhanVien.Rows[e.RowIndex];
            tbxName.Text = Convert.ToString(row.Cells["Name"].Value);
            tbxPhone.Text = Convert.ToString(row.Cells["Phone"].Value);
            tbxGmail.Text = Convert.ToString(row.Cells["Gmail"].Value);
            tbxID.Text = Convert.ToString(row.Cells["ID"].Value);

            if (e.ColumnIndex ==0)
            {
                return;
            }
            if(e.ColumnIndex == 1)
            {
                if(MessageBox.Show("Do you want to delete ?", "Informatioon", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information)== DialogResult.Yes)
                {
                    NhanVien_Controller.Delete_NhanVien(dtNhanVien.Rows[e.RowIndex].Cells[2].Value.ToString());
                    this.Hide();
                    NhanVien nhanVien = new NhanVien();
                    nhanVien.Show();

                }
                
                return ;
            }
            
        }
        public void update()
        {

        }
        private void btnChange_Click(object sender, EventArgs e)
        {
           
        }
    }
}
