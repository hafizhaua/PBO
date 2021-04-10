using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetCare
{
    public static class ReservationList
    {
        public static void ShowAll(List<Reservation> ReservationList)
        {
			if (ReservationList.Count > 0) Console.WriteLine("\nYou have {0} reservation(s) registered!", ReservationList.Count);
			else Console.WriteLine("Your list is empty.");
			Console.WriteLine("+-----+---------+--------+-----------+--------+----------+");
			Console.WriteLine("| No. | Name    | PetID  |  Service  | RsrvID | Price    |");
			Console.WriteLine("+-----+---------+--------+-----------+--------+----------+");
			
			int i = 1;
			int sum = 0;
			foreach (var reservation in ReservationList)
			{
				Console.Write($"| {i,3} | {reservation.Pet.Name,7} | {reservation.Pet.PetID,6} | {reservation.Services,9} | {reservation.ReservationID,6} | {reservation.Price,8} |\n");
				sum += reservation.Price;
				i++;
			}
			Console.WriteLine("+-----+---------+--------+-----------+--------+----------+");
			Console.WriteLine($"                                     | Total IDR {sum,7} |");
			Console.WriteLine("                                     +-------------------+");

			ColoredText.Yellow("If your pet has been showed up above, you can bring it to our store, thank you!");
		}
		
			
	}
}
