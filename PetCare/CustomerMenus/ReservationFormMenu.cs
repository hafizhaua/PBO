using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetCare
{
    class ReservationFormMenu : CustomerMenuAbstract
    {
        public override void Show(Customer CustAcc)
        {
            while (true)
            {
                Console.WriteLine("Pet Care Reservation =========");
                PetListShow.ShowAll(CustAcc.UserPets);

                Console.WriteLine("Select pet for the services:");
                Console.WriteLine("\ta. Select from the menu");
                Console.WriteLine("\tb. Register another pet");
                Console.WriteLine("\tc. Back");
                Console.Write("Input: ");
                string opt = Console.ReadLine().ToLower();

                if (opt == "a" && CustAcc.UserPets.Count > 0)
                {
                    Console.Write("Input the number (No.) of the pet: ");
                    int idxDeposit = Convert.ToInt32(Console.ReadLine());
                    if (idxDeposit >= 1 && idxDeposit <= CustAcc.UserPets.Count)
                    {
                        PetReservationForm.Create(CustAcc, CustAcc.UserPets[idxDeposit-1]);
                    } 
                    else
                    {
                        ColoredText.Red("Input is invalid.");
                    }
                }
                else if (opt == "b")
                {
                    PetRegistrationForm regform = new PetRegistrationForm();
                    regform.Create(CustAcc);
                }
                else if (opt == "c")
                {
                    Console.WriteLine();
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
