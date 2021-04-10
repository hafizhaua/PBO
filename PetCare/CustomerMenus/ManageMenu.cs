using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetCare
{
    class ManageMenu : CustomerMenuAbstract
    {
        public override void Show(Customer Acc)
        {
			while (true)
			{
				Console.WriteLine("Manage Pet List =========");
				PetListShow.ShowAll(Acc.UserPets);

				Console.WriteLine("Option:");
				Console.WriteLine("\ta. Add pet");
				Console.WriteLine("\tb. See details");
				Console.WriteLine("\tc. Remove pet");
				Console.WriteLine("\td. Back");
				Console.Write("Input: ");
				string opt = Console.ReadLine().ToLower();

				if (opt == "a")
				{
					PetRegistrationForm regform = new PetRegistrationForm();
					regform.Create(Acc);
				}
				else if (opt == "b")
				{
					PetDetails.SeeDetails(Acc.UserPets);
				}
				else if (opt == "c")
				{
					PetRemoval.RemovePet(Acc.UserPets);
				}
				else if (opt == "d")
				{
					Console.WriteLine();
					break;
				} else
                {
					ColoredText.Red("Input is invalid.");
				}
			}
		}
    }
}
