// See https://aka.ms/new-console-template for more information
using UserRegistrationRegex;
class Program
{
    public static void Main(string[] args)
    {

        Console.WriteLine("Welcome to User Registration Problem");

        Validation validation = new Validation();
        validation.ValidateFirstName();
    }
}