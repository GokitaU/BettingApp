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

        //public int ID { get; set; }
        private string CardNumber { get; set; }
        private string NameOnCard { get; set; }
        private DateTime ExpirationDate { get; set; }
        private User Owner { get; set; }

        // We will have two constructors, one with Random Generated values the other with manual. This helps in Testing
        public CreditCard(string cardNumber, string nameOnCard, DateTime experationDate, User owner)
        {
            CardNumber = cardNumber;
            NameOnCard = nameOnCard;
            ExpirationDate = experationDate;
            Owner = owner;
        }

        // We will have two constructors, one with Random Generated values the other with manual. This helps in Testing
        public CreditCard(Random random, User owner)
        {
            CardNumber = RandomGenerator.RND_CardNumber(random);
            NameOnCard = RandomGenerator.RND_FirstName(random) + $" {RandomGenerator.RND_FirstName(random).Substring(0,1)}. " + RandomGenerator.RND_LastName(random);
            ExpirationDate = DateTime.Today.AddDays(random.Next(0, maxCardExperationRangeDays));
            Owner = owner;
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

        // Method that will do the Withdraw and Deposit with very strong encapsulation
    }
}
