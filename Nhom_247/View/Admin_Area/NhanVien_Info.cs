using Nhom_247.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Nhom_247.View
{
    public partial class NhanVien_Info : Form
    {
        NhanVien form;
        public NhanVien_Info()
        {
            InitializeComponent();
            form = new NhanVien(this);
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void NhanVien_Info_Shown(object sender, EventArgs e)
        {
            Display();
        }
        public void Display()
        {
            NhanVien_Controller.DisplayNSearch("SELECT * FROM tbl_nhanvien", dtNhanVien);
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            form.Clear();
            form.ShowDialog();
        }
        private void dtNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //DataGridViewRow row = new DataGridViewRow();
            //row = dtNhanVien.Rows[e.RowIndex];

            if (e.ColumnIndex == 0)
            {
                form.Clear();
                form.id = dtNhanVien.Rows[e.RowIndex].Cells["ID"].Value.ToString();
                form.name = dtNhanVien.Rows[e.RowIndex].Cells["Name"].Value.ToString();
                form.phone = dtNhanVien.Rows[e.RowIndex].Cells["Phone"].Value.ToString();
                form.gmail = dtNhanVien.Rows[e.RowIndex].Cells["Gmail"].Value.ToString();
                form.update_info();
                form.ShowDialog();
                return;
            }
            if (e.ColumnIndex == 1)
            {
                if (MessageBox.Show("Do you want to delete ?", "Informatioon", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    NhanVien_Controller.Delete_NhanVien(dtNhanVien.Rows[e.RowIndex].Cells[2].Value.ToString());
                    Display();
                }
                return;
            }

        }

        private void NhanVien_Info_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormAdmin ad = new FormAdmin();
            ad.Show();
            this.Hide();
        }

        private void NhanVien_Info_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
        }
    }
}
