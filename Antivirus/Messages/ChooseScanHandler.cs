using Antivirus.Scans;
using AntivirusLib;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Antivirus.Messages
{
    static class ChooseScanHandler
    {

        public static List<string> viruses = new List<string>();

        public static String Processing(String operation)
        {
            String ResultOperation = "";
            String[] messArr = operation.ToString().Split('#');

            switch (messArr[0])
            {
                case MessagesData.scanFile:
                    ResultOperation = FileScan(messArr[1]);
                    Scan.SetStop(false);
                    break;
                case MessagesData.scanPath:
                    ResultOperation = PathScan(messArr[1]);
                    Scan.SetStop(false);
                    break;

                case MessagesData.delete:
                    ResultOperation = DeleteVirus(messArr[1]);
                    break;
                case MessagesData.deleteAll:
                    ResultOperation = DeleteViruses();
                    break;
                case MessagesData.carantine:
                    ResultOperation = CarantineViruses();
                    break;

                case MessagesData.carantineShow:
                    String Result = Quarantine.ShowCarantineForSent();
                    if (Result != "") ResultOperation = Result;
                    else ResultOperation = "None";
                    break;
                case MessagesData.carantineRecoverAll:
                    ResultOperation = Quarantine.GoOutCarantineAll();
                    break;
                case MessagesData.carantineDeleteAll:
                    ResultOperation = Quarantine.DeleteAll();
                    break;
                case MessagesData.carantineDeleteOne:
                    ResultOperation = Quarantine.DeleteOne(messArr[1]);
                    break;
                case MessagesData.carantineRecoverOne:
                    ResultOperation = Quarantine.GoOutCarantine(messArr[1]);
                    break;

                case MessagesData.scanPause:
                    Scan.SetPause(true);
                    break;
                case MessagesData.scanContinue:
                    Scan.SetPause(false);
                    break;
                case MessagesData.scanStop:
                    Scan.SetStop(true);
                    break;
            }

            return ResultOperation;
        }

        #region Scans
        private static String FileScan(String path)
        {
            viruses.Clear();
            String ScanResult = Scan.ScanFile(path);

            if (ScanResult != "None")
            {
                if (ScanResult == MessagesData.resultStop) return MessagesData.resultStop;

                viruses.Add(ScanResult);
                return ScanResult;
            }
            else return MessagesData.resultNone;
        }


        private static String PathScan(String path)
        {
            viruses.Clear();
            List<string> ListResult = Scan.ScanFolder(path);

            if (ListResult.Count > 0)
            {
                if (ListResult.Contains(MessagesData.resultStop)) return MessagesData.resultStop;

                viruses.AddRange(ListResult);
                String result = "";
                foreach (String item in ListResult) { result += item + "#"; }
                return result;
            }
            else return MessagesData.resultNone;
        }

        #endregion

        #region Delete

        public static String DeleteVirus(String fileName)
        {
            viruses.Remove(fileName);

            String disk = fileName.Substring(0, 3);
            if (IsFixed(disk))
            {
                RecycleBin recycle = new RecycleBin();
                if (File.Exists(fileName)) recycle.Recycle(fileName);
                return MessagesData.resultDelete;
            }
            else
            {
                File.Delete(fileName);
                return MessagesData.resultDelete;
            }
        }

        private static String DeleteViruses()
        {
            foreach (String item in viruses)
            {
                String disk = item.Substring(0, 3);
                if (IsFixed(item))
                {
                    RecycleBin recycle = new RecycleBin();
                    if (File.Exists(item)) recycle.Recycle(item);
                }
                else File.Delete(item);
            }

            viruses.Clear();
            return MessagesData.resultDelete;
        }

        private static bool IsFixed(String currentDisk)
        {
            List<DriveInfo> disks = DriveInfo.GetDrives().ToList();
            foreach(DriveInfo disk in disks)
            {
                if (disk.Name == currentDisk)
                {
                    if (disk.DriveType == DriveType.Fixed) return true;
                    else return false;
                }
            }
            return false;
        }

        #endregion

        #region Carantine

        private static String CarantineViruses()
        {
            foreach (String item in viruses) Quarantine.GoInCarantine(item);
            viruses.Clear();
            return MessagesData.resultCarantine;
        }
        #endregion
    }
}
