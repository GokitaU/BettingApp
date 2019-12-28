using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BettingApp
{
    enum Outcome {  W, L, D}
    class FootballMatch
    {
        public FootballTeam HomeTeam { get; set; }
        public FootballTeam AwayTeam { get; set; }
        public DateTime MatchDate { get; set; }

        public Outcome MatchResult { get; set; }

        public double HomeWinOdd { get; set; }// these properties can either have a readonly calculated formula or a seter, or bothh?
        public double AwayWinOdd { get; set; }
        public double DrawOdd { get; set; }
        //public int ID { get; set; }

        
    }
}
