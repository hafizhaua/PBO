using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetCare
{
	public static class PetDetails
    {
		public static void SeeDetails(List<Pet> UserPets)
		{
			if (UserPets.Count > 0)
			{
				Console.Write($"Input pet number (1-{UserPets.Count}): ");
				int idxDetail = Convert.ToInt32(Console.ReadLine());
				if (idxDetail >= 1 && idxDetail <= UserPets.Count)
				{
					Console.WriteLine($"\nDetails of Pet #{UserPets[idxDetail - 1].PetID}");
					UserPets[idxDetail - 1].ShowPetDetail();
					ColoredText.Yellow("There you go.");
				}
				else
				{
					Console.ForegroundColor = ConsoleColor.Red;
					Console.WriteLine("Number is out of range! Failed to remove.\n");
					Console.ResetColor();
				}
			}
			else
			{
				Console.ForegroundColor = ConsoleColor.Yellow;
				Console.WriteLine("List is empty.");
				Console.ResetColor();
			}
			Console.WriteLine();
		}

	}
}
