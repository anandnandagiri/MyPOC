using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Mail;
using System.Text;

namespace DotNetCoreEmail
{
    public class Email
    {
        public static IConfiguration Configuration { get; set; }

        public Email()
        {
            var builder = new ConfigurationBuilder()
           .SetBasePath(Directory.GetCurrentDirectory())
           .AddJsonFile("appsettings.json");

            Configuration = builder.Build();
            //Console.WriteLine(Configuration["FromPassword"]);
        }

        public void SendEmail(string toAddress, string subject, string body)
        {

            string senderID = Configuration["From"];
            string senderPassword = Configuration["FromPassword"];
            try
            {
                SmtpClient smtp = new SmtpClient
                {
                    Host = Configuration["SMTPServer"],
                    Port = Convert.ToInt32(  Configuration["SMTPPort"]),
                    EnableSsl = Convert.ToBoolean( Configuration["EnableSsl"]),
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    Credentials = new System.Net.NetworkCredential(senderID, senderPassword),
                    Timeout = Convert.ToInt32(Configuration["Timeout"]),
                };
                MailMessage message = new MailMessage(senderID, toAddress, subject, body);
                smtp.Send(message);
                Console.WriteLine();
                Console.WriteLine("Email Has Been Sent To :" + toAddress);
                Console.WriteLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine();
                Console.WriteLine("Please Provide Correct Configurnation in appsetting.json below is the exception happen");
                Console.WriteLine(ex.Message);
                Console.WriteLine();
            }

        }
    }
}


