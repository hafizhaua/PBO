using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetCare
{
    public static class PetListShow
    {
		public static void ShowAll(List<Pet> UserPets)
		{
			if (UserPets.Count > 0) Console.WriteLine("\nYou have {0} pet(s) on the list!", UserPets.Count);
			else Console.WriteLine("Your list is empty.");
			Console.WriteLine("+-----+---------+--------+--------+");
			Console.WriteLine("| No. | Name    | Animal | ID     |");
			Console.WriteLine("+-----+---------+--------+--------+");
			int i = 1;
			foreach (var pet in UserPets)
			{
				Console.Write($"| {i,3} | {pet.Name,7} | {pet.Animal,6} | {pet.PetID,6} |\n");
				i++;
			}
			Console.WriteLine("+-----+---------+--------+--------+");
		}
	}
}
