using Nhom_247.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom_247.View.Admin_Area
{
    public partial class Room_info : Form
    {
        Room form;
        public Room_info()
        {
            InitializeComponent();
            form = new Room(this);
        }
       
       
       
        public void Display()
        {
            Room_Controller.DisplayNSearch("SELECT * FROM room", dgvRoom);
        }
       
       

        private void btnNew_Click_1(object sender, EventArgs e)
        {
            form.Clear();
            form.ShowDialog();
        }

        private void dgvRoom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                form.Clear();
                form.id = dgvRoom.Rows[e.RowIndex].Cells["ID_Room"].Value.ToString();
                form.number = dgvRoom.Rows[e.RowIndex].Cells["RoomNumber"].Value.ToString();
                form.update_info();
                form.ShowDialog();
                return;
            }
            if (e.ColumnIndex == 1)
            {
                if (MessageBox.Show("Do you want to delete ?", "Informatioon", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    Room_Controller.Delete_Room(dgvRoom.Rows[e.RowIndex].Cells[2].Value.ToString());
                    Display();
                }
                return;
            }
        }

        private void Room_info_Shown(object sender, EventArgs e)
        {
            Display();

        }
    }
}
