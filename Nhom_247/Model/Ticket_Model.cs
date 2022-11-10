using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhom_247.Model
{
    class Ticket_Model
    {
        public string TicketType { get; set; }
        public string TicketPrice { get; set; }

        public Ticket_Model(string ticketType, string ticketPrice)
        {
            TicketType = ticketType;
            TicketPrice = ticketPrice;
        }
    }
}
