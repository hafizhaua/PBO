using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetCare
{
    public class CatModel : IPetModel
    {
        public double Weight { get; set; }
        public string Animal { get; set; } = "Cat";
        public string Name { get; set; }
        public string Sex { get; set; }
        public IRegisteringPet Generator { get; set; } = new RegisteringCat();
    }
}
