using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.Classes
{
    public  interface  IUser
    {
        public string Login { get; set; }
        public string Password { get; set;} 
        public string Name { get; set; }
        public string Surname { get; set; }
        public int UserId { get; set; }

    }
}
