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
       
        public int  a = 60000, b = 80000, c =100000;
        public MainForm()
        {
            InitializeComponent();
        }
        public void Display()
        {
            Showtimes_Controller.DisplayNSearchShowTime("SELECT * FROM Showtimes", dgvShowtime);
            Food_Controller.DisplayNSearchFood("Select * from food", dgvFood);
            
        }
        private void KhoiTaoGhe()
        {
            
            int Top = 0; //Vi tri Top
            for (char i = 'A'; i <= 'J'; i++)
            {
                int Left = 0; //Vi tri Left
                for (int j = 1; j <= 10; j++)
                {
                    //Taoj 1 button mới
                    Button bt = new Button();
                    //Thêm thuộc tính
                    bt.Name = string.Format("bt{0}{1}", i, j);
                    bt.Tag = string.Format("[{0}{1}]", i, j);
                    bt.Text = string.Format("{0}{1}", i, j);
                    bt.Size = new Size(40, 40);

                    bt.Top = Top;
                    bt.Left = Left;

                    Left += 50;

                    bt.BackColor = Color.AliceBlue;
                    bt.ForeColor = Color.Black;
                    if (i>='E' && i<='G')
                    {
                        
                        bt.BackColor = Color.Yellow;
                        bt.ForeColor = Color.Black;
                    }
                    if (i > 'G')
                    {
                        bt.BackColor = Color.Orange;
                        bt.ForeColor = Color.Black;

                    }

                    //Phải thêm nút vào panel để hiển thị luôn
                    pnMain.Controls.Add(bt);
                    bt.Click += Bt_Click;
                }
                Top += 50;
            }
        }
        private void Edit_Stuff()
        {
            cbxPriceTicket.Enabled = false;
            pnMain.Size = new Size(465, 510);
            pnMain.BorderStyle = BorderStyle.FixedSingle;
            WindowState = FormWindowState.Maximized;
            adminToolStripMenuItem.Enabled = false;
            tbxAdminCode.PasswordChar = '*';
            tbxMovieName.ReadOnly = true;
            tbxRoom.ReadOnly = true;
            tbxRow.ReadOnly = true;
            tbxTime.ReadOnly = true;
            tbxNumber.ReadOnly = true;
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
            try
            {
                MySqlConnection connection = new MySqlConnection("datasource = localhost; port=3306; username=root; password=;database=247_rapphim");
                string selectQuery = "select * from ticket";
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(selectQuery, connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cbxTicket.Items.Add(reader.GetString("TicketType"));
                    cbxPriceTicket.Items.Add(reader.GetString("TicketPrice"));

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
            Button btn = (Button)sender;
            tbxNumber.Text = btn.Text;
            tbxRow.Text = btn.Text;
            if (btn.BackColor == Color.AliceBlue)
            {
                textBox1.Text = a.ToString();
            }
            else if (btn.BackColor == Color.Yellow)
            {
                textBox1.Text = b.ToString();
            }
            else
            {
                textBox1.Text = c.ToString();
            }
            try
            {
                MySqlConnection connection = new MySqlConnection("datasource = localhost; port=3306; username=root; password=;database=247_rapphim");
                string selectQuery = "select * from seat";
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(selectQuery, connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cbxMovieSelect.Items.Add(reader.GetString("MovieName"));
                    tbxRow.Text = reader.GetString("Row");

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            if (btn.BackColor == Color.Brown)
            {
                MessageBox.Show("Ghế này đã được mua!");
                return;
            }
            
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
            cbxPriceTicket.SelectedIndex = cbxTicket.SelectedIndex;
        }

        private void BtnPrintTickey_Click(object sender, EventArgs e)
        {
  
        }

        private void dgvShowtime_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxRoom.Text = dgvShowtime.Rows[e.RowIndex].Cells[2].Value.ToString();
            tbxMovieName.Text = dgvShowtime.Rows[e.RowIndex].Cells[3].Value.ToString();
            tbxTime.Text = dgvShowtime.Rows[e.RowIndex].Cells[5].Value.ToString();
        }
    }
}
