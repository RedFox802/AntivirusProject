using Antivirus.Messages;
using Antivirus.Scans;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Antivirus.Shadule
{
    static class ShaduleHandler
    {
        private static DateTime TimeForScan = default(DateTime);
        private static String Path = "";


        public static void MessageHandlerForShadule(String operation)
        {
            String[] newArray = operation.ToString().Split('#');
            DateTime newTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, Convert.ToInt32(newArray[1]), Convert.ToInt32(newArray[2]), 0);
            TimeForScan = newTime;
            Path = newArray[0];
        }


        public static String StartTask()
        {
            while (true)
            {
                if (TimeForScan != default(DateTime))
                {
                    while (TimeForScan.Hour != DateTime.Now.Hour || TimeForScan.Minute != DateTime.Now.Minute)
                    {
                        Task.Delay(10000);
                    }

                    List<String> viruses = Scan.ScanFolder(Path);

                    String result = "";
                    if (viruses.Count > 0)
                    {
                        ChooseScanHandler.viruses.Clear();
                        ChooseScanHandler.viruses.AddRange(viruses);

                        foreach (var virus in viruses)
                        {
                            result += virus + "#";
                        }
                    }

                    return result;
                }
            }
        }
    }
}
