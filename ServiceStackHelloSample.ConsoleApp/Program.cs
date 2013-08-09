using System;
using ServiceStack.ServiceClient.Web;
using ServiceStackHelloSample.ServiceModel.Operations;
using ServiceStackHelloSample.ConsoleApp.ServiceStackHelloWebService;

namespace ServiceStackHelloSample.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            JsonServiceClient client = new JsonServiceClient("http://localhost:8080/");
            HelloResponse response = client.Get<HelloResponse>("/hello");
            Console.WriteLine(response.Result.ToString());
            Console.ReadLine();
        }
    }
}
