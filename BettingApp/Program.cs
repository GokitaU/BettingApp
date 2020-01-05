using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BettingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome");

            IAccount client;
            bool validLogin = false;
            do
            {
                Console.Clear();

                client = UserInterface.Login();

                if (client == null)
                {
                    Console.WriteLine("Credentials incorrect");
                    Console.WriteLine("Press any key to try again or R to register a new account");
                    ConsoleKeyInfo userInput = Console.ReadKey();
                    switch (userInput.KeyChar)
                    {
                        case 'R':
                            UserInterface.CreateAccount();
                            break;

                        default:
                            continue;
                    }

                }
                else
                {
                    validLogin = true;
                }
            } while (!validLogin);


            bool exit = false;
            if (client is Admin)
            {
                Admin administractorInstance = (Admin)client;
                do
                {
                    Console.Clear();
                    switch (UserInterface.AdminMenu(administractorInstance))
                    {
                        case "1":
                            foreach (var league in DBContext.Leagues)
                            {
                                Console.WriteLine(league);
                                Console.WriteLine(); //Visual optimization
                            }
                            break;

                        case "2":
                            foreach (var team in DBContext.FootballTeams)
                            {
                                Console.WriteLine(team);
                                Console.WriteLine();
                            }
                            break;

                        case "3":
                            //Querying and producing a list of active matches to print info
                            List<FootballMatch> activeMatches = (from m in DBContext.FootBallMatches
                                                                 where m.MatchDate >= DateTime.Now
                                                                 select m).ToList();
                            //printing info
                            foreach (var match in activeMatches)
                            {
                                Console.WriteLine(match);
                            }
                            break;

                        case "4":

                            break;

                        case "5":

                            break;

                        case "6":

                            break;

                        default:
                            exit = true;
                            break;
                    }
                } while (!exit);
            }
            else
            {
                User userInstance = (User)client;
                do
                {
                    Console.Clear();
                    switch (UserInterface.UserMenu(userInstance))
                    {
                        case "1":
                            
                            break;

                        case "2":
                            
                            break;

                        case "3":
                            
                            break;

                        case "4":
                            List<Bet> activeBets = (from b in userInstance.BetsPlaced
                                                    where b.Outcome.Equals(null)
                                                    select b).ToList();
                            foreach (var bet in activeBets)
                            {
                                Console.WriteLine(bet);
                            }
                            break;

                        default:
                            exit = true;
                            break;
                    }
                } while (!exit);
            }










            //IAccount client = UserInterface.Login();
            //if (client.Equals(typeof(User)))
            //    Console.WriteLine("User");
            //else if (client is Admin)
            //    Console.WriteLine("Admin");
            //else
            //    Console.WriteLine("Invalid Input");


            // Testing some things
            //Random random = new Random();

            //User user1 = new User(random);

            //CreditCard creditCard = new CreditCard(random, user1);

            //Console.WriteLine(creditCard);

        }



    }
}
