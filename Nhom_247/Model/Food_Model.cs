using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhom_247.Model
{
   class Food_Model
    {

        public string NameFood { get; set; }
        public string Price { get; set; }

        public Food_Model(string nameFood, string price)
        {
            NameFood = nameFood;
            Price = price;
        }
    }
}
