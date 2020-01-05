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

        // Changed a little bit the text that will be printed
        public static string AdminMenu(Admin admin)
        {
            Console.WriteLine("What would you like to do:");
            Console.WriteLine("1) Print curently registered leagues");
            Console.WriteLine("2) Print curently registered teams");
            Console.WriteLine("3) Print curently active for betting football matches");
            Console.WriteLine("4) Register a new football match");
            Console.WriteLine("5) Register a new football team");
            Console.WriteLine("6) Register a new football league");
            Console.WriteLine("7) Exit");

            string userInput = Console.ReadLine();
            return userInput;
        }

        // Changed a little bit the text that will be printed
        public static string UserMenu(User user)
        {
            Console.WriteLine(user);
            Console.WriteLine("What would you like to do:");
            Console.WriteLine("1) Edit personal information");
            Console.WriteLine("2) Manage Ewallet");
            Console.WriteLine("3) Place a bet");
            Console.WriteLine("4) View all active bets");

            string userInput = Console.ReadLine();

            return userInput;
        }

        // An UI for creating a Credit Card, later there will be checks
        public static CreditCard CreateCreditCard(User user)
        {
            Console.WriteLine("Please enter your Credit Card Details:");
            Console.WriteLine("Enter your Credit Card Number:");
            string cardNumber = Console.ReadLine();
            Console.WriteLine("Enter your Credit Card Name:");
            string nameOnCard = Console.ReadLine();
            Console.WriteLine("Enter your Credit Card Experation Date: (dd/mm/yyyy");
            DateTime experationDate = DateTime.Parse(Console.ReadLine());
                
            CreditCard creditCard = new CreditCard(cardNumber, nameOnCard, experationDate, user);
            return creditCard;            
        }

        // An UI for creating a User, later there will be checks
        public static User CreateUser() 
        {
            Console.WriteLine("Enter your Username");
            string userName = Console.ReadLine();
            Console.WriteLine("Enter your password");
            string password = Console.ReadLine();
            Console.WriteLine("Enter your First Name");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter your Last Name");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter your phone number");
            string phoneNumber = Console.ReadLine();
            Console.WriteLine("Enter your email address");
            string email = Console.ReadLine();
            Console.WriteLine("Enter your address");
            string address = Console.ReadLine();           

            User user = new User(userName,password,firstName,lastName,phoneNumber,email,address);

            return user;
        }

    }
}
