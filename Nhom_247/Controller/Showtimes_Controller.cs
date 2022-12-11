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
    internal class Showtimes_Controller
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
        public static void add_Showtime(Showtimes_Model showtimes)
        {
            string conStr = "INSERT INTO showtimes VALUES (NULL,@ID_Movie,@ID_Room, @MovieName, @DATE, @TIME)";
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(conStr, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@ID_Movie", MySqlDbType.Int32).Value = showtimes.ID_Movie;
            cmd.Parameters.Add("@ID_Room", MySqlDbType.Int32).Value = showtimes.ID_Room;
            cmd.Parameters.Add("@MovieName", MySqlDbType.VarChar).Value = showtimes.MovieName;
            
            cmd.Parameters.Add("@DATE", MySqlDbType.VarChar).Value = showtimes.DATE;
            cmd.Parameters.Add("@TIME", MySqlDbType.VarChar).Value = showtimes.TIME;


            try
            {
                cmd.ExecuteNonQuery();
                //  MessageBox.Show("Add done", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {

                MessageBox.Show("Add failed \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();

        }
        public static void update_Showtime(Showtimes_Model showtimes, string id_showtimes)
        {
            string conStr = "UPDATE showtimes SET ID_Movie = @ID_Movie, ID_Room =@ID_Room,MovieName = @MovieName, DATE = @DATE, TIME = @TIME WHERE ID_Showtime = @ID";
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(conStr, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@ID", MySqlDbType.VarChar).Value = id_showtimes;
            cmd.Parameters.Add("@ID_Movie", MySqlDbType.Int32).Value = showtimes.ID_Movie;
            cmd.Parameters.Add("@ID_Room", MySqlDbType.Int32).Value = showtimes.ID_Room;
            cmd.Parameters.Add("@MovieName", MySqlDbType.VarChar).Value = showtimes.MovieName;
            
            cmd.Parameters.Add("@DATE", MySqlDbType.VarChar).Value = showtimes.DATE;
            cmd.Parameters.Add("@TIME", MySqlDbType.VarChar).Value = showtimes.TIME;


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

        public static void Delete_Showtime(string id)
        {
            string conStr = "DELETE FROM showtimes WHERE ID_Showtime = @ID";
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(conStr, conn);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add("@ID", MySqlDbType.VarChar).Value = id;


            try
            {
                cmd.ExecuteNonQuery();
                // MessageBox.Show("Delete done", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {

                MessageBox.Show("Delete failed \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
        }

        public static void DisplayNSearchShowTime(string query, DataGridView dgvShowtime)
        {
            string conStr = query;
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(conStr, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable tbl = new DataTable();
            adp.Fill(tbl);
            dgvShowtime.DataSource = tbl;
            conn.Close();
        }
    }
}
