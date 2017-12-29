using ContactAPILibrary.Interfaces;
using RestSharp;
using RestSharp.Deserializers;
using System;
using System.Threading.Tasks;

namespace ContactAPILibrary
{
    public class FullContactApi : IFullContactApi
    {
        // API Caller, accepts email string, run the task in async mode and return the results to the caller.
        public async Task<Models.Models.FullContactPerson> LookupPersonByEmailAsync(string email)
        {

            var emptyObj = new Models.Models.FullContactPerson();

            try
            {
                var result = await Task.Run(() =>
                {
                    var client = new RestClient("https://api.fullcontact.com/");
                    var request = new RestRequest("v3/person.enrich", Method.POST);

                    request.AddHeader("Authorization", "Bearer ");


                    String emailString = $@"{{""email"":""{email}""}}";

                    //"{\"email\":\"bart@fullcontact.com\"}"

                    request.AddParameter("application/json", emailString, ParameterType.RequestBody);
                    //request.AddParameter("application/json", "{\"webhookurl\":\"http://www.fullcontact.com/hook\"}", ParameterType.RequestBody);


                    var response = client.Execute(request);

                    IRestResponse content = new RestResponse { Content = response.Content };
                    Console.WriteLine(content.Content);
                    var wptResponse = new JsonDeserializer().Deserialize<Models.Models.FullContactPerson>(content);

                    return wptResponse;
                });

                //string json = JsonConvert.SerializeObject(result, Formatting.Indented);
                //Console.WriteLine(json);
                return result;
            }
            catch (Exception)
            {
                System.Console.WriteLine("Error");
                return emptyObj;
            }

        }
    }
}

