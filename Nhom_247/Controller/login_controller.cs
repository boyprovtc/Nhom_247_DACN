using MySql.Data.MySqlClient;
using Nhom_247.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom_247.Controller
{
    class login_controller
    {
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
        public static void add_member(login_model login)
        {
            string conStr = "INSERT INTO login VALUES (NULL, @user, @pass)";
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(conStr, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@user", MySqlDbType.VarChar).Value = login.user;
            cmd.Parameters.Add("@pass", MySqlDbType.VarChar).Value = login.pass;
            try
            {
                cmd.ExecuteNonQuery();
                // MessageBox.Show("Add done", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {

                MessageBox.Show("Add failed \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();

        }
        public static void update_password(login_model login)
        {
            string conStr = "UPDATE login SET pass = @pass WHERE user = @user";
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(conStr, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@user", MySqlDbType.VarChar).Value = login.user;

            cmd.Parameters.Add("@pass", MySqlDbType.VarChar).Value = login.pass;
            
            try
            {
                cmd.ExecuteNonQuery();
                //    MessageBox.Show("update done", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);              
            }
            catch (MySqlException ex)
            {

                MessageBox.Show("Update failed \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            conn.Close();

        }

        

        


    }
}
