using AntivirusLib;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Antivirus.Scans
{
    //Плохое повторение кода для отдельной паузы и стопа для ручного и сканирования дисков 
    public static class FullScan
    {
        private static bool IsPause = false;
        private static bool IsStop = false;
        private static List<string> txtsign = File.ReadAllLines(MessagesData.signatureFile).ToList();

        public static void SetStop(bool stop)
        {
            IsStop = stop;
        }
        public static void SetPause(bool pause)
        {
            IsPause = pause;
        }

        public static List<String> FulllScan(DriveType discType)
        {
            List<DriveInfo> discs = DriveInfo.GetDrives().ToList();
            List<String> result = new List<string>();

            switch (discType)
            {
                case DriveType.Unknown:
                    result = ScanMachine(discs);
                    break;
                default:
                    List<DriveInfo> neededDisks = new List<DriveInfo>();
                    foreach (var disk in discs)
                    {
                        if (disk.DriveType == discType) neededDisks.Add(disk);
                    }
                    if (neededDisks.Count == 0) return new List<string> { MessagesData.resultNoDiscs };
                    result = ScanMachine(neededDisks);
                    break;

            }
            return result;
        }

        public static List<String> ScanMachine(List<DriveInfo> discs)
        {
            List<String> result = new List<string>();
            foreach (var disc in discs)
            {
                var files = GetFiles(disc.Name);
                if (files.Length > 0)
                {
                    if (files[0] == MessagesData.resultStop) return new List<String> { MessagesData.resultStop };
                }

                foreach (var file in files)
                {
                    while (IsPause)
                    {
                        Task.Delay(1000);
                    }

                    String scanres = ScanFile(file);
                    if (scanres != "None")
                    {
                        if (scanres == MessagesData.resultStop)
                        {
                            return new List<String> { MessagesData.resultStop };
                        }
                        result.Add(scanres);
                    }
                }
            }
            return result;
        }

        public static String ScanFile(string fileName)
        {
            byte[] byteArrayFile = File.ReadAllBytes(fileName);

            foreach (var signature in txtsign)
            {
                if (IsStop)
                {
                    return MessagesData.resultStop;
                }

                if (CheckSignatureAsync(byteArrayFile, signature).Result)
                {

                    if (IsStop)
                    {
                        return MessagesData.resultStop;
                    }
                    return fileName;
                }

            }
            return "None";
        }

        public static async Task<bool> CheckSignatureAsync(byte[] file, string signature)
        {
            int lengthFile = file.Length;
            string[] charsSignature = signature.Split(' ');

            int lengthSignature = charsSignature.Length;
            int k = 0;
            for (int i = 0; i < lengthFile; i++)
            {
                if (IsStop)
                {
                    return false;
                }
                //пауза сканирования
                while (IsPause)
                {
                    await Task.Delay(1000);
                }

                if (charsSignature[k] == "??" || byte.Parse(charsSignature[k], NumberStyles.HexNumber) == file[i])
                {
                    k++;
                }
                else
                {
                    k = 0;
                    continue;
                }

                if (k == lengthSignature) return true;
            }
            return false;
        }

        private static string[] GetFiles(string path)
        {
            var files = new List<string>();
            if (IsStop)
            {
                return new string[] { MessagesData.resultStop };
            }

            string[] allFiles = Directory.GetFiles(path, "*.*", SearchOption.TopDirectoryOnly);
            foreach (var file in allFiles)
            {

                while (IsPause)
                {
                    Task.Delay(1000);
                }

                if (IsStop)
                {
                    return new string[] { MessagesData.resultStop };
                }

                if (Scan.PEProv(file))
                {
                    files.Add(file);
                }
            }


            foreach (var directory in Directory.GetDirectories(path))
            {
                if (IsStop) return new string[] { MessagesData.resultStop };

                files.AddRange(GetFiles(directory));
            }

            return files.ToArray();
        }
    }
}
