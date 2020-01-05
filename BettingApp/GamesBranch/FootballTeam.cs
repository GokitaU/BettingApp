using BettingApp.GamesBranch;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BettingApp
{
    class FootballTeam
    {
        public FootballTeam(string name, double homeValue, double awayValue,  League leagueRelated)
        {
            
            Name = name;
            HomeValue = homeValue;
            AwayValue = awayValue;
            //AdditionalValue = additionalValue;
            LeagueRelated = leagueRelated;
            //DBContext.FootballTeams.Add(this);
        }

        public string Name { get; set; }
        public double HomeValue { get; set; }
        public double AwayValue { get; set; }
        //public double AdditionalValue { get; set; }
        public League LeagueRelated { get; set; }
        // public int ID { get; set; }
    }
}
