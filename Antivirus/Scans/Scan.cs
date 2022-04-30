using AntivirusLib;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Antivirus.Scans
{
    static class Scan
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

        public static List<String> ScanFolder(string startPath)
        {
            List<String> result = new List<string>();

            var files = GetFiles(startPath);

            foreach (var file in files)
            {
                String strangeThing = file.Replace(@"\", @"\\\").Replace(@"\\\\\\\\\", @"\\\");
                String scanres = ScanFile(strangeThing);

                switch (scanres)
                {
                    case "None":
                        break;
                    case MessagesData.resultStop:
                        return new List<String> { MessagesData.resultStop };
                    default:
                        result.Add(scanres);
                        break;
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
            try
            {
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
                        return new string[] {MessagesData.resultStop };
                    }
                    if (PEProv(file))
                    {
                        files.Add(file);
                    }
                }


                foreach (var directory in Directory.GetDirectories(path))
                {
                    if (IsStop) return new string[] { MessagesData.resultStop };

                    files.AddRange(GetFiles(directory));
                }

            }
            catch (Exception ex) { }

            return files.ToArray();
        }


        public static bool PEProv(string file)
        {
            using (var reader = new FileStream(file, FileMode.Open))
            {
                byte[] header = new byte[2];
                int readed = reader.Read(header, 0, header.Length);

                if (header[0] == 'M' && header[1] == 'Z')//DOS header
                {
                    byte[] PEStart = new byte[4];

                    reader.Seek(60, SeekOrigin.Begin);
                    readed = reader.Read(PEStart, 0, PEStart.Length);

                    if (readed < 4) return false;
                    else
                    {
                        int addr = BitConverter.ToInt32(PEStart, 0);
                        reader.Seek(addr, SeekOrigin.Begin);
                        reader.Read(PEStart, 0, PEStart.Length);

                        if (PEStart[0] == 'P' && PEStart[1] == 'E' && PEStart[2] == 0 && PEStart[3] == 0)
                            return true;
                    }
                }

                else if (header[0] == 'P' && header[1] == 'E')//PE header
                {
                    reader.Read(header, 2, header.Length);
                    if (header[0] == 0 && header[1] == 0)
                        return true;
                }

                return false;
            }
        }

        public static String ScanMonitoringFile(string fileName)
        {
            byte[] byteArrayFile = File.ReadAllBytes(fileName);

            foreach (var signature in txtsign)
            {

                if (CheckSignatureAsyncMonitoring(byteArrayFile, signature).Result)
                {
                    return fileName;
                }

            }
            return "None";

        }

        public static async Task<bool> CheckSignatureAsyncMonitoring(byte[] file, string signature)
        {
            try
            {
                int lengthFile = file.Length;
                string[] charsSignature = signature.Split(' ');

                int lengthSignature = charsSignature.Length;
                int k = 0;
                for (int i = 0; i < lengthFile; i++)
                {

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
            }
            catch (Exception ex) { }
            return false;
        }

    }
}
