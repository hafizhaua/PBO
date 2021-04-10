using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetCare
{
    class DogModel : IPetModel
    {
        public double Weight { get; set; }
        public string Animal { get; set; } = "Dog";
        public string Name { get; set  ; }
        public string Sex { get; set; }
        public IRegisteringPet Generator { get; set; } = new RegisteringDog(); 
    }
}
