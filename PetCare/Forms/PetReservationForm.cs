using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetCare
{
    public static class PetReservationForm
    {
        public static void Create(Customer Acc, Pet pet)
        {
            Console.WriteLine("~~~~ Pet Reservation Form ~~~~");
            Console.WriteLine($"\n{pet.Name}'s biodata:");
            pet.ShowPetDetail();

            Console.WriteLine();
            Console.WriteLine("Select our services:");
            Console.WriteLine($"    1. Pet Hotel");

            Console.Write("Input: ");
            string opt = Console.ReadLine().ToLower();

            if (opt == "1" || opt == "pet hotel") PetHotelServicesForm.Fill(Acc, pet);
        }
    }
}
