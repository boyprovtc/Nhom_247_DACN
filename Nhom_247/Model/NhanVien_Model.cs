using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhom_247.Model
{
    class NhanVien_Model
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Gmail { get; set; }

        public NhanVien_Model(string name, string phone, string gmail)
        {
            Name = name;
            Phone = phone;
            Gmail = gmail;
        }

        //public NhanVien (string name, string phone, string gmail)
        //{
        //    Name = name;
        //    Phone = phone;
        //    Gmail = gmail;
        //}
    }


}
