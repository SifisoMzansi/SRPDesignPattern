using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class AccountGenerator
    {
        public static void CreateAccount(Person user)
        {

            Console.WriteLine($"Your full name is {user.FirstName} {user.LastName}");
        }
    }
}
