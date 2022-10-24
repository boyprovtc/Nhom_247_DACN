using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;
namespace Nhom_247
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

       

        private void Login_Load(object sender, EventArgs e)
        {

            this.lblUserName.BackColor = System.Drawing.Color.Transparent;
            this.lblPassWord.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.Location = new System.Drawing.Point(500, 250);
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Login login = new Login();
            Application.Exit();
        }
    }
}
