using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetCare
{
    class Login
    {
        public static void Show(List<IUser> UserList)
        {
            while (true)
            {
                Console.WriteLine("Welcome to the Pet Care!");
                Console.WriteLine("Please log in to your account.");
                Console.WriteLine("======= Login Form =======");
                Console.Write("Username : ");
                string email = Console.ReadLine();
                Console.Write("Password : ");
                string password = ReadPassword();

                IUser check = UserList.Find(x => x.Username == email);
                if (check != null && check.Password == password)
                {
                    ColoredText.Green("Login successful.");
                    if (check is Customer)
                    {
                        Customer CustAcc = (Customer)check;
                        MainMenu menu = new MainMenu();
                        menu.Show(CustAcc);
                    }
                }
                else
                {
                    ColoredText.Red("Email/password is invalid.");
                    Console.Write("Do you want to exit? (y/n) ");
                    string exit = Console.ReadLine();
                    if (exit == "y") Environment.Exit(1);
                }
            }
            
        }
        public static string ReadPassword()
        {
            string password = "";
            ConsoleKeyInfo info = Console.ReadKey(true);
            while (info.Key != ConsoleKey.Enter)
            {
                if (info.Key != ConsoleKey.Backspace)
                {
                    Console.Write("*");
                    password += info.KeyChar;
                }
                else if (info.Key == ConsoleKey.Backspace)
                {
                    if (!string.IsNullOrEmpty(password))
                    {
                        password = password.Substring(0, password.Length-1);
                        int position = Console.CursorLeft;
                        Console.SetCursorPosition(position-1, Console.CursorTop);
                        Console.Write(" ");
                        Console.SetCursorPosition(position-1, Console.CursorTop);
                    }
                }
                info = Console.ReadKey(true);
            }
            Console.WriteLine();
            return password;
        }
    }
}
