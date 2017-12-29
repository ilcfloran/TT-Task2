using System;
using TT_Task2.Models;

namespace TT_Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Program Started");
            System.Console.WriteLine("**********************");

            RootObject result = new RootObject();
            try
            {
                Service service = new TT_Task2.Service();
                // call another helper to map to the Person
                service.callingAsync().Wait();
            }
            catch (Exception)
            {
                System.Console.WriteLine("failed attempt");
            }

            Console.ReadLine();
        }

    }
}
