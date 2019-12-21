using Microsoft.Extensions.Configuration;
using System;
using System.IO;
using System.Net;
using System.Net.Mail;


namespace DotNetCoreEmail
{
    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Please Provide Email To:");
            string emailTo = Console.ReadLine();
            Console.WriteLine("Please Provide Email Subject: ");
            string emailSubject = Console.ReadLine();
            Console.WriteLine("Please Provide Email Body: ");
            string emailBody = Console.ReadLine();
            //Console.WriteLine(emailTo);

            Email email = new Email();
            email.SendEmail(emailTo, emailSubject, emailBody);



            Console.WriteLine("");
            Console.WriteLine("Email Process Completed");
            Console.Read();
        }
    }
}
