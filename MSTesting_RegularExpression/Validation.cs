using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MSTesting_RegularExpression
{
    public class Validation
    {
        public bool FirstNameValidation(string fName) // Creating a method for First name validation
        {
            string pattern = "^[A-Z][a-z]{2,}$"; // Regex for first name validation
            //If name entered by user is match with regex then it is valid otherwise not
            if (Regex.IsMatch(fName, pattern))
            {
                Console.WriteLine($"\nYour first name \"{fName}\" is valid");
                return true;
            }
            else
            {
                Console.WriteLine($"\nYour first name \"{fName}\" is not valid");
                Console.WriteLine("\nPlease follow naming convention of first name");
                return false;
            }
        }
        
    }
}
