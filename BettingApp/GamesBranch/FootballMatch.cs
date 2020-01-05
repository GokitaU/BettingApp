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

        public Outcome? MatchResult { get; set; }

        private double homeWinOdd;
        public double HomeWinOdd { 
            get
            {
                return homeWinOdd;
            }
            set
            {   //A very³ simple formula, for now...
                 homeWinOdd = 1 + (100 / (HomeTeam.HomeValue / AwayTeam.AwayValue)) / 100;
            }
        }// these properties can either have a readonly calculated formula or a seter, or bothh? ---> Daniel says make both (xaxa)
        public double AwayWinOdd { get; set; }
        public double DrawOdd { get; set; }
        //public int ID { get; set; }

        public FootballMatch(FootballTeam homeTeam, FootballTeam awayTeam, DateTime matchDate)
        {
            HomeTeam = homeTeam;
            AwayTeam = awayTeam;
            MatchDate = matchDate;
            MatchResult = null;
        }

        
    }
}
