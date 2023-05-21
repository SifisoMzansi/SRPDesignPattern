using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class StandardMessages
    {
        public static void DisplayValidationError(string msg)
        {
            Console.WriteLine($"You did not give us a valid {msg}");
        }
        public static void WelcomeMessage()
        {
            Console.WriteLine("Welcome to my application");
        }
        public static void EndApplication()
        {
            Console.ReadLine();
        }
    }   
}
