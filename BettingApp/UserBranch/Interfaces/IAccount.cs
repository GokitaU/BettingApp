using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BettingApp
{
    interface IAccount
    {
        string UserName { get; }
        string Password { get; }        
    }
}
