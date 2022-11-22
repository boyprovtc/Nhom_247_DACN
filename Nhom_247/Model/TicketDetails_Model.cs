using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhom_247.Model
{
    class TicketDetails_Model
    {
        public string ID_Ticket { get; set; }
        public string Seatnumber { get; set; }
        public string MovieName { get; set; }
        public string Room { get; set; }
        public string Time { get; set;}

        public TicketDetails_Model(string iD_Ticket, string seatnumber, string movieName, string room, string time)
        {
            ID_Ticket = iD_Ticket;
            Seatnumber = seatnumber;
            MovieName = movieName;
            Room = room;
            Time = time;
        }
    }
}
