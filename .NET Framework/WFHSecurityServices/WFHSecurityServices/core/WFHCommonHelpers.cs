using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace WFHSecurityServices.core
{
    public static class WFHCommonHelpers
    {
        private static string _exepath = Path.GetDirectoryName(new Uri(Assembly.GetExecutingAssembly().CodeBase).LocalPath);

        public static string ExePath {
            get
            {
                return _exepath;
            }
           }

        public static string ServiceCSVFilePath
        {
            get
            {
                return Path.Combine(_exepath,"csv", "services.csv");
            }
        }

    }
}
