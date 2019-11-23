using Microsoft.Owin.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MyProduct.MicroService.WebAPI.SelfHost
{
    class Program
    {
        static void Main(string[] args)
        {
            string baseAddress = "http://localhost:9000/";

            //Start Product Service With OWIN Startup Class 
            using (WebApp.Start<Startup>(url: baseAddress))
            {
                Console.WriteLine(@"Press Any Key to Stop Product Service (http:///localhost:9000/api/Product)...."); 
                Console.ReadLine();
            }             
        }
    }
}
