using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BettingApp
{
    class Bet
    {
        public Bet( Outcome outcome, double moneyAmount)
        {
            Outcome = outcome;
            MoneyAmount = moneyAmount;
        }

        //public int ID { get; set; }
        public Outcome Outcome { get; set; }
        public double  MoneyAmount { get; set; }
        public FootballMatch MatchRelated { get; set; }
    }
}
