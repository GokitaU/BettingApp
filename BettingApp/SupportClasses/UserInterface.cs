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

            Console.Write("Please type your username: ");
            string userName = Console.ReadLine();

            Console.WriteLine("Please type your password: ");
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
    }
}
