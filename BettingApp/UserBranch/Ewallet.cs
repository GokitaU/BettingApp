using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BettingApp
{
    class Ewallet
    {
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

        // Here all the method will go. User will create a E Wallet basically,
        // 1st) Connecting Credit Card to Ewaller
        // 2nd) Deposit Money from Credit card to E Wallet mayne another method or in the same one for WithDrawall
        // WILL SEE, DONT KNOW WHERE TO PUT IT YET
        
    }
}
