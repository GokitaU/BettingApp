using BettingApp.GamesBranch;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BettingApp
{
    class DBContext
    {
        public static List<User> Users { get; set; } = new List<User>();
        public static List<Admin> Admins { get; set; } = new List<Admin>();
        public static List<Bet> Bets { get; set; } = new List<Bet>();
        public static List<CreditCard> CreditCards { get; set; } = new List<CreditCard>();
        public static List<Ewallet> Ewallets { get; set; } = new List<Ewallet>();
        public static List<FootballTeam> FootballTeams { get; set; } = new List<FootballTeam>();
        public static List<FootballMatch> FootBallMatches { get; set; } = new List<FootballMatch>();
        public static List<League> Leagues { get; set; } = new List<League>();
    }
}
