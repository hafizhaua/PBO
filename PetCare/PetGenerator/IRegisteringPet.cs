using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetCare
{
    public interface IRegisteringPet
    {
        Pet Create(IPetModel pet);
    }
}
