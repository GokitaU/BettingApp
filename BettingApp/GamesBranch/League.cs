using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BettingApp.GamesBranch
{
    enum Division { A, B, C}
    class League
    {

        public string Name { get; set; }
        public string Country { get; set; }
        public Division LeagueDivision { get; set; }

        private List<FootballTeam> teams;
        public List<FootballTeam> Teams {
            get
            {
                return teams;
            }
        }

        public League(string name, string country, Division division)
        {
            Name = name;
            Country = country;
            LeagueDivision = division;
            teams = new List<FootballTeam>();
            //DBContext.Leagues.Add(this); -->addtions/removals on dbcontext should be handled by methods of db context class
        }

        public void AddTeam(FootballTeam team, Admin admin)
        {
            if ( teams.Count == 20)
                throw new Exception("League already contains maximum number of teams(20)");
            else
            {
                foreach (var existingTeam in teams)
                {
                    if (existingTeam.Equals(team))
                        throw new Exception("Team already exists in that league");
                }
                teams.Add(team);
                Console.WriteLine($"{team.Name} Succesfuly added to the list");
            }
        }

        public void RemoveTeam(FootballTeam team, Admin admin)
        {
            bool removed = false;

            if (teams.Count == 0)
                throw new Exception("League cannot contain negative number of teams");
            else
            {
                foreach (var existingTeam in teams)
                {
                    if (team.Equals(existingTeam))
                    {
                        teams.Remove(existingTeam);
                        removed = true;
                    }
                }
            }

            if(removed)
                Console.WriteLine($"Succesfully removed {team.Name} from list");
            else
                Console.WriteLine($"Team doesn't exist in the list, thus couldn't be removed");
        }


    }
}
