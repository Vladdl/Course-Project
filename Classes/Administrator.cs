using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Course.Classes
{
    public class Administrator 
    {
    

        public delegate void Message(Property property);
        public  event Message? _Message;
       
        public List<RegistredUser> ViewUser()
        {
            return RegistredUserRepos.ViewUsers();
        }
        public List<Property> ViewProperties()
        {
            return PropertyRepos.GetAllProperties();
        }
        public List<Booking> ViewBooking()
        {
            return BookingRepos.GetAllBookings();
        }
        public void DeleteUsers(int userId)
        {
            RegistredUser userToDelete = RegistredUserRepos.ViewUsers().FirstOrDefault(u => u.UserId == userId);
            RegistredUserRepos registredUserRepos = new RegistredUserRepos();
            if (userToDelete != null)
            {
                registredUserRepos.RemoveRegistredUser(userToDelete);
            }
        }
     

      
        public void DeleteProperty(int propertyId)
        {
            var property = PropertyRepos.GetPropertyById(propertyId);
            PropertyRepos propertyRepos = new PropertyRepos();
            propertyRepos.RemoveProperty(property);
        }

        public void Messages(Property property)
        {
            _Message.Invoke(property);
        }
       
    }
}
