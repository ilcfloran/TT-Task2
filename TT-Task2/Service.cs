using RestSharp;
using RestSharp.Deserializers;
using System;
using System.Threading.Tasks;
using TT_Task2.Models;

namespace TT_Task2
{
    //service
    public class Service
    {

        public async Task callingAsync()
        {

            try
            {
                //Rest of the code is executed as the continuation code. and will be called in
                // the calling context
                var result = await Task.Run(() =>
                {
                    var client = new RestClient("https://api.fullcontact.com/");
                    var request = new RestRequest("v3/person.enrich", Method.POST);

                    request.AddHeader("Authorization", "Bearer ");

                    //request.AddParameter("email", "bart@fullcontact.com");
                    //request.AddParameter("webhookUrl", "http://www.fullcontact.com/hook");

                    request.AddParameter("application/json", "{\"email\":\"bart@fullcontact.com\"}", ParameterType.RequestBody);
                    request.AddParameter("application/json", "{\"webhookurl\":\"http://www.fullcontact.com/hook\"}", ParameterType.RequestBody);


                    var response = client.Execute(request);

                    Console.WriteLine("Temp Output *****************************");
                    //var content = response.Content;
                    IRestResponse content = new RestResponse { Content = response.Content };
                    Console.WriteLine(content.Content);
                    var wptResponse = new JsonDeserializer().Deserialize<RootObject>(content);




                    return wptResponse;
                });

                //string json = JsonConvert.SerializeObject(result, Formatting.Indented);
                //Console.WriteLine(json);
            }
            catch (Exception)
            {
                System.Console.WriteLine("Error");
            }
        }

    }

}
