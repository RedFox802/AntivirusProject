using AntivirusLib;
using System.ServiceProcess;

namespace UIAntivirus.ServiceInteraction
{
    class MyServiceProvider
    {
        public static void StartAntivirus()
        {
            ServiceController[] scServices;
            scServices = ServiceController.GetServices();

            foreach (ServiceController scTemp in scServices)
            {

                if (scTemp.ServiceName == MessagesData.serviceName)
                {
                    ServiceController sc = new ServiceController(MessagesData.serviceName);
                    if (sc.Status == ServiceControllerStatus.Stopped)
                    {
                        sc.Start();
                    }

                    sc.Close();
                }
            }
        }
    }
}
