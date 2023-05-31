using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.Classes
{
    public class Property
    {
        private string _name;
        private string _address;
        private HousingType _housingType;
        private decimal _priceNight;
        private string _description;
        private int _rooms;
        private int _id;
        private bool _isAvailable = true;
        private string _city;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string City
        {
            get { return _city; }
            set { _city = value; }
        }

        public bool IsAvailable
        {
            get { return _isAvailable; }
            set { _isAvailable = value; }
        }
       
        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }

        public HousingType HousingType
        {
            get { return _housingType; }
            set { _housingType = value; }
        }

        public decimal PriceNight
        {
            get { return _priceNight; }
            set { _priceNight = value; }
        }

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public int PeopleCapacity
        {
            get { return _rooms; }
            set { _rooms = value; }
        }
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

       // public bool IsBooked { get; set; }
        public Property(string name, string address, HousingType type, decimal pricePerNight, string description, int peopleCapacity, string city)
        {
            Name = name;
            Address = address;
            HousingType = type;
            PriceNight = pricePerNight;
            Description = description;
            PeopleCapacity = peopleCapacity;
            City = city;
        }
        public Property()
        {
        }
    }
}
