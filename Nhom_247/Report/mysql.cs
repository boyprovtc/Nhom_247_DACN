using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhom_247.Report
{
     public class mysql
    {
        public static MySqlConnection con;
        public static MySqlCommand cmd;
        public static MySqlDataAdapter  da;
        public static MySqlDataReader dr;
        public static DataTable dt;
        public static DataSet ds;

        public static string Conn_String
        {
            get { return $"server = localhost; port=3306; username=root; password=;database=247_rapphim;sslmode=None"; }
        }
        public static void Query(string sql)
        {
            using(con = new MySqlConnection(Conn_String))
            {
                con.Open();
                using(cmd = new MySqlCommand(sql, con))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public static DataTable GetData(string sql)
        {
            using(con = new MySqlConnection(Conn_String))
            {
                dt = new DataTable();
                using(da = new MySqlDataAdapter(sql, con))
                {
                    da.Fill(dt);
                }
            }
            return dt;
        }
        public static DataSet DataSet(string sql, string tbl)
        {
            using (con = new MySqlConnection(Conn_String))
            {
                ds = new DataSet();
                using (da = new MySqlDataAdapter(sql, con))
                {
                    da.Fill(ds,tbl);
                }
            }
            return ds;
        }
    }
}
