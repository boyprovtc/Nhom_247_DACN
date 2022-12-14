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
using Catel.Collections;
using MySql.Data.MySqlClient;
using Nhom_247.Controller;
using Nhom_247.Model;
using Nhom_247.Report;
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
            tblTicketDetails.Columns.Add("ID_Ticket", typeof(string));
            tblTicketDetails.Columns.Add("Seat_Number", typeof(int));
            tblTicketDetails.Columns.Add("Price", typeof(double));


        }
        public void Display()
        {
            Showtimes_Controller.DisplayNSearchShowTime("SELECT * FROM Showtimes", dgvShowtime);
            Food_Controller.DisplayNSearchFood("Select * from food", dgvFood);
            Bill_Controller.DisplayNSearchBill("SELECT ID_bill,ID_Seat,Room,MovieName FROM bill", dgvTicket);
            Bill_Controller.DisplayNSearchBill("SELECT * FROM bill", dgvBillDetails);
            FoodBill_Controller.DisplayNSearchBill("SELECT * FROM foodbill", dgvFoodBill);
        }
        private void KhoiTaoGhe()
        {

            
            Button btnGhe;
            
            try
            {
                
                MySqlConnection connection = new MySqlConnection("datasource = localhost; port=3306; username=root; password=;database=247_rapphim");
                MySqlConnection connection2 = new MySqlConnection("datasource = localhost; port=3306; username=root; password=;database=247_rapphim");

                string selectQuery = "select * from seat";
                string selectQuery2 = "select * from bill";
                connection.Open();
                connection2.Open();
                MySqlCommand cmd = new MySqlCommand(selectQuery, connection);
                MySqlCommand cmd2 = new MySqlCommand(selectQuery2, connection2);
                

                MySqlDataReader reader = cmd.ExecuteReader();
                MySqlDataReader reader2 = cmd2.ExecuteReader();
                List<int> list = new List<int>();

                while (reader2.Read())
                {
                    for (int i = 0; i < Convert.ToInt32(reader2.GetString("ID_Seat")); i++)
                    {
                        list.Add(Convert.ToInt32(reader2.GetString("ID_Seat")));

                    }
                }
                int[] a = list.ToArray();
                while (reader.Read())
                {

                    btnGhe = new Button();
                    btnGhe.Size = new Size(40, 40);
                    btnGhe.Text = reader.GetString("ID_Seat");
                    btnGhe.BackColor = Color.AliceBlue;
                    btnGhe.Click += Bt_Click;

                    for (int i = 0; i < Convert.ToInt32(reader.GetString("ID_Seat")); i++)
                    {
                        if (btnGhe.Text == a[i].ToString())
                        {

                            btnGhe.Enabled = false;
                            btnGhe.BackColor = Color.Yellow;


                        }
                    }
                    pnMain.Controls.Add(btnGhe);
                }

                connection2.Close();
                connection.Close(); 
            }
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
            tbxID_Food.Enabled = false;
            
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
            KhoiTaoGhe();
            LoadToComboBox();
        }

        private void Bt_Click(object sender, EventArgs e)
        {
            Button btnGhe = (Button)sender;
            tbxNumber.Text = btnGhe.Text + " ";

            if (btnGhe.BackColor == Color.Yellow)
            {
                MessageBox.Show("Ghế này đã được mua!");
                return;
            }
            if (btnGhe.BackColor == Color.Blue)
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
            if (tbxNumber.Text == "")
            {
                MessageBox.Show("Vui  lòng chọn chỗ ngồi");
                return;

            }
            Bill_Model b = new Bill_Model(tbxNumber.Text.Trim(), tbxRoom.Text.Trim(), tbxMovieName.Text.Trim(), tbxTime.Text.Trim(), tbxMovieDate.Text.Trim(), tbxTotal.Text.Trim(), dtpBill.Text.Trim());
            Bill_Controller.add_Bill(b);
            Display();

        }

        public double TinhTien(int vitriGhe){
            if (vitriGhe <=60)
            {
                return 60000;
            }
            if (vitriGhe <= 80)
            {
                return 80000;
            }
            else
            {
                return 100000;
            }

        }
        private void dgvTicket_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            //tbxID_Bill.Text = dgvTicket.Rows[e.RowIndex].Cells[0].Value.ToString();
            
        }

       

        private void dgvShowtime_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxRoom.Text = dgvShowtime.Rows[e.RowIndex].Cells[2].Value.ToString();
            tbxMovieName.Text = dgvShowtime.Rows[e.RowIndex].Cells[3].Value.ToString();
            tbxTime.Text = dgvShowtime.Rows[e.RowIndex].Cells[4].Value.ToString();
            tbxMovieDate.Text = dgvShowtime.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

     

        private void cbxMovieSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            Showtimes_Controller.DisplayNSearchShowTime("select * from showtimes where MovieName like '%" + cbxMovieSelect.Text + "%'", dgvShowtime);
        }

        private void btnPrintReport_Click(object sender, EventArgs e)
        {
            FormReport rp = new FormReport();
            rp.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tbxFoodName.Text == "")
            {
                MessageBox.Show("Vui  lòng chọn combo");
                return;
            }
            if (tbxPrice.Text == "")
            {
                MessageBox.Show("Vui  lòng chọn combo");
                return;

            }
            FoodBill_Model b = new FoodBill_Model(  Convert.ToInt32(tbxID_Food.Text.Trim()),tbxFoodName.Text.Trim(),Convert.ToInt32 (tbxPrice.Text.Trim()),dtpBill.Text.Trim());
            FoodBill_Controller.add_Bill(b);
            Display();
        }

        private void dgvFood_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxID_Food.Text = dgvFood.Rows[e.RowIndex].Cells[0].Value.ToString();
          tbxFoodName.Text = dgvFood.Rows[e.RowIndex].Cells[1].Value.ToString();
            tbxPrice.Text = dgvFood.Rows[e.RowIndex].Cells[2].Value.ToString();
        }
    }
}
