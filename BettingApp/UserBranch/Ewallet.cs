using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BettingApp
{
    class Ewallet
    {
        // Put your currency parity here: 1/1 = Euro Currency
        const double currencyParity = 1;

        //public int ID { get; set; }

        private double e_walletbalance;
        private double E_WalletBalance
        {
            // never used a getter in this way, need testing
            get
            {
                return E_WalletBalance;
            }
            set 
            {
                value = value * currencyParity;
                e_walletbalance = value;
            }
        }          

        private List<CreditCard> CreditCards { get; set; }
        private User Owner { get; set; }

        public Ewallet(User owner)
        {            
            E_WalletBalance = 0;
            CreditCards = new List<CreditCard>();
            Owner = owner;
        }

        // User will be able to withdraw money from his EWallet - Account and deposit them to his Credit Card
        public static void EWallet_Withdraw(User user, double transactionValue)
        {
            // Values to be used in the method
            string choice = "";
            int counter = 0;
            int numberChoice = 0;

            // Checks to ensure that the user will do what he wants in a way the program can handle it
            if(user.UserWallet.E_WalletBalance >= transactionValue)
            {
                user.UserWallet.E_WalletBalance = user.UserWallet.E_WalletBalance - transactionValue;
                
                // user will Pick the Card he want to use if there is none, he must add one
                if (user.UserWallet.CreditCards.Count == 0)
                {
                    Console.WriteLine("Please enter your Credit Card Details:");
                    Console.WriteLine("Enter your Credit Card Number:");
                    string cardNumber = Console.ReadLine();
                    Console.WriteLine("Enter your Credit Card Name:");
                    string nameOnCard = Console.ReadLine();
                    Console.WriteLine("Enter your Credit Card Experation Date: (dd/mm/yyyy");
                    DateTime experationDate = DateTime.Parse(Console.ReadLine());
                
                    CreditCard creditCard = new CreditCard(cardNumber, nameOnCard, experationDate, user);
                    user.UserWallet.CreditCards.Add(creditCard);
                    Console.WriteLine("Credit Card successfully added");
                }

                // user will Pick the Card he want to use
                Console.WriteLine("Pick the Credit Card you want:");
                counter = 0;

                foreach (CreditCard creditCard in user.UserWallet.CreditCards)
                {
                    counter++;
                    Console.WriteLine($"{counter}: {creditCard}");
                }
                numberChoice = int.Parse(Console.ReadLine());

                // Money added to the card that the user picked, later we can add here a property where user will choose if he want to use an existing card, or add a new one.
                user.UserWallet.CreditCards[numberChoice].CreditCard_Transaction(user.UserWallet.CreditCards[numberChoice], transactionValue);
            }
            else if (user.UserWallet.E_WalletBalance <= transactionValue)
            {
                Console.WriteLine($"Your balance is {user.UserWallet.E_WalletBalance}, you cannot Withraw {transactionValue} from your Account.");

                // A block of code that will ask the user if he wants to withdraw the money that he currently has in his EWallet
                if (user.UserWallet.E_WalletBalance > 0)
                {
                    Console.WriteLine($"Would you like to Withrdaw {user.UserWallet.E_WalletBalance} euros? Y/N");
                    switch(choice.ToUpper())
                    {
                        case "Y":
                            user.UserWallet.E_WalletBalance = user.UserWallet.E_WalletBalance - user.UserWallet.E_WalletBalance;
                            
                            // user will Pick the Card he want to use if there is none, he must add one
                            if (user.UserWallet.CreditCards.Count == 0)
                            {
                                Console.WriteLine("Please enter your Credit Card Details:");
                                Console.WriteLine("Enter your Credit Card Number:");
                                string cardNumber = Console.ReadLine();
                                Console.WriteLine("Enter your Credit Card Name:");
                                string nameOnCard = Console.ReadLine();
                                Console.WriteLine("Enter your Credit Card Experation Date: (dd/mm/yyyy");
                                DateTime experationDate = DateTime.Parse(Console.ReadLine());

                
                                CreditCard creditCard = new CreditCard(cardNumber, nameOnCard, experationDate, user);
                                user.UserWallet.CreditCards.Add(creditCard);
                                Console.WriteLine("Credit Card successfully added");         
                            }

                            Console.WriteLine("Pick the Credit Card you want:");
                            counter = 0;
                            
                            // user will Pick the Card he want to use
                            foreach (CreditCard creditCard in user.UserWallet.CreditCards)
                            {
                                counter++;
                                Console.WriteLine($"{counter}: {creditCard}");
                            }
                            numberChoice = int.Parse(Console.ReadLine());

                            // Money added to the card that the user picked, later we can add here a property where user will choose if he want to use an existing card, or add a new one.
                            user.UserWallet.CreditCards[numberChoice].CreditCard_Transaction(user.UserWallet.CreditCards[numberChoice], transactionValue);
                            break;

                        default:
                            break;
                    }
                }
            }
            else 
            {
                Console.WriteLine("Something was wrong with the E_Wallet Withdrawall");
            }
        }

        // User will be able to Deposit money from his CreditCard to his Ewallet - Account
        public static void EWallet_Deposit(User user, double transactionValue)
        {
            // Values to be used in the method
            int counter = 0;
            int numberChoice = 0;

            // user will Pick the Card he want to use if there is none, he must add one
            if (user.UserWallet.CreditCards.Count == 0)
            {
                Console.WriteLine("Please enter your Credit Card Details:");
                Console.WriteLine("Enter your Credit Card Number:");
                string cardNumber = Console.ReadLine();
                Console.WriteLine("Enter your Credit Card Name:");
                string nameOnCard = Console.ReadLine();
                Console.WriteLine("Enter your Credit Card Experation Date: (dd/mm/yyyy");
                DateTime experationDate = DateTime.Parse(Console.ReadLine());

                
                 CreditCard creditCard = new CreditCard(cardNumber, nameOnCard, experationDate, user);
                 user.UserWallet.CreditCards.Add(creditCard);
                 Console.WriteLine("Credit Card successfully added");           
            }
            
            Console.WriteLine("Pick the Credit Card you want:");
            counter = 0;

            foreach (CreditCard creditCard in user.UserWallet.CreditCards)
            {
                counter++;
                Console.WriteLine($"{counter}: {creditCard}");
            }
            numberChoice = int.Parse(Console.ReadLine());                        
            
            try 
            {	        
		        user.UserWallet.CreditCards[numberChoice].CreditCard_Transaction(user.UserWallet.CreditCards[numberChoice], (-transactionValue));
                user.UserWallet.E_WalletBalance = user.UserWallet.E_WalletBalance + transactionValue;
            }
            catch (CustomException ex)
            {
	            Console.WriteLine($"{ex.Message}. Your Balance is {user.UserWallet.E_WalletBalance}");
            }            
        }
        
        // This one will be working in cases where we want to use EWallet to make a bet (i need the bet and games Branch ready to make it)
        public static void EWallet_Bet(User user, double transactionValue)
        {

        }   
    }
}
