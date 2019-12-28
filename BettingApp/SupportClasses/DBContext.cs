using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BettingApp
{
    class DBContext
    {
        public static List<User> Users { get; set; }
        public static List<Admin> Admins { get; set; }
        public static List<Bet> Bets { get; set; }
        public static List<CreditCard> CreditCards { get; set; }
        public static List<Ewallet> Ewallets { get; set; }
        public static List<FootballTeam> FootballTeams { get; set; }
        public static List<FootballMatch> FootBallMatches { get; set; }
    }
}
