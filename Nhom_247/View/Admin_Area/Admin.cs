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

using Nhom_247.View.Admin_Area;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Windows.Controls.Primitives;
using System.Windows.Input;

namespace Nhom_247
{
    public partial class FormAdmin : Form
    {
        
        Food form2;
        Movie form3;
        Showtime form4;
        public FormAdmin()
        {
            InitializeComponent();
            form2 = new Food(this);
            form3 = new Movie(this);
            form4 = new Showtime(this);
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        public void Display()
        {
            Movie_Controller.DisplayNSearchMovie("SELECT * FROM movie", dgvMovie);
            Food_Controller.DisplayNSearchFood("SELECT * FROM food", dgvFood);
            Showtimes_Controller.DisplayNSearchShowTime("SELECT * FROM showtimes", dgvShowtime);
            
        }
        private void Admin_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            this.StartPosition = FormStartPosition.CenterScreen;
            Display();
           
        } 
        public void Clear()
        {
  //          tbxMovieName.Text = tbxMovieAbout.Text = tbxFoodName.Text = tbxFoodPrice.Text = tbxticketprice.Text = tbxtickettype.Text = String.Empty;
        }
        private void tbnNhanVien_Click(object sender, EventArgs e)
        {
            NhanVien_Info nvi = new NhanVien_Info();
            nvi.Show();
            this.Hide();
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
            this.Hide();
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
                form4.id_showtimes =  dgvShowtime.Rows[e.RowIndex].Cells["ID_Showtime"].Value.ToString();
                form4.id_movie = Convert.ToInt32 (dgvShowtime.Rows[e.RowIndex].Cells["ID_Movie"].Value);
                form4.id_room = Convert.ToInt32(dgvShowtime.Rows[e.RowIndex].Cells["ID_Room"].Value);
                form4.name = dgvShowtime.Rows[e.RowIndex].Cells["MovieName"].Value.ToString();
                form4.date = dgvShowtime.Rows[e.RowIndex].Cells["DATE"].Value.ToString();
                form4.time = dgvShowtime.Rows[e.RowIndex].Cells["TIME"].Value.ToString();
               
                form4.update_info();
                form4.ShowDialog();
                this.Refresh();
                return;
            }
            if (e.ColumnIndex == 1)
            {
                if (MessageBox.Show("Do you want to delete ?", "Informatioon", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    Showtimes_Controller.Delete_Showtime( dgvShowtime.Rows[e.RowIndex].Cells[2].Value.ToString());
                    Display();
                }
                return;
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
           
            MainForm mF = new MainForm();
            mF.Show();
            this.Hide();
        }

      
    }
}
