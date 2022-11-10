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

namespace Nhom_247
{
    public partial class Admin : Form
    {
        
       
        public Admin()
        {
            InitializeComponent();
        }
        public void Display()
        {
            Movie_Controller.DisplayNSearchMovie("SELECT * FROM tbl_phim", dgvMovie);
            Food_Controller.DisplayNSearchFood("SELECT * FROM food", dgvFood);
            Ticket_Controller.DisplayNSearchTicket("SELECT * FROM ticket", dgvTicket);
        }
        private void Admin_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            dtp.Format = DateTimePickerFormat.Time;
            dtp.ShowUpDown = true;
            Display();
            
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
            tbxMovieName.Text = tbxMovieAbout.Text = tbxFoodName.Text = tbxFoodPrice.Text = tbxticketprice.Text = tbxtickettype.Text = String.Empty;
        }
        private void btn_addMovie_Click(object sender, EventArgs e)
        {
            if (tbxMovieName.Text.Trim().Length < 1)
            {
                MessageBox.Show("Movie Name is empty");
                return;
            }
            if (tbxMovieAbout.Text.Trim().Length < 1)
            {
                MessageBox.Show("About is empty");
                return;
            }

            if (btn_addMovie.Text == "Save")
            {
                Movie_Model mv = new Movie_Model(tbxMovieName.Text.Trim(), tbxMovieAbout.Text.Trim());
                Movie_Controller.add_Movie(mv);
                Clear();

            }
        }

        private void btnFood_add_Click(object sender, EventArgs e)
        {
            if (tbxFoodName.Text.Trim().Length < 1)
            {
                MessageBox.Show("Food Name is empty");
                return;
            }
            if (tbxFoodPrice.Text.Trim().Length < 1)
            {
                MessageBox.Show("Price is empty");
                return;
            }

            if (btnFood_add.Text == "Save")
            {
                Food_Model mv = new Food_Model(tbxFoodName.Text.Trim(), tbxFoodPrice.Text.Trim());
                Food_Controller.add_Food(mv);
                Clear();

            }
        }

        private void btnTicketAdd_Click(object sender, EventArgs e)
        {
            if (tbxtickettype.Text.Trim().Length < 1)
            {
                MessageBox.Show("Ticket Type is empty");
                return;
            }
            if (tbxticketprice.Text.Trim().Length < 1)
            {
                MessageBox.Show("Price is empty");
                return;
            }

            if (btnTicketAdd.Text == "Save")
            {
                Ticket_Model tk = new Ticket_Model(tbxtickettype.Text.Trim(), tbxticketprice.Text.Trim());
                Ticket_Controller.add_Ticket(tk);
                Clear();

            }
        }
    }
}
