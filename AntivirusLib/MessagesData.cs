namespace AntivirusLib
{
    public static class MessagesData
    {
        public const string scanFile = "fileScan";
        public const string scanPath = "pathScan";

        public const string scanFull = "fullScan";
        public const string fullComp = "allDisks";
        public const string fullOwn = "ownDisks";
        public const string fullRem = "remvableDiscs";


        public const string scanPause = "ScanPause";
        public const string scanContinue = "ScanContinue";
        public const string scanStop = "ScanStop";

        public const string scanFullPause = "ScanFullPause";
        public const string scanFullContinue = "ScanFullContinue";
        public const string scanFullStop = "ScanFullStop";

        public const string delete = "deleteVirus";
        public const string deleteAll = "deleteViruses";
        public const string carantine = "carantineViruses";

        public const string monitoringAdd = "addDirectory";
        public const string monitoringDelete = "deleteDirectory";

        public const string resultNone = "Вирусы не найдены";
        public const string resultStop = "Сканирование остановлено";
        public const string resultNoDiscs = "Данные диски не найдены!";
        public const string resultDelete = "Угроза уничтожена";
        public const string resultCarantine = "Угрозы перемещены в карантин";

        public const string carantineShow = "showCarantine";
        public const string carantineRecoverAll = "returnAllFromCarantine";
        public const string carantineDeleteAll = "deleteAllFromCarantine";
        public const string carantineRecoverOne = "returnOneFromCarantine";
        public const string carantineDeleteOne = "deleteOneFromCarantine";

        public const string filterExe = "exe files (*.exe)|*.exe|All files (*.*)|*.*";
        public const string signatureFile = @"C:/Users/xiaomi/Desktop/four/Antivirus/Antivirus/DB/Sign.txt";

        public const string serviceName = "AntivirusProject";
        public const string watchdogName = "WatchDogProject";
    }
}
