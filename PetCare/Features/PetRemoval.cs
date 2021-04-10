using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetCare
{
	public static class PetRemoval
    {
		public static void RemovePet(List<Pet> UserPets)
		{
			if (UserPets.Count > 0)
			{
				Console.Write($"Input pet number (1-{UserPets.Count}): ");
				int idxRemove = Convert.ToInt32(Console.ReadLine());
				if (idxRemove >= 1 && idxRemove <= UserPets.Count)
				{
					
					ColoredText.Yellow($"Bye-bye {UserPets[idxRemove - 1].Name}..");
					UserPets.RemoveAt(idxRemove - 1);
				}
				else
				{
					ColoredText.Red("Number is out of range! Failed to remove.");
				}
			}
			else
			{
				Console.WriteLine("List is empty.");
			}
			Console.ReadLine();
			Console.WriteLine();
		}
	}
}
