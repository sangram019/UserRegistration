using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace UserRegistrationRegex
{
    public class Validation
    {


        public void ValidateFirstName()
        {

            Console.WriteLine("Enter First Name : ");
            string name = Console.ReadLine();

            string FIRSTNAME_REGEX = "^[A-Z]{1}[a-zA-Z]{0-6}$";
            Regex reg = new Regex(FIRSTNAME_REGEX);

            if (reg.IsMatch(name))
            {
                Console.WriteLine("First Name is valid");
            }
            else
            {
                Console.WriteLine("Invalid Name Found");
            }

        }
        public void ValidateLastName()
        {
            Console.WriteLine("Enter Last Name : ");
            string Name = Console.ReadLine();

            string LastName = "^[A-Z]{1}[a-zA-Z]{6,}$";
            Regex reg = new Regex(LastName);

            if (reg.IsMatch(Name))
            {
                Console.WriteLine("Last Name is valid");
            }
            else
            {
                Console.WriteLine("Verify Last Name Again");
            }
        }
    }
}
    