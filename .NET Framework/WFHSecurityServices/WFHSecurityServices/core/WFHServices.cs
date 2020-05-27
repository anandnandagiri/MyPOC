using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using WFHSecurityServices.core;

namespace WFHSecurityServices
{
    public class WFHServices
    {
        public static void StartService(string serviceName, int timeoutMilliseconds)
        {
            ServiceController service = new ServiceController(serviceName);
            try
            {
                TimeSpan timeout = TimeSpan.FromMilliseconds(timeoutMilliseconds);

                service.Start();
                service.WaitForStatus(ServiceControllerStatus.Running, timeout);
            }
            catch (Exception ex)
            {
                WFHLog.WriteLog(serviceName, ex.Message);
            }
        }

        public static void StopService(string serviceName, int timeoutMilliseconds)
        {
            ServiceController service = new ServiceController(serviceName);
            try
            {
                TimeSpan timeout = TimeSpan.FromMilliseconds(timeoutMilliseconds);

                service.Stop();
                service.WaitForStatus(ServiceControllerStatus.Stopped, timeout);
            }
            catch (Exception ex)
            {
                WFHLog.WriteLog(serviceName, ex.Message);
            }
        }
                
        public static void RestartService(string serviceName, int timeoutMilliseconds)
        {
            ServiceController service = new ServiceController(serviceName);
            try
            {
                int millisec1 = Environment.TickCount;
                TimeSpan timeout = TimeSpan.FromMilliseconds(timeoutMilliseconds);

                service.Stop();
                service.WaitForStatus(ServiceControllerStatus.Stopped, timeout);

                // count the rest of the timeout
                int millisec2 = Environment.TickCount;
                timeout = TimeSpan.FromMilliseconds(timeoutMilliseconds - (millisec2 - millisec1));

                service.Start();
                service.WaitForStatus(ServiceControllerStatus.Running, timeout);
            }
            catch (Exception ex)
            {
                WFHLog.WriteLog(serviceName, ex.Message);
            }
        }

        public static void ChangeStartMode(string serviceName, ServiceStartMode mode)
        {
            ServiceController service = new ServiceController(serviceName);
            WFHServiceHelper.ChangeStartMode(service, mode);
        }


        public static bool IsServiceExists(string serviceName, out ServiceStartMode mode)
        {
            var serviceExists = ServiceController.GetServices().Any(s => s.ServiceName == serviceName);
            if(serviceExists)
            {
               var serv = ServiceController.GetServices().Where(s => s.ServiceName == serviceName).FirstOrDefault();
                if(serv !=null)
                {
                    mode = serv.StartType;
                    return true;
                }
            }
            mode = ServiceStartMode.Boot;
            return serviceExists;
        }


        public static void GetServiceList()
        {

            var services = ServiceController.GetServices().OrderBy(u => u.DisplayName).ToList();
            foreach(var srv in services)
            {
                WFHLog.WriteLog($"{srv.DisplayName.Replace(",","")},{srv.ServiceName.Replace(",", "")},{srv.Status.ToString().Replace(",","")},{srv.StartType.ToString().Replace(",","")}, {srv.ServiceType.ToString().Replace(",", "")}   ");
            }


        }


    }
}
