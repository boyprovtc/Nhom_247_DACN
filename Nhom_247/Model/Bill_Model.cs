using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhom_247.Model
{
    class Bill_Model
    {
       
        public string ID_Bill { get; set; }
        public string Room { get; set; }
        public string MovieName { get; set; }
        public string Time { get; set; }
        public string Date { get; set; }
        public string Total { get; set; }
        public string TicketDate { get; set; }

        public Bill_Model(string iD_Bill, string room, string movieName, string time, string date, string total, string ticketDate)
        {
            ID_Bill = iD_Bill;
            Room = room;
            MovieName = movieName;
            Time = time;
            Date = date;
            Total = total;
            TicketDate = ticketDate;
        }
    }
}
