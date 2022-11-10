using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MessageBox = System.Windows.Forms.MessageBox;
using Nhom_247.Model;
namespace Nhom_247.Controller
{
    class NhanVien_Controller
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
        public static void add_NhanVien (NhanVien_Model nhanVien)
        {
            string conStr = "INSERT INTO tbl_nhanvien VALUES (NULL, @Name, @Phone, @Gmail)";
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(conStr, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@Name", MySqlDbType.VarChar).Value = nhanVien.Name;
            cmd.Parameters.Add("@Phone", MySqlDbType.VarChar).Value = nhanVien.Phone;
            cmd.Parameters.Add("@Gmail", MySqlDbType.VarChar).Value = nhanVien.Gmail;
            try
            {
                cmd.ExecuteNonQuery();
               // MessageBox.Show("Add done", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {

                MessageBox.Show("Add failed \n"+ ex.Message,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
        
        }
        public static void update_NhanVien(NhanVien_Model nhanVien)
        {
            string conStr = "UPDATE tbl_Nhanvien SET Name = @Name, Phone = @Phone, Gmail = @Gmail WHERE ID = @Id";
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(conStr, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@Name", MySqlDbType.VarChar).Value = nhanVien.Name;
            cmd.Parameters.Add("@Phone", MySqlDbType.VarChar).Value = nhanVien.Phone;
            cmd.Parameters.Add("@Gmail", MySqlDbType.VarChar).Value = nhanVien.Gmail;
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
            string conStr = "DELETE FROM tbl_nhanvien WHERE ID = @Id";
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(conStr, conn);
            cmd.CommandType = CommandType.Text;
           
            cmd.Parameters.Add("@Id", MySqlDbType.VarChar).Value = id;
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

        public static void DisplayNSearch(string query, DataGridView dtNhanVien)
        {
            string conStr = query;
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(conStr, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable tbl = new DataTable();
            adp.Fill(tbl);
            dtNhanVien.DataSource = tbl;
            conn.Close();
        }

    }
}
