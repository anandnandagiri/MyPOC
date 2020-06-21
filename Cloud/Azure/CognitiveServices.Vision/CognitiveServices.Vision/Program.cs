using System;
using System.Net.Http.Headers;
using System.Text;
using System.Net.Http;
using System.Web;
using System.IO;
using Microsoft.Rest;
using Microsoft.Extensions.Configuration;

namespace CognitiveServices.Vision
{
    static class Program
    {
        private static IConfiguration Configuration;

        static void Main(string[] args)
        {

            Configuration = new ConfigurationBuilder()
                        .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                        .AddEnvironmentVariables()
                        .AddCommandLine(args)
                        .Build();

            MakeRequest();
            Console.WriteLine("Process Completed Press Any Key To Exit...");
            Console.ReadLine();
        }

        static async void MakeRequest()
        {
            var client = new HttpClient();
            var queryString = HttpUtility.ParseQueryString(string.Empty);

            // Request headers
            client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key",Configuration["ComputerVision:SubscriptionKey"]);

            // Request parameters
            queryString["language"] = "unk";
            queryString["detectOrientation"] = "true";
            var uri = Configuration["ComputerVision:VisionAPIURL"] + queryString;

            HttpResponseMessage response;

            // Request body
            byte[] byteData = File.ReadAllBytes(Path.Combine("Images", "MyCode.PNG"));

            using (var content = new ByteArrayContent(byteData))
            {
                content.Headers.ContentType = new MediaTypeHeaderValue("application/octet-stream");
                response = await client.PostAsync(uri, content);
            }
            Console.WriteLine(response.Content.AsString());
        }
    }
}