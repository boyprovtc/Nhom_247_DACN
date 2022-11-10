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
    class Ticket_Controller
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
        public static void add_Ticket(Ticket_Model ticket)
        {
            string conStr = "INSERT INTO ticket VALUES (NULL, @TicketType, @TicketPrice)";
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(conStr, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@TicketType", MySqlDbType.VarChar).Value = ticket.TicketType;
            cmd.Parameters.Add("@TicketPrice", MySqlDbType.VarChar).Value = ticket.TicketPrice;
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
        public static void DisplayNSearchTicket(string query, DataGridView dgvTicket)
        {
            string conStr = query;
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(conStr, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable tbl = new DataTable();
            adp.Fill(tbl);
            dgvTicket.DataSource = tbl;
            conn.Close();
        }
    }
}
