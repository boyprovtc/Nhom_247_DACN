using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhom_247.Model
{
     class Movie_Model
    {
        public string MovieName    { get; set; }
        public string MovieAbout { get; set; }

        public Movie_Model(string movieName, string movieAbout)
        {
            MovieName = movieName;
            MovieAbout = movieAbout;
        }
    }
}
