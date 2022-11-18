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

namespace Nhom_247.View.Admin_Area
{
    public partial class Movie : Form
    {
        private readonly FormAdmin _parent;
        public Movie(FormAdmin parent)
        {
            InitializeComponent();
            _parent = parent;
        }
        public string id, name, description;

        private void btn_addMovie_Click(object sender, EventArgs e)
        {
            if (tbxMovieName.Text.Trim().Length < 1)
            {
                MessageBox.Show("MovieName is empty");
                return;
            }
            if (tbxMovieAbout.Text.Trim().Length < 1)
            {
                MessageBox.Show("Description is empty");
                return;
            }

            if (btn_addMovie.Text == "Save")
            {
                Movie_Model mv = new  Movie_Model(tbxMovieName.Text.Trim(),tbxMovieAbout.Text.Trim());
                Movie_Controller.add_Movie(mv);
                Clear();

            }
            if (btn_addMovie.Text == "Update")
            {

                Movie_Model mv = new Movie_Model(tbxMovieName.Text.Trim(), tbxMovieAbout.Text.Trim());
                Movie_Controller.update_Movie(mv,id);
                Clear();

            }
            _parent.Display();
        }

        private void Movie_Load(object sender, EventArgs e)
        {
            tbxIDMovie.ReadOnly = true;
        }

        public void Clear()
        {
            btn_addMovie.Text = "Save";
            tbxIDMovie.Text = tbxMovieName.Text = tbxMovieAbout.Text = String.Empty;
        }
        public void update_info()
        {
            btn_addMovie.Text = "Update";
            tbxIDMovie.Text = id;
            tbxMovieName.Text = name;
            tbxMovieAbout.Text = description;
        }

    }
}
