using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BettingApp
{
    class CreditCard
    {
        // Const Values
        const int maxCardExperationRangeDays = 1460; // 365 * 4 years
        // Put your currency parity here: 1/1 = euro Currency
        const double currencyParity = 1;

        //public int ID { get; set; }
        private string CardNumber { get; set; }
        private string NameOnCard { get; set; }
        private DateTime ExpirationDate { get; set; }
        private User Owner { get; set; }
        // We need to know the card balance, so for now it will be 100
        private double creditCard_balance; 
        private double CreditCard_Balance 
        {
            // never used a getter in this way, need testing
            get
            {
                return CreditCard_Balance;
            }
            set 
            {
                value = value * currencyParity;
                creditCard_balance = value;
            }
        }

        // We will have two constructors, one with Random Generated values the other with manual. This helps in Testing
        public CreditCard(string cardNumber, string nameOnCard, DateTime experationDate, User owner)
        {
            CardNumber = cardNumber;
            NameOnCard = nameOnCard;
            ExpirationDate = experationDate;
            Owner = owner;
            CreditCard_Balance = 100;
        }

        // We will have two constructors, one with Random Generated values the other with manual. This helps in Testing
        public CreditCard(Random random, User owner)
        {
            CardNumber = RandomGenerator.RND_CardNumber(random);
            NameOnCard = RandomGenerator.RND_FirstName(random) + $" {RandomGenerator.RND_FirstName(random).Substring(0,1)}. " + RandomGenerator.RND_LastName(random);
            ExpirationDate = DateTime.Today.AddDays(random.Next(0, maxCardExperationRangeDays));
            Owner = owner;
            CreditCard_Balance = 100;
        }

        // Method that will change the card Balance based on the user input (carefull it works with negatives and positivies)
        public void CreditCard_Transaction(CreditCard creditCard, double transactionValue)
        {
           
            if(transactionValue > 0)
            {
                creditCard.CreditCard_Balance = creditCard.CreditCard_Balance + transactionValue;
            }
            else if (transactionValue < 0)
            {
                creditCard.CreditCard_Balance = creditCard.CreditCard_Balance - transactionValue;
            }
            else 
            {
                creditCard.CreditCard_Balance = creditCard.CreditCard_Balance;
                Console.WriteLine("Something was wrong with the Card Transaction");
			}


        }

        // String Override to Print the Credit Card Details
        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"Card number is: {CardNumber}")
              .AppendLine($"Name on Card is: {NameOnCard}")
              .AppendLine($"Owner of the card is: ")
              .AppendLine($"{Owner}")
              .AppendLine($"Experation date of the card is: {ExpirationDate.ToString("dd/MM/yyyy")}");             

            return sb.ToString();
        }       
              
    }
}
