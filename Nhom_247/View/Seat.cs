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

namespace Nhom_247.View
{
    public partial class Seat : Form
    {
        public Seat()
        {
            InitializeComponent();
        }
        public void Clear()
        {
            tbxRow.Text = tbxColumm.Text = String.Empty;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tbxRow.Text.Trim().Length < 1)
            {
                MessageBox.Show("Row is empty");
                return;
            }
            if (tbxColumm.Text.Trim().Length < 1)
            {
                MessageBox.Show("Columm is empty");
                return;
            }
           
            if (btnAdd.Text == "Add")
            {
                //Seat_Model seat = new Seat_Model(tbxRow.Text.Trim(), tbxColumm.Text.Trim());
                //Seat_Controller.add_Seat(seat);
                //Clear();

            }
        }
    }
}
