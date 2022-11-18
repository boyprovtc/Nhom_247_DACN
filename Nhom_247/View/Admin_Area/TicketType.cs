using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nhom_247.Controller;
using Nhom_247.Model;
using System.Xml.Linq;
using Nhom_247.View.Admin;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
namespace Nhom_247.View.Admin
{
    public partial class TicketType : Form
    {
        private readonly FormAdmin _parent;
        public string id, type, price;
        public TicketType(FormAdmin parent)
        {
            InitializeComponent();
            _parent = parent;
        }
        public void Clear()
        {
            btnTicketTypeAdd.Text = "Save";
            tbxIDTypeTicket.Text = tbxtickettype.Text = tbxtickettypeprice.Text =  String.Empty;
        }
        public void update_info()
        {
            btnTicketTypeAdd.Text = "Update";
            tbxIDTypeTicket.Text = id;
            tbxtickettype.Text = type;
            tbxtickettypeprice.Text = price;
        }
        private void btnTicketTypeAdd_Click(object sender, EventArgs e)
        {
            if (tbxtickettype.Text.Trim().Length < 1)
            {
                MessageBox.Show("Type is empty");
                return;
            }
            if (tbxtickettypeprice.Text.Trim().Length < 1)
            {
                MessageBox.Show("Price is empty");
                return;
            }
           
            if (btnTicketTypeAdd.Text == "Save")
            {
                Ticket_Model tk = new Ticket_Model(tbxtickettype.Text.Trim(), tbxtickettypeprice.Text.Trim());
                Ticket_Controller.add_Ticket(tk);
                Clear();

            }
            if (btnTicketTypeAdd.Text == "Update")
            {
                Ticket_Model tk = new Ticket_Model(tbxtickettype.Text.Trim(), tbxtickettypeprice.Text.Trim());
                Ticket_Controller.update_Ticket(tk,id);
                Clear();

            }
            _parent.Display();
        }
    }
}
