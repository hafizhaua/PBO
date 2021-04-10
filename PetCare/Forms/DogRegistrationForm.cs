using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetCare
{
    public class DogRegistrationForm : IPetRegistrationForm
    {
        public string FillAnimal { get; set; }
        public string FillName { get; set; }
        public string FillPetID { get; set; }
        public string FillSex { get; set; }
        public double FillWeight { get; set; }

        public void Create(Customer Acc)
		{
			Console.Write("Name (max 7 letters): ");
			FillName = Console.ReadLine();
			if (FillName.Length > 7)
			{
				ColoredText.Red("Name is too long. terminating process..");
				return;
			}

			Console.Write("Sex (Male/Female): ");
			string FillSex = Console.ReadLine().ToLower();
			if (FillSex != "male" && FillSex != "female")
			{
				ColoredText.Red($"Sex '{FillSex}' is invalid.");
				return;
			}

			double FillWeight = 1;
			Console.Write("Weight (kg): ");
			try
			{
				FillWeight = Convert.ToDouble(Console.ReadLine());
			}
			catch (Exception e)
			{
				ColoredText.Red(e.Message);
				return;
			}

			IPetModel pet = new DogModel
			{
				Weight = FillWeight,
				Name = FillName,
				Sex = FillSex
			};
			Acc.UserPets.Add(pet.Generator.Create(pet));

			ColoredText.Yellow("Your pet has been successfully added!");
		}
    }
}
