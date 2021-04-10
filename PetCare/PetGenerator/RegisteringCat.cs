using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetCare
{
    public class RegisteringCat : IRegisteringPet
    {
        public Pet Create(IPetModel pet)
        {
            Pet output = new Pet();
            Random rnd = new Random();

            output.Weight = pet.Weight;
            output.Animal = pet.Animal;
            output.Name = pet.Name;
            output.Sex = pet.Sex;
            output.PetID = $"PC-{rnd.Next(1, 999)}";

            return output;
        }
    }
}
