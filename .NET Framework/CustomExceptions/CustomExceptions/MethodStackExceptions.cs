using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomExceptions
{
    class MethodStackExceptions
    {
        static void Main(string[] args)
        {
            try
            {
                Method1();
            }
            catch (Exception ex)
            {
                Console.WriteLine();
                Console.WriteLine("----------------------------------");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Modified/Custom Exception");
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
                Console.WriteLine(ex.InnerException);
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
            Console.ReadKey();
        }

        static void Method1()
        {
            try
            {
                Method2();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        static void Method2()
        {
            string str = null;
            try
            {
                Console.WriteLine(str[0]);
            }
            catch (Exception ex)
            {
                throw new CustomException("Some think went wrong",ex);
                //throw new Exception();
            }
        }
    }
}
