using System;

namespace TT_Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Program Started");
            System.Console.WriteLine("**********************");
            Console.WriteLine("Press blah to exit the program.");

            //TO DO: implement exiting the loop
            while (true)
            {
                Console.WriteLine("Please enter an email to search: ");
                var emailInput = Console.ReadLine();

                EmailValidatorHelper emailValidatorHelper = new EmailValidatorHelper();

                if (emailValidatorHelper.IsValidEmail(emailInput))
                {
                    try
                    {
                        var apiCallHelper = new ApiCallHelper();
                        apiCallHelper.ContactApiCallerAsync(emailInput).Wait();
                    }
                    catch (Exception)
                    {
                        System.Console.WriteLine("failed attempt");
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a valid email address and try again.");
                    continue;
                }
            }
            Console.ReadLine();
        }

    }
}