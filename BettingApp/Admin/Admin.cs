using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BettingApp
{
    class Admin : IAccount
    {
        private static Admin AdminInstance;
        //public int ID { get; set; }

        public string UserName { get; set; }
        public string Password { get; set; }

        public Admin( string userName, string password)
        {
            if (AdminInstance == null)
            {
                UserName = userName;
                Password = password;
                AdminInstance = this;
            }
            else
            {
                throw new Exception("Admin instance is already present in the system");
            }
        }




    }
}
