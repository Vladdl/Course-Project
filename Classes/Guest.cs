using Course.Classes;
using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.Classes
{
    public class Guest 
    {
     
        public RegistredUser Registration(string name, string surname, string login, string password)
        {
              
           RegistredUserRepos registredUserRepos = new RegistredUserRepos();   
 
           return registredUserRepos.RegistredUser(name, surname, login,password);
        }
        public  RegistredUser LogIn(string login, string password)
        {

            RegistredUserRepos userRepo = new RegistredUserRepos();
            RegistredUser user = userRepo.GetRegistredUserByUsername(login);

            if (user != null && user.Password == password)
            {
              
                return user;
            }
            else
            {
                
                return null;
            }
        }

        public List<Property> ViewProperties()
        {
            List<Property> freeProperties = new List<Property>();
            var properties = PropertyRepos.GetAllProperties();

            foreach (var property in properties)
            {
                if (property.IsAvailable)
                {
                    freeProperties.Add(property);
                }
            }

            return freeProperties;
        }
    }
}
