using AntivirusLib;
using System;
using UIAntivirus.ServiceInteraction;

namespace UIAntivirus.MessageProcessing
{
    static class CommandsHandler
    {
        public static String GetCommand(String command, String path = "")
        {
            String CommandResult = "";
            String[] CommandArray = command.Split('#');


            switch (CommandArray[0])
            {
                case MessagesData.scanFile:
                    CommandResult = SentCommand(MessagesData.scanFile + "#" + path);
                    break;
                case MessagesData.scanPath:
                    CommandResult=SentCommand(MessagesData.scanPath + "#" + path);
                    break;

                case MessagesData.scanFull:
                    CommandResult = SentCommandFull(MessagesData.scanFull + "#" + CommandArray[1]);
                    break;

                case MessagesData.delete:
                    CommandResult = SentCommand(MessagesData.delete+"#"+path);
                    break;
                case MessagesData.deleteAll:
                    CommandResult = SentCommand(MessagesData.deleteAll);
                    break;
                case MessagesData.scanPause:
                    CommandResult = SentCommand(MessagesData.scanPause);
                    break;
                case MessagesData.scanContinue:
                    CommandResult = SentCommand(MessagesData.scanContinue);
                    break;
                case MessagesData.scanStop:
                    CommandResult = SentCommand(MessagesData.scanStop);
                    break;

                case MessagesData.scanFullPause:
                    CommandResult = SentCommandFull(MessagesData.scanFullPause);
                    break;
                case MessagesData.scanFullContinue:
                    CommandResult = SentCommandFull(MessagesData.scanFullContinue);
                    break;
                case MessagesData.scanFullStop:
                    CommandResult = SentCommandFull(MessagesData.scanFullStop);
                    break;

                case MessagesData.carantine:
                    CommandResult = SentCommand(MessagesData.carantine);
                    break;
                case MessagesData.carantineShow:
                    CommandResult = SentCommand(MessagesData.carantineShow);
                    break;
                case MessagesData.carantineRecoverAll:
                    CommandResult = SentCommand(MessagesData.carantineRecoverAll);
                    break;
                case MessagesData.carantineDeleteAll:
                    CommandResult = SentCommand(MessagesData.carantineDeleteAll);
                    break;
                case MessagesData.carantineDeleteOne:
                    CommandResult = SentCommand(MessagesData.carantineDeleteOne + "#" + path);
                    break;
                case MessagesData.carantineRecoverOne:
                    CommandResult = SentCommand(MessagesData.carantineRecoverOne + "#" + path);
                    break;

            }

            return CommandResult;
        }


        private static String SentCommand(String message)
        {
            ChooseScanSocket.SentMessage(message);

            String answer = "";
            if (message != MessagesData.scanPause && message != MessagesData.scanContinue && message != MessagesData.scanStop) answer = ChooseScanSocket.GetAnswer();
            return answer;
        }

        private static String SentCommandFull(String message)
        {
            DisksScanSocket.SentMessage(message);

            String answer = "";
            if ( message != MessagesData.scanFullPause && message != MessagesData.scanFullContinue && message != MessagesData.scanFullStop) answer = DisksScanSocket.GetAnswer();
            return answer;
        }
    }
}
