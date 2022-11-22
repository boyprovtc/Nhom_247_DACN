using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhom_247.Model
{
    class Showtimes_Model
    {
        public string ID_Movie { get; set; }
       public string ID_Room { get; set; }
        public string   MovieName { get; set; }
        public string DATE { get; set; }
        public string  TIME { get; set; }

        public Showtimes_Model(string iD_Movie, string iD_Room, string movieName,  string dATE, string tIME)
        {
            ID_Movie = iD_Movie;
            ID_Room = iD_Room;
            MovieName = movieName;
            DATE = dATE;
            TIME = tIME;
        }
    }
}
