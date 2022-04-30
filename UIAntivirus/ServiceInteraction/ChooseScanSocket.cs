using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace UIAntivirus.ServiceInteraction
{
    static class ChooseScanSocket
    {
        private static Socket MySocketClient;

        private const string ip = "127.0.0.1";
        private const int port = 8080;

        public static bool StartSocket()
        {
            var tcpEndPoint = new IPEndPoint(IPAddress.Parse(ip), port);
            MySocketClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            MySocketClient.Connect(tcpEndPoint);
            return MySocketClient.Connected;
        }

        public static String GetAnswer()
        {
            var buffer = new byte[256];
            var size = 0;
            var answer = new StringBuilder();

            do
            {
                size = MySocketClient.Receive(buffer);
                answer.Append(Encoding.UTF8.GetString(buffer, 0, size));
            }
            while (MySocketClient.Available > 0);

            return answer.ToString();
        }


        public static void SentMessage(String message)
        {
            var data = Encoding.UTF8.GetBytes(message);
            MySocketClient.Send(data);
        }

        public static void CloseSocket()
        {
            SentMessage("EndSocket");

            MySocketClient.Disconnect(false);
            MySocketClient.Close();
        }
    }
}
