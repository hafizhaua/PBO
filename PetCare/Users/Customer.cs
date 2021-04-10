using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetCare
{
    public class Customer : IUser
    {
        public List<Pet> UserPets { get; set; } = new List<Pet>();
        public List<Reservation> UserReservation { get; set; } = new List<Reservation>();
        public string CustomerID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public Customer(string username, string password, int ID)
        {
            Username = username;
            Password = password;
            CustomerID = $"CT-{ID}";
        }

        
    }
}
