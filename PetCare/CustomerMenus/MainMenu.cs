using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetCare
{
    class MainMenu : CustomerMenuAbstract
    {
        public override void Show(Customer Acc)
        {
            while (true)
            {
                Console.WriteLine("=========== PET CARE ==========");
                Console.WriteLine($"Welcome to Pet Care, {Acc.Username}!");
                Console.WriteLine("Choose a menu:");
                Console.WriteLine("\t1. Your Pet List");
                Console.WriteLine("\t2. Reserve a Place");
                Console.WriteLine("\t3. See Reservation");
                Console.WriteLine("\t4. Log Out");

                Console.Write("Input: ");
                string opt = Console.ReadLine();
                Console.WriteLine();

                if (opt == "1")
                {
                    ManageMenu ListMenu = new ManageMenu();
                    ListMenu.Show(Acc);
                }
                else if (opt == "2")
                {
                    ReservationFormMenu reservationFormMenu = new ReservationFormMenu();
                    reservationFormMenu.Show(Acc);
                }
                else if (opt == "3")
                {
                    ReservationStatusMenu reservationStatusMenu = new ReservationStatusMenu();
                    reservationStatusMenu.Show(Acc);
                }
                else if (opt == "4")
                {
                    ColoredText.Yellow("See you again! :)");
                    break;
                }
                else
                {
                    ColoredText.Red("Input is invalid.");
                }
            }
        }
    }
}
