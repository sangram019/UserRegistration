using System.Text.RegularExpressions;

namespace UserRegistrationRegex
{
    public class Validation
    {


        public void ValidateFirstName()
        {

            Console.WriteLine("Enter First Name : ");
            string name = Console.ReadLine();

            string FIRSTNAME_REGEX = "^[A-Z]{1}[a-zA-Z]{2,}$";
            Regex reg = new Regex(FIRSTNAME_REGEX);

            if (reg.IsMatch(name))
            {
                Console.WriteLine("First Name is valid");
            }
            else
            {
                Console.WriteLine("Verify First Name Again");
            }
        }
        public void ValidateLastName()
        {
            Console.WriteLine("Enter Last Name : ");
            string Name = Console.ReadLine();

            string LastName = "^[A-Z]{1}[a-zA-Z]{2,}$";
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

        public void ValidateEmail()
        {
            Console.WriteLine("Enter Email ID : ");
            string email = Console.ReadLine();

            string emailID = "^[0-9a-zA-Z]+[.+-_]{0,1}[0-9a-zA-Z]+[@][a-zA-Z]+[.][a-zA-Z]{2,3}([.][a-zA-Z]{2,3}){0,1}$";
            Regex reg = new Regex(emailID);

            if (reg.IsMatch(email))
            {
                Console.WriteLine("Email ID is valid");
            }
            else
            {
                Console.WriteLine("Verify Email ID Again");
            }

        }
        public void ValidateMobileNumber()
        {
            Console.WriteLine("Enter Mobile Number : ");
            string MobileNo = Console.ReadLine();

            string MOBILENUMBER_REGEX = "^[+]{1}[1-9]{2}[-. ]{1}[1-9]{2}[0-9]{8}$";
            Regex reg = new Regex(MOBILENUMBER_REGEX);

            if (reg.IsMatch(MobileNo))
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
        public void ValidatePassword2()
        {
            Console.WriteLine("Enter Password : ");
            string password1 = Console.ReadLine();

            string PASSWORD = "^[A-Z]{1}[a-z]{8,}$";
            Regex reg = new Regex(PASSWORD);

            if (reg.IsMatch(password1))
            {
                Console.WriteLine("Password is valid");
            }
            else
            {
                Console.WriteLine("Verify Password Again");
            }
        }
        public void ValidatePassword3()
        {
            Console.WriteLine("Enter Password : ");
            string password2 = Console.ReadLine();

            string PASSWORD = "^[a-zA-z0-9]{8,}$";
            Regex reg = new Regex(PASSWORD);

            if (reg.IsMatch(password2))
            {
                Console.WriteLine("Password is valid");
            }
            else
            {
                Console.WriteLine("Verify Password Again");
            }
        }
        public void ValidatePassword4()
        {
            Console.WriteLine("Enter Password : ");
            var password = Console.ReadLine();

            var PASSWORD = "^(?=.[0-9])(?=.[a-z])(?=.[A-Z])(?=.[*.!@$%^&(){}[]:;<>,.?/~_+-=).{8,32}$";
            Regex reg = new Regex(PASSWORD);

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