using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhom_247.Model
{
     class Room_Model
    {
        public string RoomNumber { get; set; }
       
        public Room_Model(string roomNumber)
        {
            RoomNumber = roomNumber;
           
        }
    }
}
