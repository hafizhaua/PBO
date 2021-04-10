using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetCare
{
    public interface IPetRegistrationForm : IForm
    {
        string FillAnimal { get; set; }
        string FillName { get; set; }
        string FillPetID { get; set; }
        string FillSex { get; set; }
        double FillWeight { get; set; }
    }
}
