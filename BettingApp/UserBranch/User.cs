using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BettingApp
{
    class User : IAccount
    {      
        //public int ID { get; set; }
        public string UserName { get; private set; }
        public string Password { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string PhoneNumber { get; private set; }
        public string Email { get; private set; }
        public string Address { get; private set; }
        // There will be a method that will determine based on UserWallet and the Balance or Depostin - he has what level of Account this is, will see how this will be implemented
        //public string TypeOfAccount { get; private set; }
        public Ewallet UserWallet { get; private set; }

        // We will have two constructors, one with Random Generated values the other with manual. This helps in Testing
        public User(string userName, string password, string firstName, string lastName, string phoneNumber, string email, string address)
        {
            UserName = userName;
            Password = password;
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            Email = email;
            Address = address;
            UserWallet =  new Ewallet(this);
        }

        // We will have two constructors, one with Random Generated values the other with manual. This helps in Testing
        public User(Random random)
        {
            UserName = RandomGenerator.RND_UserNames(random);
            Password = "1234";
            FirstName = RandomGenerator.RND_FirstName(random);
            LastName = RandomGenerator.RND_LastName(random);
            PhoneNumber = RandomGenerator.RND_PhoneNumber(random);
            Email = $"{FirstName}.{LastName}@gmail.com";
            Address = RandomGenerator.RND_Adress(random);
            UserWallet = new Ewallet(this);
        }

        // String Override to Print the User Details
        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"User Name: {UserName}")
              .AppendLine($"First Name: {FirstName}")
              .AppendLine($"Last Name: {LastName}")
              .AppendLine($"Phone Number: {PhoneNumber}")
              .AppendLine($"Email: {Email}")
              .AppendLine($"Address: {Address}");              

            return sb.ToString();
        }
    }
}
