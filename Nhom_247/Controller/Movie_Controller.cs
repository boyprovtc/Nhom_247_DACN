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
    class Movie_Controller
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
        public static void add_Movie(Movie_Model movie)
        {
            string conStr = "INSERT INTO tbl_phim VALUES (NULL, @MovieName, @MovieAbout)";
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(conStr, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@MovieName", MySqlDbType.VarChar).Value = movie.MovieName;
            cmd.Parameters.Add("@MovieAbout", MySqlDbType.VarChar).Value = movie.MovieAbout;
           
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Add done", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {

                MessageBox.Show("Add failed \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();

        }
        public static void update_NhanVien(Movie_Model movie, string id)
        {
            string conStr = "UPDATE tbl_phim SET MovieName = @MovieName, MovieAbout = @MovieAbout WHERE ID_Movie = @ID";
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(conStr, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@MovieName", MySqlDbType.VarChar).Value = movie.MovieName;
            cmd.Parameters.Add("@MovieAbout", MySqlDbType.VarChar).Value = movie.MovieAbout;
         
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("update done", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {

                MessageBox.Show("Update failed \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();

        }

        public static void Delete_NhanVien(string id)
        {
            string conStr = "DELETE FROM tbl_phim WHERE ID_Movie = @ID";
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(conStr, conn);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add("@ID", MySqlDbType.VarChar).Value = id;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Delete done", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {

                MessageBox.Show("Delete failed \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
        }

        public static void DisplayNSearchMovie(string query, DataGridView dgvMovie)
        {
            string conStr = query;
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(conStr, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable tbl = new DataTable();
            adp.Fill(tbl);
            dgvMovie.DataSource = tbl;
            conn.Close();
        }
    }
}
