#### Please read below there are changes after 6th April 2020 by SendGrid
https://sendgrid.com/docs/for-developers/sending-email/sender-identity
\
https://sendgrid.com/docs/ui/sending-email/sender-verification

#### Recommandation
Use Domain Authentication


#### Create a .NET Core Console App

Add nuget packages to newly create project
```
Install-Package SendGrid
```

Sample Code
```
using System;
using System.Threading.Tasks;
using SendGrid;
using SendGrid.Helpers.Mail;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            Task.WaitAll(MainAsyn());
            Console.Read();
        }

        static async Task MainAsyn()
        {
            //var apiKey = Environment.GetEnvironmentVariable("SENDGRID_API_KEY");
            var client = new SendGridClient("<<Your SendGrid API Key>>");
            var from = new EmailAddress("contact@<<your domain>>.com", "This From Email Address");
            var subject = "Sending with Twilio SendGrid is Fun";
            var to = new EmailAddress("user@example.com", "Example User");
            var plainTextContent = "and easy to do anywhere, even with C#";
            var htmlContent = "<strong>and easy to do anywhere, even with C#</strong>";
            var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
            var response = await client.SendEmailAsync(msg).ConfigureAwait(false);
            Console.WriteLine(response.StatusCode);
            Console.WriteLine(response.Headers.ToString());
        }
    }
}

```
