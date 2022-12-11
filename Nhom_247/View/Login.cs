using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.Common;
using Nhom_247;
using System.IO;
using MySql.Data.MySqlClient;
using Nhom_247.View;

namespace Nhom_247
{
    public partial class Login : Form
    {
        Resigter form1;
        public Login()
        {
            InitializeComponent();
            form1 = new Resigter(this);
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public static MySqlConnection GetConnection()
        {
            string conStr = "datasource = localhost; port=3306; username=root; password=;database=247_rapphim";
            MySqlConnection conn = new MySqlConnection(conStr);
            try
            {
                conn.Open();
            }
            catch (MySqlException ex)
            {

                MessageBox.Show("MySQL connection! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return conn;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
            this.lblUserName.BackColor = System.Drawing.Color.Transparent;
            this.lblPassWord.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.Location = new System.Drawing.Point(500, 250);
            tbxPass.PasswordChar = '*';
            this.StartPosition = FormStartPosition.CenterScreen;



        }


        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Login login = new Login();
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
           
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand("select user, pass from login where user = '" + tbxUserName.Text + "' AND pass = '" + tbxPass.Text + "'", conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                this.Hide();
                MainForm mf = new MainForm();
                mf.Show();
            }
            else
            {
                MessageBox.Show("lUsername And Password Not Match! \n");
            }
            
        }

        private void btnResigter_Click(object sender, EventArgs e)
        {
            form1.ShowDialog();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            form1.username = tbxUserName.Text;
            form1.update_info();
            form1.ShowDialog();
            
        }
    }
}
