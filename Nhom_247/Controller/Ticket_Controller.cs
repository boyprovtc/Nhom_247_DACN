﻿using MySql.Data.MySqlClient;
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
            string conStr = "INSERT INTO ticket_type VALUES (NULL, @TicketType, @TicketPrice)";
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(conStr, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@TicketType", MySqlDbType.VarChar).Value = ticket.TicketType;
            cmd.Parameters.Add("@TicketPrice", MySqlDbType.VarChar).Value = ticket.TicketPrice;
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
        public static void update_Ticket(Ticket_Model ticket, string id)
        {
            string conStr = "UPDATE ticket_type SET TicketType = @TicketType,TicketPrice = @TicketPrice WHERE ID_TICKETTYPE = @id";
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(conStr, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;
            cmd.Parameters.Add("@TicketType", MySqlDbType.VarChar).Value = ticket.TicketType;
            cmd.Parameters.Add("@TicketPrice", MySqlDbType.VarChar).Value = ticket.TicketPrice;
            try
            {
                cmd.ExecuteNonQuery();
              //  MessageBox.Show("update done", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {

                MessageBox.Show("update failed \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();

        }
        public static void Delete_TicketType(string id)
        {
            string conStr = "DELETE FROM ticket_type WHERE ID_TICKETTYPE = @id";
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
