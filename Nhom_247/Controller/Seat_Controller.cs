using MySql.Data.MySqlClient;
using Nhom_247.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Drawing;

namespace Nhom_247.Controller
{
    internal class Seat_Controller
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
        public static void add_Seat(Seat_Model seat)
        {
            for (char i = 'A'; i <= 'J'; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    string conStr = "INSERT INTO seat VALUES (NULL,@Row, @Columm)";
                    MySqlConnection conn = GetConnection();
                    MySqlCommand cmd = new MySqlCommand(conStr, conn);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add("@Row", MySqlDbType.VarChar).Value = i;
                    cmd.Parameters.Add("@Columm", MySqlDbType.VarChar).Value = j;
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
            }

        }
        public static void DisplayNSearchSeat(string query)
        {
            string conStr = query;
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(conStr, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable tbl = new DataTable();
            adp.Fill(tbl);

            conn.Close();
        }
    }
}
