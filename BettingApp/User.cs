using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BettingApp
{
    class User : IAccount
    {
        public User( string userName, string password, string firstName, string lastName, string phoneNumber, string email, string address)
        {
            UserName = userName;
            Password = password;
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            Email = email;
            Address = address;
            UserWallet = new Ewallet(this);
        }

        //public int ID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string  PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public Ewallet UserWallet { get; set; }


    }
}
