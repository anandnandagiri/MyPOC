using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CustomExceptions
{
    class CustomException : Exception
    {
        public CustomException()
        {
        }

        public CustomException(string message)
            : base(message)
        {
          
        }

        
        //Sometime we need suppress inner exception to throw and log to database below is the twike done
        //Base Class Exception is set with new Exception() so that it suppress when we throw exception
        //This suppress is need to not disclose exception to end user or hacker
        public CustomException(string message, Exception ex) : base(message,new Exception())              
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Custom Exception Dervied from Exception");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("----------------------------------");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Actuals Exception");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("----------------------------------");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("TargetSite: ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(ex.TargetSite);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Source:");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(ex.Source);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("StackTrace:");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(ex.StackTrace);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("InnerException:");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine( ex.InnerException);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Message:");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(ex.Message);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("GetType:");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(ex.GetType());
            Console.WriteLine();
            Console.ResetColor();               
           
        }

        public override string Source
        {
            get
            {
                return "";
            }
        }

        public override string StackTrace
        {
            get
            {
                return "";
            }
        }

        public  MethodBase TargetSite
        { 
            get; 
        }

    }
}
