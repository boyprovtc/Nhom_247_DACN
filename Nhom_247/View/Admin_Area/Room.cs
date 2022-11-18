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
using System.Xml.Linq;

namespace Nhom_247.View.Admin_Area
{
    public partial class Room : Form
    {
        private readonly Room_info _parent;
        public string id, number;
        public Room(Room_info parent)
        {
            InitializeComponent();
            _parent = parent;
        }






        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Clear();
        }

        public void Clear()
        {
            btnAdd_Room.Text = "Save";
            tbxID_Room.Text = tbxRoomNumber.Text = String.Empty;
        }

        public void update_info()
        {
            btnAdd_Room.Text = "Update";
            tbxID_Room.Text = id;
            tbxRoomNumber.Text = number;


        }

        private void Room_Load(object sender, EventArgs e)
        {
            tbxID_Room.ReadOnly = true;
        }

        private void btnAdd_Room_Click(object sender, EventArgs e)
        {
            if (tbxRoomNumber.Text.Trim().Length < 1)
            {
                MessageBox.Show("Room number is empty");
                return;
            }
            if (btnAdd_Room.Text == "Save")
            {
                Room_Model r = new Room_Model(tbxRoomNumber.Text.Trim());
                Room_Controller.add_Room(r);
                Clear();

            }
            if (btnAdd_Room.Text == "Update")
            {
                Room_Model r = new Room_Model(tbxRoomNumber.Text.Trim());
                Room_Controller.update_Room(r, id);
                Clear();

            }
            _parent.Display();
        }

        private void btnRefresh_Click_1(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
