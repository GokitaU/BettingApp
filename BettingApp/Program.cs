﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BettingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //IAccount client = UserInterface.Login();
            //if (client.Equals(typeof(User)))
            //    Console.WriteLine("User");
            //else if (client is Admin)
            //    Console.WriteLine("Admin");
            //else
            //    Console.WriteLine("Invalid Input");


            // Testing some things
            Random random = new Random();

            User user1 = new User(random);

            CreditCard creditCard = new CreditCard(random, user1);

            Console.WriteLine(creditCard);

        }



    }
}
