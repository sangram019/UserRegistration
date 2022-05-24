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


        //public void ValidateFirstName()
        //{

        //    Console.WriteLine("Enter First Name : ");
        //    string name = Console.ReadLine();

        //    string FIRSTNAME_REGEX = "^[A-Z]{1}[a-zA-Z]{0-6}$";
        //    Regex reg = new Regex(FIRSTNAME_REGEX);

        //    if (reg.IsMatch(name))
        //    {
        //        Console.WriteLine("First Name is valid");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Invalid Name Found");
        //    }

        //}
        //public void ValidateLastName()
        //{
        //    Console.WriteLine("Enter Last Name : ");
        //    string Name = Console.ReadLine();

        //    string LastName = "^[A-Z]{1}[a-zA-Z]{6,}$";
        //    Regex reg = new Regex(LastName);

        //    if (reg.IsMatch(Name))
        //    {
        //        Console.WriteLine("Last Name is valid");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Verify Last Name Again");
        //    }
        //}
        //public void ValidateEmail()
        //{
        //    Console.WriteLine("Enter Email ID : ");
        //    string email = Console.ReadLine();

        //    string emailID = "^[0-9a-z]+[.+-_]{0,1}[0-9a-z]+[@][a-z]+[.][a-z]{2,3}([.][a-z]{2,3}){0,1}$";
        //    Regex reg = new Regex(emailID);

        //    if (reg.IsMatch(email))
        //    {
        //        Console.WriteLine("E-mail ID is valid");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Invalid E-mail Id");
        //    }

        //}
        public void ValidateMobileNumber()
        {
            Console.WriteLine("Enter Mobile Number : ");
            string MobileNumber = Console.ReadLine();

            string MOBILENUMBER_REGEX = "^[+]{1}[1-9]{2}[-. ]{1}[1-9]{2}[0-9]{8}$";
            Regex reg = new Regex(MOBILENUMBER_REGEX);

            if (reg.IsMatch(MobileNumber))
            {
                Console.WriteLine("Mobile Number is valid");
            }
            else
            {
                Console.WriteLine("Verify Mobile Number Again");
            }

        }
        public void ValidatePassword()
        {
            Console.WriteLine("Enter Password : ");
            string password = Console.ReadLine();

            string PASSWORD_REGEX = "^[a-zA-z]{8,}$";
            Regex reg = new Regex(PASSWORD_REGEX);

            if (reg.IsMatch(password))
            {
                Console.WriteLine("Password is valid");
            }
            else
            {
                Console.WriteLine("Verify Password Again");
            }
        }
    }
}
    