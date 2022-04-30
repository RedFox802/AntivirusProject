using System;
using UIAntivirus.ServiceInteraction;

namespace UIAntivirus.Monitoring
{
    static class MonitoringHandler
    {
        public static String SentCommand(String message)
        {
            ShaduleSocket.SentMessage(message);

            String answer = "";
            answer = ShaduleSocket.GetAnswer();
            return answer;
        }
    }
}
