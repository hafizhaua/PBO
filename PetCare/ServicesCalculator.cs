using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetCare
{
    public static class ServicesCalculator
    {
        public static int CalculatePetHotelPrice(Pet pet)
        {
            int scale = Convert.ToInt32(pet.Weight)/5;
            int price = 70000 + scale * 25000;
            return price;
        }
    }
}
