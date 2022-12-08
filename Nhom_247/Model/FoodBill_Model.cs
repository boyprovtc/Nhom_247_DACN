using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhom_247.Model
{
    class FoodBill_Model
    {
        public int ID_Food { get; set; }
        public string FoodName { get; set; }
        public double Price { get; set; }
       
        public string FoodTicketDate { get; set; }

        public FoodBill_Model(int iD_Food, string foodName, double price, string foodTicketDate)
        {
            ID_Food = iD_Food;
            FoodName = foodName;
            Price = price;
            FoodTicketDate = foodTicketDate;
        }
    }
}
