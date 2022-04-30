using System;
using UIAntivirus.ServiceInteraction;

namespace UIAntivirus.Shadule
{
    public static class ShaduleHandler
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
