using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Windows.Forms;

namespace Course.Classes
{
     public  class BookingRepos
     {
        private static List<Booking> bookings = new List<Booking>();
        private string path = "Property.json";
        private static int bookingId = 1;
        public void AddBooking(Booking booking)
        {
            booking.Id = bookingId;
            bookingId++;
            bookings.Add(booking);
           // SavingTheBooking(bookings, path);
        }
        public static void SavingTheBooking(string path)
        {

            string jsonstring = "";
        
            foreach (var user in bookings)
            {
                jsonstring += JsonSerializer.Serialize(user);
                jsonstring += "\n";
            }
            if (jsonstring != "")
                File.WriteAllText(path, jsonstring);
            else
                File.WriteAllText(path, jsonstring);
        }
        public static void ReadTheBooking(string path)
        {
          
            if (File.ReadLines(path).ToList() == null)
                bookings = null;

            List<string> lines = new List<string>();
            bookings.Clear();
            lines = File.ReadLines(path).ToList();
            foreach (string line in lines)
            {
                Booking? user;
                user = JsonSerializer.Deserialize<Booking>(line);
                bookingId = user.Id + 1;
                bookings.Add(user);


            }



        }
        public void RemoveBooking(Booking booking)
        {
            bookings.Remove(booking);
            
            Property property = PropertyRepos.GetAllProperties().FirstOrDefault(p => p.Name == booking.Property);
            if (property != null)
            {
                property.IsAvailable = true;
                // Сохраните обновленные данные жилья
                PropertyRepos.SavingTheProperty(path);
            }

        }
        public static List<Booking> GetAllBookings()
        {
            return bookings;
        }
        public Booking GetBookingById(int bookingId)
        {
            return BookingRepos.GetAllBookings().FirstOrDefault(b => b.Id == bookingId);
        }
        public List<Booking> GetUserBookings(RegistredUser user)
        {
            List<Booking> userBookings = new List<Booking>();
            
            foreach (Booking booking in BookingRepos.GetAllBookings())
            {
                if (booking.User == user.Login)
                {
                    userBookings.Add(booking);
                }
            }
            return userBookings;
        }
     }
}
