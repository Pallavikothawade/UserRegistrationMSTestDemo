using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationMSTestDemo
{
    public class UserDetails
    {
        public bool FirstNameTestcase(string input)
        {
            string Pattern = "^[A-Z]{1}[a-z]{2,}$";
            if (Regex.IsMatch(input, Pattern))
            {
                Console.WriteLine("{0} is valid FirstName", input);
                return true;
            }
            else
            {
                Console.WriteLine("{0} is Invalid FirstName", input);
                return false;
            }
        }
        public bool LastNameTestcase(string input)
        {
            string Pattern = "^[A-Z]{1}[a-z]{2,}$";
            if (Regex.IsMatch(input, Pattern))
            {
                Console.WriteLine("{0} is valid LastName", input);
                return true;
            }
            else
            {
                Console.WriteLine("{0} is Invalid LastName", input);
                return false;
            }
        }
        public bool Email_IdTestCase(string input)
        {
            string Pattern = "^([a-z0-9]){3,}?([-,.,+][a-z0-9]{1,})*@([a-z0-9]){1,}[.][a-z]{2,}?([.][a-z]{2,})*$";
            if (Regex.IsMatch(input, Pattern))
            {
                Console.WriteLine("{0} is valid Email", input);
                return true;
            }
            else
            {
                Console.WriteLine("{0} is Invalid Email", input);
                return false;
            }
        }

    }
}
