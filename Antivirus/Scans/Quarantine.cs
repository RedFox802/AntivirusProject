using AntivirusLib;
using System;
using System.Collections.Generic;
using System.IO;

namespace Antivirus.Scans
{
    static class Quarantine
    {

        private static readonly String quarantinePath = $@"C:\\\QuarantineDirectory";
        private static Dictionary<string, string> virusesInCarantine = new Dictionary<string, string>();


        public static String GoInCarantine(String file)
        {
            if (!Directory.Exists(quarantinePath))
                Directory.CreateDirectory(quarantinePath);

            MyXor(file);

            string newFilePath = GetCarantinePath(file);
            File.Move(file, newFilePath);

            virusesInCarantine.Add(newFilePath, file);
            return newFilePath;
        }

        public static void MyXor(string file)
        {
            byte[] header = new byte[2];
            byte[] PEStart = new byte[4];
            byte[] headerPE = new byte[2];
            int addr, readed;


            using (var reader = new FileStream(file, FileMode.Open))
            {
                readed = reader.Read(header, 0, header.Length);
            }

            if ((header[0] == 'M' && header[1] == 'Z') || (header[0] == 'E' && header[1] == 'R'))
            {
                using (var reader = new FileStream(file, FileMode.Open))
                {

                    reader.Seek(60, SeekOrigin.Begin);
                    readed = reader.Read(PEStart, 0, PEStart.Length);

                    addr = BitConverter.ToInt32(PEStart, 0);
                    reader.Seek(addr, SeekOrigin.Begin);
                    reader.Read(headerPE, 0, headerPE.Length);

                    header[0] = Convert.ToByte(Convert.ToInt32(header[0]) ^ 8);
                    header[1] = Convert.ToByte(Convert.ToInt32(header[1]) ^ 8);
                    headerPE[0] = Convert.ToByte(Convert.ToInt32(headerPE[0]) ^ 8);
                    headerPE[1] = Convert.ToByte(Convert.ToInt32(headerPE[1]) ^ 8);
                }

                using (var fileWorker = new FileStream(file, FileMode.Open))
                {
                    fileWorker.Write(header, 0, header.Length);
                }

                using (var fileWorker = new FileStream(file, FileMode.Open))
                {
                    fileWorker.Seek(60, SeekOrigin.Begin);
                    fileWorker.Seek(addr, SeekOrigin.Begin);
                    fileWorker.Write(headerPE, 0, headerPE.Length);
                }
            }
            else if ((header[0] == 'P' && header[1] == 'E') || (header[0] == 'X' && header[1] == 'M'))//PE header
            {
                header[0] = Convert.ToByte(Convert.ToInt32(header[0]) ^ 8);
                header[1] = Convert.ToByte(Convert.ToInt32(header[1]) ^ 8);

                using (var fileWorker = new FileStream(file, FileMode.Open))
                {
                    fileWorker.Write(header, 0, header.Length);
                }
            }
        }

        private static String GetCarantinePath(String file)
        {
            var safeFile = Path.ChangeExtension(file, ".virusdetected");
            var fileInfo = new FileInfo(safeFile);
            return $@"{quarantinePath}\\\{fileInfo.Name}";
        }


        public static String GoOutCarantine(String file)
        {
            String CarantinePath = GetCarantinePath(file);
            File.Move(CarantinePath, file);

            virusesInCarantine.Remove(CarantinePath);

            MyXor(file);

            var Info = new FileInfo(file);
            return $"Восстановлен файл {Info.Name}";
        }

        #region  Восстановить все
        private static void GoOut(String file)
        {
            if (virusesInCarantine.ContainsKey(file))
            {
                String oldFile = virusesInCarantine[file];
                var OldInfo = new FileInfo(oldFile);

                String returnFile = Path.ChangeExtension(file, ".exe");
                var ReturnInfo = new FileInfo(returnFile);

                string newFilePath = $@"{OldInfo.DirectoryName}\\\{ReturnInfo.Name}";
                File.Move(file, newFilePath);
                MyXor(newFilePath);
            }
        }

        public static String GoOutCarantineAll()
        {
            if (virusesInCarantine.Keys.Count > 0)
            {
                foreach (var item in virusesInCarantine.Keys) GoOut(item);
            }
            virusesInCarantine.Clear();
            return "Все восстановлено";
        }

        #endregion

        public static String DeleteAll()
        {
            RecycleBin recycle = new RecycleBin();

            if (virusesInCarantine.Keys.Count > 0)
            {
                foreach (var item in virusesInCarantine.Keys)
                {
                    recycle.Recycle(item);
                }
            }

            virusesInCarantine.Clear();
            return "Все угрозы из карантина уничтожены";
        }


        public static String DeleteOne(String file)
        {
            if (virusesInCarantine.ContainsKey(file))
            {
                RecycleBin recycle = new RecycleBin();

                String CarantinePath = GetCarantinePath(file);
                recycle.Recycle(CarantinePath);
                virusesInCarantine.Remove(CarantinePath);

                var Info = new FileInfo(CarantinePath);
                return $"Уничтожен файл {Info.Name} из карантина";
            }
            else return $"Уничтожать нечего";
        }


        public static String ShowCarantineForSent()
        {
            String result = "";

            if (virusesInCarantine.Keys.Count > 0)
            {
                foreach (var item in virusesInCarantine)
                {
                    result += $"{item.Value}#";
                }
            }

            return result;
        }
    }
}
