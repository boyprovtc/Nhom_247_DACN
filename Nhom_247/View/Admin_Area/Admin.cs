using Catel.Services;
using Nhom_247.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using MessageBox = System.Windows.Forms.MessageBox;
using Nhom_247.Model;
using System.Xml.Linq;
using Nhom_247.View;
using Nhom_247.View.Admin;
using Nhom_247.View.Admin_Area;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Windows.Controls.Primitives;
using System.Windows.Input;

namespace Nhom_247
{
    public partial class FormAdmin : Form
    {
        TicketType form;
        Food form2;
        Movie form3;
        Showtime form4;
        public FormAdmin()
        {
            InitializeComponent();
            form = new TicketType(this);
            form2 = new Food(this);
            form3 = new Movie(this);
            form4 = new Showtime(this);
        }
        public void Display()
        {
            Movie_Controller.DisplayNSearchMovie("SELECT * FROM movie", dgvMovie);
            Food_Controller.DisplayNSearchFood("SELECT * FROM food", dgvFood);
            Ticket_Controller.DisplayNSearchTicket("SELECT * FROM ticket_type", dgvTicket);
            Showtimes_Controller.DisplayNSearchShowTime("SELECT * FROM showtimes", dgvShowtime);
            //try
            //{
            //    MySqlConnection connection = new MySqlConnection("datasource = localhost; port=3306; username=root; password=;database=247_rapphim");
            //    string selectQuery2 = "select * from room";
            //    connection.Open();
            //    MySqlCommand cmd2 = new MySqlCommand(selectQuery2, connection);
            //    MySqlDataReader reader2 = cmd2.ExecuteReader();
            //    while (reader2.Read())
            //    {
            //        cbxRoom.Items.Add(reader2.GetString("RoomNumber"));
                   
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);

            //}
        }
        private void Admin_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            //dtp.Format = DateTimePickerFormat.Time;
            //dtp.ShowUpDown = true;
            Display();
            //try
            //{
            //    MySqlConnection connection = new MySqlConnection("datasource = localhost; port=3306; username=root; password=;database=247_rapphim");
            //    string selectQuery = "select * from movie";
            //    connection.Open();
            //    MySqlCommand cmd = new MySqlCommand(selectQuery, connection);
            //    MySqlDataReader reader = cmd.ExecuteReader();
            //    while (reader.Read())
            //    {
            //        cbxMovie.Items.Add(reader.GetString("MovieName"));
                    
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
           
            //}
        }
       

        private void Admin_FormClosed(object sender, FormClosedEventArgs e)
        {

            if (MessageBox.Show("Bạn Có Muốn Thoát không", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MainForm mF = new MainForm();
                mF.Show();
                this.Hide();

            }
        }
        public void Clear()
        {
  //          tbxMovieName.Text = tbxMovieAbout.Text = tbxFoodName.Text = tbxFoodPrice.Text = tbxticketprice.Text = tbxtickettype.Text = String.Empty;
        }
       

      

      

        private void tbnNhanVien_Click(object sender, EventArgs e)
        {
            NhanVien_Info nvi = new NhanVien_Info();
            this.Hide();
            nvi.Show();
        }

        private void btnNewTicketType_Click(object sender, EventArgs e)
        {
            form.Clear();
            form.ShowDialog();
        }

        private void dgvTicket_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                form.Clear();
                form.id = dgvTicket.Rows[e.RowIndex].Cells["ID_TICKETTYPE"].Value.ToString();
                form.type = dgvTicket.Rows[e.RowIndex].Cells["TicketType"].Value.ToString();
                form.price = dgvTicket.Rows[e.RowIndex].Cells["TicketPrice"].Value.ToString();
                form.update_info();
                form.ShowDialog();
                return;
            }
            if (e.ColumnIndex == 1)
            {
                if (MessageBox.Show("Do you want to delete ?", "Informatioon", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    Ticket_Controller.Delete_TicketType(dgvTicket.Rows[e.RowIndex].Cells[2].Value.ToString());
                    Display();
                }
                return;
            }
           
        }

        private void dgvFood_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                form2.Clear();
                form2.id = dgvFood.Rows[e.RowIndex].Cells["ID_Food"].Value.ToString();
                form2.name = dgvFood.Rows[e.RowIndex].Cells["NameFood"].Value.ToString();
                form2.price = dgvFood.Rows[e.RowIndex].Cells["Price"].Value.ToString();
                form2.update_info();
                form2.ShowDialog();
                return;
            }
            if (e.ColumnIndex == 1)
            {
                if (MessageBox.Show("Do you want to delete ?", "Informatioon", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    Food_Controller.Delete_Food(dgvFood.Rows[e.RowIndex].Cells[2].Value.ToString());
                    Display();
                }
                return;
            }

        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            form2.Clear();
            form2.ShowDialog();
        }

        private void btnMovieAdd_Click(object sender, EventArgs e)
        {
            form3.Clear();
            form3.ShowDialog();

        }

        private void dgvMovie_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                form3.Clear();
                form3.id = dgvMovie.Rows[e.RowIndex].Cells["ID_Movie"].Value.ToString();
                form3.name = dgvMovie.Rows[e.RowIndex].Cells["MovieName"].Value.ToString();
                form3.description = dgvMovie.Rows[e.RowIndex].Cells["Description"].Value.ToString();
                form3.update_info();
                form3.ShowDialog();
                this.Refresh();
                return;
            }
            if (e.ColumnIndex == 1)
            {
                if (MessageBox.Show("Do you want to delete ?", "Informatioon", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    Movie_Controller.Delete_Movie(dgvMovie.Rows[e.RowIndex].Cells[2].Value.ToString());
                    Display();
                }
                return;
            }
           
           
        }

       

        private void btnRoom_Click(object sender, EventArgs e)
        {
            Room_info ri = new Room_info();
            ri.Show();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAdmin ad = new FormAdmin();
            ad.Show();
        }

       
       
      
        private void btnAddShowTime_Click(object sender, EventArgs e)
        {
            form4.Clear();
            form4.ShowDialog();
        }

        private void dgvShowtime_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                form4.Clear();
                form4.id = dgvShowtime.Rows[e.RowIndex].Cells["ID_Movie"].Value.ToString();
                form4.id_room = dgvShowtime.Rows[e.RowIndex].Cells["ID_Room"].Value.ToString();
                form4.name = dgvShowtime.Rows[e.RowIndex].Cells["MovieName"].Value.ToString();
                form4.time = dgvShowtime.Rows[e.RowIndex].Cells["DATE"].Value.ToString();
                form4.date = dgvShowtime.Rows[e.RowIndex].Cells["TIME"].Value.ToString();
               
                form4.update_info();
                form4.ShowDialog();
                this.Refresh();
                return;
            }
            //if (e.ColumnIndex == 1)
            //{
            //    if (MessageBox.Show("Do you want to delete ?", "Informatioon", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
            //    {
            //        Showtimes_Controller.Delete_Showtime(dgvShowtime.Rows[e.RowIndex].Cells[2].Value.ToString());
            //        Display();
            //    }
            //    return;
            //}

        }
    }
}
