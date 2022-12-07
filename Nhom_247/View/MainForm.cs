 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Nhom_247.Controller;
using Nhom_247.Model;
using Nhom_247.View;
using Nhom_247.View.Admin_Area;

namespace Nhom_247
{
    public partial class MainForm : Form
    {
       
        Showtime form4;
        //private int IdTicket;
        private DataTable tblTicketDetails;
        public MainForm()
        {
            InitializeComponent();
            //IdTicket = 1;
            tblTicketDetails = new DataTable();
            tblTicketDetails.Columns.Add("ID_Ticket",typeof(string));
            tblTicketDetails.Columns.Add("Seat_Number", typeof(int));
            tblTicketDetails.Columns.Add("Price", typeof(double));


        }
        public void Display()
        {
            Showtimes_Controller.DisplayNSearchShowTime("SELECT * FROM Showtimes", dgvShowtime);
            Food_Controller.DisplayNSearchFood("Select * from food", dgvFood);
            Bill_Controller.DisplayNSearchBill("SELECT ID_bill,ID_Seat,Room,MovieName FROM bill", dgvTicket);
            Bill_Controller.DisplayNSearchBill("SELECT * FROM bill", dgvBillDetails);

        }
        private void KhoiTaoGhe( int hang, int cot)
        {

            int x, y = 13, khoangcachX = 90, khoangcachY = 50, dem = 1;
            
            Button btnGhe;
            //for (int i = 0; i < hang; i++)
            //{
            //    x = 26;
            //    for (int j = 0; j < cot; j++)
            //    {

            //        btnGhe = new Button();
            //        btnGhe.Location = new Point(x, y);
            //        btnGhe.Size = new Size(40, 40);
            //        btnGhe.Text = dem++.ToString();

            //        btnGhe.BackColor = Color.AliceBlue;
            //        btnGhe.Click += Bt_Click;
            //        pnMain.Controls.Add(btnGhe);
            //        x += khoangcachX;

            //    }
            //    y += khoangcachY;
            //}
            try
            {
                MySqlConnection connection = new MySqlConnection("datasource = localhost; port=3306; username=root; password=;database=247_rapphim");
                string selectQuery = "select * from seat";
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(selectQuery, connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    btnGhe = new Button();
                    
                    btnGhe.Size = new Size(40, 40);
                    btnGhe.Text = reader.GetString("SeatNumber");

                    btnGhe.BackColor = Color.AliceBlue;
                    btnGhe.Click += Bt_Click;
                    pnMain.Controls.Add(btnGhe);
                    
                    


                }
                connection.Close();            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }
        private void Edit_Stuff()
        {
            pnMain.Size = new Size(465, 510);
            pnMain.BorderStyle = BorderStyle.FixedSingle;
            WindowState = FormWindowState.Maximized;
            adminToolStripMenuItem.Enabled = false;
            tbxAdminCode.PasswordChar = '*';
            tbxMovieName.ReadOnly = true;
            tbxRoom.ReadOnly = true;
            tbxTime.ReadOnly = true;
            tbxNumber.ReadOnly = true;
            dtpBill.Enabled = false;
            dtpBill.Format = DateTimePickerFormat.Short;
        }
        private void LoadToComboBox()
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("datasource = localhost; port=3306; username=root; password=;database=247_rapphim");
                string selectQuery = "select * from movie";
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(selectQuery, connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cbxMovieSelect.Items.Add(reader.GetString("MovieName"));


                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }
        
        private void MainForm_Load(object sender, EventArgs e)
        {
            Edit_Stuff();
            Display();
            KhoiTaoGhe(10,10);
            LoadToComboBox();
        }

        private void Bt_Click(object sender, EventArgs e)
        {
            Button btnGhe = (Button)sender;
            tbxNumber.Text = btnGhe.Text+" ";
          
            if (btnGhe.BackColor == Color.Yellow)
            {
                MessageBox.Show("Ghế này đã được mua!");
                return;
            }
            if(btnGhe.BackColor == Color.Blue)
            {
                tbxNumber.Text = string.Empty;
            }    
            btnGhe.BackColor = (btnGhe.BackColor == Color.AliceBlue) ? Color.Blue : Color.AliceBlue;
            
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAdmin ad = new FormAdmin();
            ad.Show();
            this.Hide();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (MessageBox.Show("Bạn Có Muốn Thoát không", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                this.Dispose();
            }
            else return;

        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn Có Muốn Thoát không", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Login login = new Login();
                login.Show();
                this.Hide();
            }
        }

       

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (tbxAdminCode.Text == "210501")
            {
                adminToolStripMenuItem.Enabled = true;
                MessageBox.Show("Welcome Admin");
            }
            else
            {
                MessageBox.Show("You are not Administrator");
            }
        }

        private void cbxTicket_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        

        private void BtnPrintTickey_Click(object sender, EventArgs e)
        {
           
            //tinh tien
            double total = 0;
            double SeatPrice = 0;
            int seatNumber;
            foreach (Button ghe in pnMain.Controls)
            {
                if (ghe.BackColor == Color.Blue)
                {
                    seatNumber = int.Parse(ghe.Text);
                    SeatPrice = TinhTien(seatNumber);
                    total += SeatPrice;
                    ghe.BackColor = Color.Yellow;
                   
                }
            }
            tbxTotal.Text = total.ToString();
            if (tbxMovieName.Text == "")
            {
                MessageBox.Show("Vui  lòng chọn suất chiếu");
                return;
            }
            if(tbxNumber.Text == "")
            {
                MessageBox.Show("Vui  lòng chọn chỗ ngồi");
                return;

            }
            Bill_Model b = new Bill_Model(tbxNumber.Text.Trim(),tbxRoom.Text.Trim(),tbxMovieName.Text.Trim(), tbxTime.Text.Trim(),tbxMovieDate.Text.Trim(),tbxTotal.Text.Trim(),dtpBill.Text.Trim());
            Bill_Controller.add_Bill(b);
            Display();
            
        }
      

        private void dgvTicket_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            //tbxID_Bill.Text = dgvTicket.Rows[e.RowIndex].Cells[0].Value.ToString();
            
        }

        private double TinhTien(int vitriGhe)
        {
            if (vitriGhe <= 40)
            {
                return 60000;
            }
            else if (vitriGhe <= 80)
            {
                return 80000;
            }
            else return 100000;

            //try
            //{
            //    MySqlConnection connection = new MySqlConnection("datasource = localhost; port=3306; username=root; password=;database=247_rapphim");
            //    string selectQuery = "select seat.SeatNumber, seatrow.Price from seat, seatrow where seat.ID_Row = seatrow.ID_Row";
            //    connection.Open();
            //    MySqlCommand cmd = new MySqlCommand(selectQuery, connection);
            //    MySqlDataReader reader = cmd.ExecuteReader();
            //    while (reader.Read())
            //    {
            //        if(reader.GetInt32("seat.SeatNumber") <= 40)
            //        {
            //            return
            //        }


            //    }

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);

            //}
        }

        private void dgvShowtime_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxRoom.Text = dgvShowtime.Rows[e.RowIndex].Cells[2].Value.ToString();
            tbxMovieName.Text = dgvShowtime.Rows[e.RowIndex].Cells[3].Value.ToString();
            tbxTime.Text = dgvShowtime.Rows[e.RowIndex].Cells[4].Value.ToString();
            tbxMovieDate.Text = dgvShowtime.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            //BillDetails_Model bd = new BillDetails_Model(tbxID_Bill.Text.Trim());
            //BillDetails_Controller.add_BillDetails(bd);
            //Display();

        }

        private void cbxMovieSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            Showtimes_Controller.DisplayNSearchShowTime("select * from showtimes where MovieName like '%" + cbxMovieSelect.Text + "%'", dgvShowtime);
        }

      
    }
}
