using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BettingApp
{
    abstract class UserInterface
    {

        public static void CreateAccount()
        {
            Console.WriteLine("Please type your First name");
            Console.WriteLine("Please type your Last name");

            Console.WriteLine("Please type your username");
            Console.WriteLine("Please type your password");

            Console.WriteLine("Please type your phone number");
            Console.WriteLine("Please type your e-mail");

            Console.WriteLine("Please type your home address");

            DBContext.Users.Add(new User("bobleman", "Password", "Bob", "Papadopoulos", "6944367283", "Bob@bob.bob", "Bob B"));

        }
        public static IAccount Login()
        {

            Console.WriteLine("What is your userName?");
            string userName = Console.ReadLine();

            Console.WriteLine("What is your Password?");
            string password = Console.ReadLine();


            foreach (var admin in DBContext.Admins)
            {
                if (admin.UserName.Equals(userName, StringComparison.OrdinalIgnoreCase))
                    if (admin.Password.Equals(password, StringComparison.Ordinal))
                        return admin;
            }

            foreach (var user in DBContext.Users)
            {
                if (user.UserName.Equals(userName, StringComparison.OrdinalIgnoreCase))
                    if (user.Password.Equals(password, StringComparison.Ordinal))
                        return user;
            }

            return null;
        }

        public static string AdminMenu(Admin admin)
        {
            Console.WriteLine("Press 1 to print curently registered leagues");
            Console.WriteLine("Press 2 to print curently registered teams");
            Console.WriteLine("Press 3 to print curently active for betting football matches");
            Console.WriteLine("Press 4 to register a new football match");
            Console.WriteLine("Press 5 to register a new football team");
            Console.WriteLine("Press 6 to register a new football league");
            Console.WriteLine("Press any other key to exit");


            string userInput = Console.ReadLine();
            return userInput;
        }

        public static string UserMenu(User user)
        {
            Console.WriteLine(user);
            Console.WriteLine("Press 1 to edit personal information");
            Console.WriteLine("Press 2 to manage Ewallet");
            Console.WriteLine("Press 3 to place a bet");
            Console.WriteLine("Press 4 to view all active bets");

            string userInput = Console.ReadLine();

            return userInput;
        }
    }
}
