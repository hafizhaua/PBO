using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetCare
{
    public class ReservationStatusMenu : CustomerMenuAbstract
    {
        public override void Show(Customer customer)
        {
            ReservationList.ShowAll(customer.UserReservation);
        }
    }
}
