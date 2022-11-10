using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhom_247.Model
{
    class Seat_Model
    {
       
        public char Row { get; set; }
        public int Columm { get; set; }

        public Seat_Model( char row, int columm)
        {
           
            Row = row;
            Columm = columm;
        }
    }
}
