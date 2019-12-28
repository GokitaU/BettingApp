using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BettingApp
{
    class Admin : IAccount
    {


        //public int ID { get; set; }

        public string UserName { get; set; }
        public string Password { get; set; }

        public Admin( string userName, string password)
        {
            UserName = userName;
            Password = password;
        }

    }
}
