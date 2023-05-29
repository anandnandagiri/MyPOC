// See https://aka.ms/new-console-template for more information
using System.Text;

Console.WriteLine("Hello, World!");

StringBuilder sb = new StringBuilder();
sb.AppendLine(File.ReadAllText(System.IO.Path.Combine("templates", "service-worker-tamas.js")));

sb.Replace("@@@CacheFiles","Anand.txt");


Console.WriteLine(sb.ToString());
File.WriteAllText("Anand.txt",sb.ToString());   

Console.ReadLine();


