
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
    class Food_Controller
    {
        //IFirebaseConfig config = new FirebaseConfig
        //{
        //    AuthSecret = "FrjitzEfYNMvVSGqL0HcMXI8PaH20d3PxxWNB6dk",
        //    BasePath = "https://console.firebase.google.com/u/0/project/rapphim-d0389/database/rapphim-d0389-default-rtdb/data/~2F"
        //};

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
        public static void add_Food(Food_Model food)
        {
            string conStr = "INSERT INTO food VALUES (NULL, @NameFood, @Price)";
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(conStr, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@NameFood", MySqlDbType.VarChar).Value = food.NameFood;
            cmd.Parameters.Add("@Price", MySqlDbType.VarChar).Value = food.Price;
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
        public static void update_Food(Food_Model food, string id)
        {
            string conStr = "UPDATE food SET NameFood = @NameFood,Price = @Price WHERE ID_Food = @id";
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(conStr, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;
            cmd.Parameters.Add("@NameFood", MySqlDbType.VarChar).Value = food.NameFood;
            cmd.Parameters.Add("@Price", MySqlDbType.VarChar).Value = food.Price;
            try
            {
                cmd.ExecuteNonQuery();
                //   MessageBox.Show("update done", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {

                MessageBox.Show("update failed \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();

        }
        public static void Delete_Food(string id)
        {
            string conStr = "DELETE FROM food WHERE ID_Food = @id";
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(conStr, conn);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;
            try
            {
                cmd.ExecuteNonQuery();
                //   MessageBox.Show("Delete done", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {

                MessageBox.Show("Delete failed \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
        }
        public static void DisplayNSearchFood(string query, DataGridView dgvFood)
        {
            string conStr = query;
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(conStr, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable tbl = new DataTable();
            adp.Fill(tbl);
            dgvFood.DataSource = tbl;
            conn.Close();
        }
    }
}
