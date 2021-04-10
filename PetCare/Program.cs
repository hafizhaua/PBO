using System;
using System.Collections.Generic;

namespace PetCare
{
    class Program
    {
		static void Main(string[] args)
		{
			Random ID = new Random();

			List<IUser> UserList = new List<IUser>()
			{
				new Customer("pboasyik", "pbo", ID.Next(100,999)),
				new Customer("oopasyik", "oop", ID.Next(100,999))
			};

			Login.Show(UserList);
		}
	}
}
