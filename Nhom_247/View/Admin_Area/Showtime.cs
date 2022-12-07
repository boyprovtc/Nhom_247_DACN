using Nhom_247.Controller;
using Nhom_247.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace Nhom_247.View.Admin_Area
{
    public partial class Showtime : Form
    {
        private readonly FormAdmin _parent;
        public Showtime(FormAdmin parent)
        {
            InitializeComponent();
            _parent = parent;
        }
        public string id_showtimes, name,roomnumber, time,date;
        public int id_movie, id_room;
        public void update_info()
        {
            btnAdd.Text = "Update";
            tbxID_Showtime.Text = id_showtimes;
            cbxID_Movie.SelectedValue = id_movie;
            cbxID_Room.SelectedValue = id_room;
            cbxMovie.Text = name;
            cbxRoom.Text = roomnumber;
            dtp.Text = time;
            dtpDate.Text = date;
        }

        private void Showtime_FormClosed(object sender, FormClosedEventArgs e)
        {
            cbxMovie.Items.Clear();
            cbxRoom.Items.Clear();
            cbxID_Movie.Items.Clear();
            cbxID_Room.Items.Clear();
            this.Hide();
        }

      

        

        private void cbxMovie_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            cbxID_Movie.SelectedIndex = cbxMovie.SelectedIndex;
            

        }

        private void cbxRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            cbxID_Room.SelectedIndex = cbxRoom.SelectedIndex;
        }

        private void Showtime_Load(object sender, EventArgs e)
        {
            dtp.Format = DateTimePickerFormat.Time;
            dtpDate.Format = DateTimePickerFormat.Short;
            dtp.ShowUpDown = true;
            cbxID_Movie.Enabled = false;
            cbxID_Room.Enabled = false;
            tbxID_Showtime.ReadOnly = true;
            tbxID_Showtime.BackColor = Color.Aqua;
            try
            {
                MySqlConnection connection = new MySqlConnection("datasource = localhost; port=3306; username=root; password=;database=247_rapphim");
                string selectQuery = "select * from movie";
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(selectQuery, connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cbxMovie.Items.Add(reader.GetString("MovieName"));
                    cbxID_Movie.Items.Add(reader.GetString("ID_Movie"));

                }
                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            try
            {
                MySqlConnection connection = new MySqlConnection("datasource = localhost; port=3306; username=root; password=;database=247_rapphim");
                string selectQuery2 = "select * from room";
                connection.Open();
                MySqlCommand cmd2 = new MySqlCommand(selectQuery2, connection);
                MySqlDataReader reader2 = cmd2.ExecuteReader();
                while (reader2.Read())
                {
                    cbxRoom.Items.Add(reader2.GetString("RoomNumber"));
                    cbxID_Room.Items.Add(reader2.GetString("ID_Room"));
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
             if (cbxMovie.Text.Trim().Length < 1)
            {
                MessageBox.Show("MovieName is empty");
                return;
            }
            if (cbxRoom.Text.Trim().Length < 1)
            {
                MessageBox.Show("Room is empty");
                return;
            }
           
            if (btnAdd.Text == "Add")
            {
                Showtimes_Model st = new Showtimes_Model(
                    Convert.ToInt32(cbxID_Movie.Text),
                    Convert.ToInt32(cbxID_Room.Text),
                    cbxMovie.Text.Trim(),
                    dtp.Text.Trim(),
                    dtpDate.Text.Trim());
                Showtimes_Controller.add_Showtime(st);
                Clear();

            }
            
            if (btnAdd.Text == "Update")
            {

                Showtimes_Model st = new Showtimes_Model(
                    Convert.ToInt32(cbxID_Movie.Text),
                    Convert.ToInt32(cbxID_Room.Text),
                    cbxMovie.Text.Trim(),
                    dtp.Text.Trim(),
                    dtpDate.Text.Trim());
                Showtimes_Controller.update_Showtime(st,id_showtimes);
                Clear();

            }
            _parent.Display();
        }
        public void Clear()
        {
            btnAdd.Text = "Add";
            cbxID_Room.Text =cbxID_Movie.Text = cbxMovie.Text = cbxRoom.Text = dtp.Text = dtpDate.Text = String.Empty;
        }
       

    }
}
