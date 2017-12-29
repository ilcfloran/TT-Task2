using ContactAPILibrary;
using System;
using System.Threading.Tasks;

namespace TT_Task2
{
    public class ApiCallHelper
    {
        public async Task ContactApiCallerAsync(string email)
        {
            try
            {
                //Service service = new TT_Task2.Service();
                // call another helper to map to the Person
                FullContactApi fullContactApi = new FullContactApi();
                ContactAPILibrary.Models.Models.FullContactPerson result = new ContactAPILibrary.Models.Models.FullContactPerson();

                result = await fullContactApi.LookupPersonByEmailAsync(email);
                Console.WriteLine(result);
            }
            catch (Exception)
            {
                System.Console.WriteLine("failed attempt");
            }

            Console.ReadLine();
        }
    }
}
