using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class PersonValidator
    {
        public static bool Validate(Person peron)
        {
            if (string.IsNullOrEmpty(peron.FirstName))
            {
                StandardMessages.DisplayValidationError("first name");
                StandardMessages.EndApplication();
                return false;
            }

            if (string.IsNullOrEmpty(peron.LastName))
            {
                StandardMessages.DisplayValidationError("last name");
                StandardMessages.EndApplication();
                return false;
            }
            return true;
        }


    }
}
