using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.Classes
{
    public class Booking
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
  
        public string Property { get; set; }
        public decimal PriceNight { get; set; }
        public int PeopleCapacity { get; set; }
     
        public decimal TotalCost { get; set; }
        public string User { get; set; }
        public int Id { get; set; } 
        public Booking(DateTime startDate, DateTime endDate, Property property, int peopleCapacity, RegistredUser user)
        {
            PeopleCapacity = peopleCapacity;
            StartDate = startDate;
            EndDate = endDate;
            Property = property.Name;
            User = user.Login;
            PriceNight = property.PriceNight;
            CalculateBookingCost();
        }
        public Booking() { }
        
        public void CalculateBookingCost()
        {
            int duration = (EndDate - StartDate).Days;
            decimal totalCost = duration * PriceNight;
            TotalCost = totalCost;
        }
        
    }
}
