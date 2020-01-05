using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BettingApp
{
    class Bet
    {
        public Bet( Outcome outcome, double moneyAmount, User relatedUser, FootballMatch match)
        {
            Outcome = outcome;
            MoneyAmount = moneyAmount;
            UserRelated = relatedUser;
            MatchRelated = match;
        }
        
        //public int ID { get; set; }
        public Outcome Outcome { get; set; }
        public double  MoneyAmount { get; set; }
        public FootballMatch MatchRelated { get; set; }
        public User UserRelated { get; set; }
    }
}
