using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace dotNetCoreStaticFiles
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>

        //A1# Default to Kestrel Server
        //WebHost.CreateDefaultBuilder(args)
        //    .UseStartup<Startup>();

        //A2# Use Kestrel and IISIntegration Which works with <=.net core 2.1
        //WebHost.CreateDefaultBuilder(args)
        //        .UseKestrel()
        //        .UseContentRoot(Directory.GetCurrentDirectory())
        //        .UseIISIntegration()
        //        //.ConfigureLogging((hostingContext, logging) =>
        //        //{
        //        //    logging.AddConfiguration(hostingContext.Configuration.GetSection("Logging"));
        //        //    logging.AddConsole(options => options.IncludeScopes = true);
        //        //    logging.AddDebug();
        //        //})
        //        .UseStartup<Startup>();

        //A3# Use Kestrel and IIS
        WebHost.CreateDefaultBuilder(args)
                .UseKestrel()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseIIS()
                //.ConfigureLogging((hostingContext, logging) =>
                //{
                //    logging.AddConfiguration(hostingContext.Configuration.GetSection("Logging"));
                //    logging.AddConsole(options => options.IncludeScopes = true);
                //    logging.AddDebug();
                //})
                .UseStartup<Startup>();

    }
}
