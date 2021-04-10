using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetCare
{
	public class PetRegistrationForm : IForm
    {
		public void Create(Customer Acc)
		{
			Console.WriteLine();
			Console.WriteLine("==== Pet Registration Form ====");

			Console.WriteLine("Select the type of your animal:");
			Console.WriteLine("\t1. Dog");
			Console.WriteLine("\t2. Cat");
			Console.Write("Input: ");
			string animal = Console.ReadLine().ToLower();

			if (animal == "1" || animal == "dog")
			{
				DogRegistrationForm dogreg = new DogRegistrationForm();
				dogreg.Create(Acc);
			}
			else if (animal == "2" || animal == "cat")
            {
				CatRegistrationForm catreg = new CatRegistrationForm();
				catreg.Create(Acc);
			}
			else
            {
				ColoredText.Red("Input is invalid.");
            }
		}

    }
}
