using Antivirus.Messages;
using Antivirus.Scans;
using Antivirus.Sockets;
using AntivirusLib;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;

namespace Antivirus.Monitoring
{
    static class MonitoringHandler
    {
        private static Dictionary<String, Thread> Directories = new Dictionary<string, Thread>();
        private static Socket currentLisener;

        public static async Task MessageHandlerForMonitoring(String operation, Socket listener)
        {
            currentLisener = listener;

            String[] newArray = operation.ToString().Split('#');
            String path = newArray[1];

            switch (newArray[0])
            {
                case MessagesData.monitoringAdd:
                    Thread newMonitoringThread = new Thread(new ParameterizedThreadStart(CreateMonitor));
                    newMonitoringThread.Start(path);
                    Directories.Add(path, newMonitoringThread);
                    break;
                case MessagesData.monitoringDelete:
                    DeleteDirectory(path);
                    break;
            }
        }

        private static void CreateMonitor(Object path)
        {
            using var watcher = new FileSystemWatcher((string)path);

            watcher.NotifyFilter = NotifyFilters.Attributes
                                 | NotifyFilters.CreationTime
                                 | NotifyFilters.DirectoryName
                                 | NotifyFilters.FileName
                                 | NotifyFilters.LastAccess
                                 | NotifyFilters.LastWrite
                                 | NotifyFilters.Security
                                 | NotifyFilters.Size;

            watcher.Created += OnCreated;

            watcher.Filter = "*.*";
            watcher.IncludeSubdirectories = true;
            watcher.EnableRaisingEvents = true;

            //while (true) Task.Delay(1000);
        }

        private static void OnCreated(object sender, FileSystemEventArgs e)
        {
            if (Scan.PEProv(e.FullPath))
            {
                String scanResult = Scan.ScanMonitoringFile(e.FullPath);

                if (scanResult != MessagesData.resultNone)
                {
                    ChooseScanHandler.viruses.Add(scanResult);
                    MonitoringSocket.SentMessage(currentLisener, scanResult);
                }
            }
        }

        private static async Task DeleteDirectory(String path)
        {
            if (Directories.ContainsKey(path)) {

                Thread pathTh = Directories[path];

                try { pathTh.Abort(); }
                catch (Exception ex) { }

                Directories.Remove(path);
            }
        }
    }
}
