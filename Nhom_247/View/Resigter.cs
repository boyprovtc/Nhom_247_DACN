using MySql.Data.MySqlClient;
using Nhom_247.Controller;
using Nhom_247.Model;
using Nhom_247.View.Admin_Area;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Nhom_247.View
{
    public partial class Resigter : Form
    {
        private readonly Login _parent;

        public string username;

        public Resigter(Login parent)
        {
            InitializeComponent();
            _parent = parent;
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        public void update_info()
        {
            btnResigter.Text = "Update";
            tbxUsername.Text = username;
            label2.Text = "New Password";

        }
        private void btnResigter_Click(object sender, EventArgs e)
        {
            if (tbxUsername.Text == string.Empty)
            {
                MessageBox.Show("Vui long dien username \n");
            }
            if (tbxPassword.Text == string.Empty)
            {
                MessageBox.Show("vui long dien  password \n");
            }
            if (tbxConfirm.Text == string.Empty)
            {
                MessageBox.Show("Vui long xac nhan mat khau \n");
            }
            if (btnResigter.Text == "Resigter")
            {
                if (tbxPassword.Text == tbxConfirm.Text)
                {
                    login_model lg = new login_model(tbxUsername.Text.Trim(), tbxPassword.Text.Trim());
                    login_controller.add_member(lg);
                    MessageBox.Show("dang ki thanh cong \n");
                    tbxUsername.Text = tbxPassword.Text = tbxConfirm.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show("Mat khau xac nhan khong dung \n");
                    return;
                }
            }
           
            if (btnResigter.Text == "Update")
            {
                if (tbxPassword.Text == tbxConfirm.Text)
                {
                    login_model lg = new login_model(tbxUsername.Text.Trim(), tbxPassword.Text.Trim());
                    login_controller.update_password(lg);
                    MessageBox.Show("doi mat khau thanh cong \n");
                    tbxUsername.Text = tbxPassword.Text = tbxConfirm.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show("Mat khau xac nhan khong dung \n");
                    return;
                }
            }
        }

        private void Resigter_Load(object sender, EventArgs e)
        {
            tbxPassword.PasswordChar = '*';
            tbxConfirm.PasswordChar = '*';
            tbxAdminCode.PasswordChar = '*';
            tbxUsername.Enabled = false;
            tbxPassword.Enabled = false;
            tbxConfirm.Enabled = false;
            btnResigter.Enabled = false;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnXacThuc_Click(object sender, EventArgs e)
        {
            if (tbxAdminCode.Text == "210501")
            {
                tbxUsername.Enabled = true;
                tbxPassword.Enabled = true;
                tbxConfirm.Enabled = true;
                btnResigter.Enabled = true;
                MessageBox.Show("Xác thực thành công");
                tbxAdminCode.Text = string.Empty;
            }
            else
                MessageBox.Show("Bạn không phải admin");
        }
    }
}
