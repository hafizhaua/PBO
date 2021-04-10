using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetCare
{
    public class Pet
    {
        public string Animal { get; set; }
        public string Name { get; set; }
        public string PetID { get; set; }
        public string Sex { get; set; }
        public double Weight { get; set; }

        public void ShowPetDetail()
        {
            Console.WriteLine($"Animal\t: {Animal}");
            Console.WriteLine($"Name\t: {Name}");
            Console.WriteLine($"ID\t: {PetID}");
            Console.WriteLine($"Sex\t: {Sex}");
            Console.WriteLine($"Weight\t: {Weight} kg");
        }
    }
}
