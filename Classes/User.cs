using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.Classes
{
    public abstract class User : IUser
    {
        public abstract string Name { get; set; }
        public abstract string Surname { get; set; }
        public abstract string Login { get; set; }
        public abstract string Password { get; set; }
        public abstract int UserId { get; set; }
       
    
      
    }
}
