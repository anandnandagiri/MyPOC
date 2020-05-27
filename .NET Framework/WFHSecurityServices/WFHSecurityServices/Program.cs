using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using WFHSecurityServices.core;

namespace WFHSecurityServices
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] lines = File.ReadAllLines(WFHCommonHelpers.ServiceCSVFilePath);
            List<string> serviceNotFound = new List<string>();
            List<string> serviceException = new List<string>();
            List<string> serviceExecuted = new List<string>();
            List<string> serviceNoChange = new List<string>();


            WFHServices.GetServiceList();


            foreach (string line in lines)
            {
                string[] csv = line.Split(',');
                if (csv.Length > 1)
                {
                    string serviceName = csv[1];
                    string serviceDescription = csv[0];
                    string serviceStartupMode = csv[2];
                    ServiceStartMode mode;
                    bool IsServiceExists = WFHServices.IsServiceExists(serviceName, out mode);
                    if (IsServiceExists)
                    {
                        try
                        {
                            if (Enum.TryParse(serviceStartupMode, out ServiceStartMode serviceStartupModeEnum))
                            {
                                if (mode == serviceStartupModeEnum)
                                {
                                    serviceNoChange.Add($"Service:{serviceName}");
                                }
                                else
                                {
                                    WFHServices.ChangeStartMode(serviceName, serviceStartupModeEnum);
                                    serviceExecuted.Add($"Service: { serviceName}");
                                }
                            }
                            else
                            {
                                serviceException.Add($"Service: {serviceName} Enum Not Found");
                            }

                        }
                        catch (Exception ex)
                        {
                            serviceException.Add($"Service: {serviceName},{serviceDescription} with expection {ex.Message}");
                        }
                    }
                    else
                    {
                        serviceNotFound.Add($"Service: {serviceName}");
                    }
                }
            }


            WFHLog.WriteLog("");
            WFHLog.WriteLog("");
            WFHLog.WriteLog("-------------------------------");
            WFHLog.WriteLog($"Total Services {serviceNoChange.Count} No Change");
            WFHLog.WriteLog("-------------------------------");

            foreach (string s in serviceNoChange)
            {
                WFHLog.WriteLog(s);
            }

            WFHLog.WriteLog("");
            WFHLog.WriteLog("");
            WFHLog.WriteLog("-------------------------------");
            WFHLog.WriteLog($"Total Services {serviceExecuted.Count} Executed");
            WFHLog.WriteLog("-------------------------------");

            foreach (string s in serviceExecuted)
            {
                WFHLog.WriteLog(s);
            }

            WFHLog.WriteLog("");
            WFHLog.WriteLog("");
            WFHLog.WriteLog("-------------------------------");
            WFHLog.WriteLog($"Total Services {serviceNotFound.Count} Does Not Exists");
            WFHLog.WriteLog("-------------------------------");

            foreach (string s in serviceNotFound)
            {
                WFHLog.WriteLog(s);
            }

            WFHLog.WriteLog("");
            WFHLog.WriteLog("");
            WFHLog.WriteLog("-------------------------------");
            WFHLog.WriteLog($"Total Services  {serviceException.Count} With Exceptions");
            WFHLog.WriteLog("-------------------------------");
            foreach (string s in serviceException)
            {
                WFHLog.WriteLog(s);
            }

            WFHLog.WriteLog("");
            WFHLog.WriteLog("");
            WFHLog.WriteLog("");
            int total = serviceException.Count + serviceExecuted.Count + serviceNoChange.Count + serviceNotFound.Count;
            WFHLog.WriteLog($"Total Processed Service: {total}");
            WFHLog.WriteLog($"Total Provided Service: {lines.Length}");

            WFHServices.GetServiceList();

            WFHLog.ReadMessage();
            
        }
    }
}
