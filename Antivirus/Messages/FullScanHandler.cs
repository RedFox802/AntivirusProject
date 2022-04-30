using Antivirus.Scans;
using AntivirusLib;
using System;
using System.Collections.Generic;
using System.IO;

namespace Antivirus.Messages
{
    static class FullScanHandler
    {
        public static String Processing(String operation)
        {
            String ResultOperation = "";
            String[] messArr = operation.ToString().Split('#');

            switch (messArr[0])
            {
                case MessagesData.scanFull:
                    ResultOperation = MyFullScan(messArr[1]);
                    FullScan.SetStop(false);
                    break;
                case MessagesData.scanFullPause:
                    FullScan.SetPause(true);
                    break;
                case MessagesData.scanFullContinue:
                    FullScan.SetPause(false);
                    break;
                case MessagesData.scanFullStop:
                    FullScan.SetStop(true);
                    break;
            }

            return ResultOperation;
        }

        private static String MyFullScan(String command)
        {
            ChooseScanHandler.viruses.Clear();
            List<string> ListResult = new List<string>();

            switch (command)
            {
                case MessagesData.fullComp:
                    ListResult = FullScan.FulllScan(DriveType.Unknown);
                    break;
                case MessagesData.fullOwn:
                    ListResult = FullScan.FulllScan(DriveType.Fixed);
                    break;
                case MessagesData.fullRem:
                    ListResult = FullScan.FulllScan(DriveType.Removable);
                    break;
            }

            if (ListResult.Count > 0)
            {
                if (ListResult.Contains(MessagesData.resultStop)) return MessagesData.resultStop;
                if (ListResult.Contains(MessagesData.resultNoDiscs)) return MessagesData.resultNoDiscs;

                ChooseScanHandler.viruses.AddRange(ListResult);

                String result = "";
                foreach (String item in ListResult) { result += item + "#"; }
                return result;
            }
            else return MessagesData.resultNone;
        }
    }
}
