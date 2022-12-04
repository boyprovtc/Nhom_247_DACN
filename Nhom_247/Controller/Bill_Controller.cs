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
    class Bill_Controller
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
        public static void add_Bill(Bill_Model bill )
        {
            string conStr = "INSERT INTO bill VALUES (NULL,@ID_Seat,@Room,@MovieName,@Date,@Time,@Total)";
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(conStr, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@ID_Seat", MySqlDbType.VarChar).Value = bill.ID_Bill;
            cmd.Parameters.Add("@Room", MySqlDbType.VarChar).Value = bill.Room;
            cmd.Parameters.Add("@MovieName", MySqlDbType.VarChar).Value = bill.MovieName;
            cmd.Parameters.Add("@Time", MySqlDbType.VarChar).Value = bill.Time;
            cmd.Parameters.Add("@Date", MySqlDbType.VarChar).Value = bill.Date;
            cmd.Parameters.Add("@Total", MySqlDbType.VarChar).Value = bill.Total;

            try
            {
                cmd.ExecuteNonQuery();
                //       MessageBox.Show("Add done", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {

                MessageBox.Show("Add failed \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();

        }
        public static void update_Bill(Bill_Model bill, string id)
        {
            string conStr = "UPDATE bill SET Date = @Date, Total = @Total WHERE ID_Bill = @id";
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(conStr, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;
            //cmd.Parameters.Add("@Date", MySqlDbType.VarChar).Value = bill.Date;
            //cmd.Parameters.Add("@Total", MySqlDbType.VarChar).Value = bill.Total;

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

        public static void Delete_Bill(string id)
        {
            string conStr = "DELETE FROM bill WHERE ID_Bill = @id";
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(conStr, conn);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;
            try
            {
                cmd.ExecuteNonQuery();
                //    MessageBox.Show("Delete done", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {

                MessageBox.Show("Delete failed \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
        }
        public static void DisplayNSearchBill(string query, DataGridView dgvBill)
        {
            string conStr = query;
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(conStr, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable tbl = new DataTable();
            adp.Fill(tbl);
            dgvBill.DataSource = tbl;
            conn.Close();
        }

       
    }
}
