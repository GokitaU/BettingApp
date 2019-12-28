using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BettingApp
{
    class Ewallet
    {
        public Ewallet( User owner)
        {
            Balance = 0;
            CreditCards = new List<CreditCard>();
            Owner = owner;
        }

        //public int ID { get; set; }
        public double Balance { get; set; }
        public List<CreditCard> CreditCards { get; set; }
        public User Owner { get; set; }
    }
}
