using AntivirusLib;
using System.ServiceProcess;
using System.Threading;

namespace Antivirus.WatchDog
{
    static class Watch
    {
        private static ServiceController sc;
        public static void WatchForWatchDog()
        {
            ServiceController[] scServices;
            scServices = ServiceController.GetServices();

            foreach (ServiceController scTemp in scServices)
            {

                if (scTemp.ServiceName == MessagesData.watchdogName)
                {
                    while (true)
                    {
                        sc = new ServiceController(MessagesData.watchdogName);
                        if (sc.Status == ServiceControllerStatus.Stopped) sc.Start();
                        Thread.Sleep(1000);
                    }
                }
            }
        }

    }
}
