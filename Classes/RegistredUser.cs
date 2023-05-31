using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Course.Classes
{
    public class RegistredUser:User
    {
        
        public override string Name { get; set; }
        public override string Surname { get; set; }
        public override string Login { get; set; }
        public override string Password { get; set; }
        public override int UserId { get; set; }
        public RegistredUser() { }
        public RegistredUser(string firstName, string lastName, string username, string password)
        {
            Name = firstName;
            Surname = lastName;
            Login = username;
            Password = password;
        }

       

        public void BookProperty(Property property, DateTime checkInDate, DateTime checkOutDate, int numberofGuests, RegistredUser user)
        {
            property.IsAvailable = false;
            BookingRepos bookingRepos = new BookingRepos();
       
            Booking newBooking = new Booking(checkInDate, checkOutDate, property, numberofGuests, user);
           
     
            bookingRepos.AddBooking(newBooking);
        }
        public void CancelBooking(int bookingId)
        {
            BookingRepos bookingRepos = new BookingRepos();
            var bookingID = bookingRepos.GetBookingById(bookingId);

           

            bookingRepos.RemoveBooking(bookingID);
        }
        public List<Booking> ViewBooking(RegistredUser user)
        {
            BookingRepos bookingRepos = new BookingRepos();
            List<Booking> userBookings = bookingRepos.GetUserBookings(user);

            return userBookings;
        }
        public List<Property> ViewProperties()
        {
            return PropertyRepos.GetAllProperties();
        }

        public void AddNewProperty(Property property)
        {
            PropertyRepos propertyRepos = new PropertyRepos();  
            

            propertyRepos.AddProperty(property);
        }


    }

}
