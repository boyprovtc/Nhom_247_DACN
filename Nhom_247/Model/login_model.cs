using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhom_247.Model
{
     class login_model
    {
        public string user { get; set; }
        public string pass { get; set; }

        public login_model(string user, string pass)
        {
            this.user = user;
            this.pass = pass;
        }
    }
}
