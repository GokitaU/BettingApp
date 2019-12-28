using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BettingApp
{
    class CreditCard
    {
        public CreditCard(string cardNumber, string nameOnCard, DateTime expirationDate, User owner)
        {
            CardNumber = cardNumber;
            NameOnCard = nameOnCard;
            ExpirationDate = expirationDate;
            Owner = owner;
        }

        //public int ID { get; set; }
        public string CardNumber { get; set; }
        public string NameOnCard { get; set; }
        public DateTime ExpirationDate { get; set; }
        public User Owner { get; set; }
    }
}
