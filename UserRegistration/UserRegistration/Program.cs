See https://aka.ms/new-console-template for more information
using UserRegistrationRegex;
class Program
{
    public static void Main(string[] args)
    {

        Console.WriteLine("Welcome to User Registration Problem");

        Validation validation = new Validation();
        validation.ValidateFirstName();

        Validation validation1 = new Validation();
        validation1.ValidateLastName();

        Validation validation2 = new Validation();
        validation2.ValidateEmail();

        Validation validation3 = new Validation();
        validation3.ValidateMobileNumber();

        Validation validation4 = new Validation();
        validation4.ValidatePassword();

        Validation validation5 = new Validation();
        validation5.ValidatePassword1();

        Validation validation6 = new Validation();
        validation6.ValidatePassword2();
    }
}