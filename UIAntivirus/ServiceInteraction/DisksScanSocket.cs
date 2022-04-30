using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace UIAntivirus.ServiceInteraction
{
    static class DisksScanSocket
    {
        private static Socket MySocketClientForFull;

        private const string ip = "127.0.0.2";
        private const int port = 8082;

        public static bool StartSocket()
        {
            var tcpEndPoint = new IPEndPoint(IPAddress.Parse(ip), port);
            MySocketClientForFull = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            MySocketClientForFull.Connect(tcpEndPoint);
            return MySocketClientForFull.Connected;
        }

        public static String GetAnswer()
        {
            var buffer = new byte[256];
            var size = 0;
            var answer = new StringBuilder();

            do
            {
                size = MySocketClientForFull.Receive(buffer);
                answer.Append(Encoding.UTF8.GetString(buffer, 0, size));
            }
            while (MySocketClientForFull.Available > 0);

            return answer.ToString();
        }


        public static void SentMessage(String message)
        {
            var data = Encoding.UTF8.GetBytes(message);
            MySocketClientForFull.Send(data);
        }

        public static void CloseSocket()
        {
            SentMessage("EndSocket");

            MySocketClientForFull.Disconnect(false);
            MySocketClientForFull.Close();
        }
    }
}
