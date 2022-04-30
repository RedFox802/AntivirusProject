using Antivirus.Sockets;
using Antivirus.WatchDog;
using System.ServiceProcess;
using System.Threading;

namespace Antivirus
{
    public partial class AntivirusProject : ServiceBase
    {
        public AntivirusProject()
        {
            InitializeComponent();

            //Запрет остановки службы после запуска
            this.CanStop = false;
            this.CanPauseAndContinue = false;
        }

        protected override void OnStart(string[] args)
        {
            Thread SocketThread = new Thread(GeneralSocket.CreateGeneralSocket);
            SocketThread.Start();

            Thread SocketThreadFull = new Thread(DiscsScanSocket.CreateSocketFullScan);
            SocketThreadFull.Start();

            Thread ShaduleThread = new Thread(SheduleSocket.CreateShaduleSocket);
            ShaduleThread.Start();

            Thread MonitoringThread = new Thread(MonitoringSocket.CreateMonitoringgSocket);
            MonitoringThread.Start();

            //Thread WatchThread = new Thread(Watch.WatchForWatchDog);
            //WatchThread.Start();
        }

        protected override void OnStop()
        {
            GeneralSocket.FinishSocket();
            DiscsScanSocket.FinishSocket();
            SheduleSocket.FinishSocket();
            MonitoringSocket.FinishSocket();
        }
    }
}
