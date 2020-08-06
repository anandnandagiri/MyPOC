using System;
using System.Linq;
using EFCore.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Please Read ReadMe File If Your New To Entity Framework Core!!!");
            Console.WriteLine();
            Console.ResetColor();

            WFMContext db = new WFMContext();
            var utilization = db.EmpUtilization.Include(u=>u.Emp).Where(u => u.EmpID == 123).FirstOrDefault();
            if(utilization!=null)
            {
                Console.WriteLine($"Employee Name {utilization.Emp.EmpName}" );
            }
            else
            {
                Console.WriteLine("Employee Not Found....Inserting sample record with EmpID  123");

                EmpUserInfo user = new EmpUserInfo();
                user.EmpID = 123;
                user.EmpLogin = "123";
                user.EmpName = "Anand";
                db.Add(user);
                db.SaveChanges();
                
                EmpUtilization util = new EmpUtilization();
                util.EmpID = 123;
                db.Add(util);
                db.SaveChanges();

                Console.WriteLine("Employee is added to db");
            }
            Console.WriteLine();
            Console.WriteLine("Please Press Any Key To Continue");
            Console.Read();
        }
    }
}
