using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BettingApp
{
    class Ewallet
    {
        // Put your currency parity here: 1/1 = euro Currency
        const double CurrencyParity = 1;

        //public int ID { get; set; }
        private double Balance { get; set; }
        private List<CreditCard> CreditCards { get; set; }
        private User Owner { get; set; }

        public Ewallet(User owner)
        {            
            Balance = 0;
            CreditCards = new List<CreditCard>();
            Owner = owner;
        }

        // User will be able to withdraw money from his EWallet - Account and deposit them to his Credit Card
        public static void EWallet_Withdraw(CreditCard creditCard, double transactionValue)
        {
            // Values to use in Switch case
            string choice = "";

            // Checks to ensure that the user will do what he wants in a way the program can handle it
            if(ewallet.Balance >= transactionValue)
            {
                ewallet.Balance = ewallet.Balance - transactionValue;
                creditCard.CreditCard_Transaction(creditCard, transactionValue);
            }
            else if (ewallet.Balance <= transactionValue)
            {
                Console.WriteLine($"Your balance is {ewallet.Balance}, you cannot Withraw {transactionValue} from your Account.");

                // A block of code that will ask the user if he wants to withdraw the money that he currently has in his EWallet
                if (ewallet.Balance > 0)
                {
                    Console.WriteLine($"Would you like to Withrdaw {ewallet.Balance} euros? Y/N");
                    switch(choice.ToUpper())
                    {
                        case "Y":
                            ewallet.Balance = ewallet.Balance - ewallet.Balance;
                            creditCard.CreditCard_Transaction(creditCard, ewallet.Balance);

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

        // This one will be working in cases where we want to use EWallet to make a bet (i need the bet and games Branch ready to make it)
        public static void EWallet_Deposit(Ewallet ewallet, CreditCard creditCard, double transactionValue)
        {
            
        }
        
    }
}
