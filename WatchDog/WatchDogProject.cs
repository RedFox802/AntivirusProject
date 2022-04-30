using System.ServiceProcess;
using System.Threading;
using WatchDog.WatchFolder;

namespace WatchDog
{
    public partial class WatchDogProject : ServiceBase
    {
        public WatchDogProject()
        {
            InitializeComponent();

            //чтобы нельзя было выключать
            this.CanStop = false;
            this.CanPauseAndContinue = false;
        }

        protected override void OnStart(string[] args)
        {
            Thread th = new Thread(Watch.WatchDog);
            th.Start();
        }
    }
}
