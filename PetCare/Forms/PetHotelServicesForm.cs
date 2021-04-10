using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetCare
{
    public static class PetHotelServicesForm
    {
        public static void Fill(Customer customer, Pet pet)
        {
            int PricePerDay = ServicesCalculator.CalculatePetHotelPrice(pet);
            DateTime startDate, endDate;
            DateTime now = DateTime.Today;
            
            Console.Write("\nEnter start date (MM/DD/YY): ");
            if (!DateTime.TryParse(Console.ReadLine(), out startDate)) ColoredText.Red("Invalid value.");

            Console.Write("Enter pickup date (MM/DD/YY): ");
            if (!DateTime.TryParse(Console.ReadLine(), out endDate)) ColoredText.Red("Invalid value.");

            int period = (endDate - startDate).Days;

            if (period > 0 && startDate >= now)
            {
                int totalPrice = PricePerDay * period;
                Console.WriteLine($"You plan to reserve {period} day(s) of pet boarding for IDR {totalPrice}");
                Console.Write("Proceed? (y/n) ");
                if(Console.ReadLine() == "y")
                {
                    customer.UserReservation.Add(
                        new Reservation("Hotel", totalPrice, period, pet, customer)
                    );

                    ColoredText.Yellow("Reservation reserved successfully");
                } else
                {
                    ColoredText.Yellow("Reservation canceled.");
                }
            }
            else
            {
                ColoredText.Red("Invalid date.");
            }
        }
    }
}
