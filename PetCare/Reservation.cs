using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetCare
{
    public class Reservation
    {
        public Reservation(string services, int price, int period, Pet pet, Customer user)
        {
            Random ID = new Random();
            ReservationID = $"RS-{ID.Next(100, 999)}";
            Services = services;
            Price = price;
            Pet = pet;
            User = user;
        }

        public string ReservationID { get; set; }
        public string Services { get; set; }
        public int Price { get; set; }
        public int Period { get; set; }
        public Pet Pet { get; set; }
        public Customer User { get; set; }
        
    }
}
