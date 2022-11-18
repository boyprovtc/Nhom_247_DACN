
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Nhom_247.View.Admin_Area
{
    public partial class Food : Form
    {
        private readonly FormAdmin _parent;
        public Food(FormAdmin parent)
        {
            InitializeComponent();
            _parent = parent;
        }
        //IFirebaseConfig config = new FirebaseConfig
        //{
        //    AuthSecret = "FrjitzEfYNMvVSGqL0HcMXI8PaH20d3PxxWNB6dk",
        //    BasePath = "https://console.firebase.google.com/u/0/project/rapphim-d0389/database/rapphim-d0389-default-rtdb/data/~2F"
        //};
        public string id, name, price;
       
        public void Clear()
        {
            btnFood_add.Text = "Save";
            tbxFoodID.Text = tbxFoodName.Text = tbxFoodPrice.Text = String.Empty;
        }

        private void Food_Load(object sender, EventArgs e)
        {
           // tbxFoodID.ReadOnly = Enabled;
        }

        private async void btnFood_add_Click(object sender, EventArgs e)
        {
            if (tbxFoodName.Text.Trim().Length < 1)
            {
                MessageBox.Show("FoodName is empty");
                return;
            }
            if (tbxFoodPrice.Text.Trim().Length < 1)
            {
                MessageBox.Show("Price is empty");
                return;
            }

            if (btnFood_add.Text == "Save")
            {
                Food_Model f = new Food_Model(tbxFoodName.Text.Trim(), tbxFoodPrice.Text.Trim());
                Food_Controller.add_Food(f);
                Clear();

            }
            if (btnFood_add.Text == "Update")
            {
                Food_Model f = new Food_Model(tbxFoodName.Text.Trim(), tbxFoodPrice.Text.Trim());
                Food_Controller.update_Food(f, id);
                Clear();

            }

            _parent.Display();
        }

        public void update_info()
        {
            btnFood_add.Text = "Update";
            tbxFoodID.Text = id;
            tbxFoodName.Text = name;
            tbxFoodPrice.Text = price;
        }
       
    }
}
