using AntivirusLib;
using System;
using System.ServiceProcess;
using System.Threading;

namespace WatchDog.WatchFolder
{
    static class Watch 
    {
        private static ServiceController sc;

        public static void WatchDog()
        {
            ServiceController[] scServices;
            scServices = ServiceController.GetServices();

            foreach (ServiceController scTemp in scServices)
            {

                if (scTemp.ServiceName == MessagesData.serviceName)
                {
                    while (true)
                    {
                        sc = new ServiceController(MessagesData.serviceName);
                        if (sc.Status != ServiceControllerStatus.Running)
                        {
                            try
                            {
                                sc.Start();
                            }
                            catch (Exception e) { }
                        }

                        Thread.Sleep(1000);
                    }
                }
            }
        }
    }
}
