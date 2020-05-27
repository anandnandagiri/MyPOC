using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFHSecurityServices.core
{
    public static class WFHLog
    {

        private static string WFH_LOG_FILE =   Environment.MachineName +"_"+ DateTime.Now.ToString("yyyy_MM_dd_HH_mm_ss") + ".txt";

        public static void WriteLog(string servicename, string log)
        {
            Console.WriteLine();
            Console.WriteLine("Service:" + servicename);
            Console.WriteLine("Log:" + log);

        }

        public static void WriteLog(string log)
        {      
            Console.WriteLine(log);               
            File.AppendAllText(WFH_LOG_FILE, $"{log} {Environment.NewLine}" );
        }

        public static void ReadMessage(string msg = "Press Any Key To Continue...")
        {
            Console.WriteLine(msg);
            Console.Read();
        }
    }
}
