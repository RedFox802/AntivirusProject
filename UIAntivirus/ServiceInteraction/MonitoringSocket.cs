using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace UIAntivirus.ServiceInteraction
{
    static class MonitoringSocket
    {
        private static Socket MonitoringgSocket;

        private const string ip = "127.0.0.3";
        private const int port = 8083;

        public static bool StartSocket()
        {
            var tcpEndPoint = new IPEndPoint(IPAddress.Parse(ip), port);
            MonitoringgSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            MonitoringgSocket.Connect(tcpEndPoint);
            return MonitoringgSocket.Connected;
        }

        public static String GetAnswer()
        {
            var buffer = new byte[256];
            var size = 0;
            var answer = new StringBuilder();

            do
            {
                size = MonitoringgSocket.Receive(buffer);
                answer.Append(Encoding.UTF8.GetString(buffer, 0, size));
            }
            while (MonitoringgSocket.Available > 0);

            return answer.ToString();
        }

        public static void SentMessage(String message)
        {
            var data = Encoding.UTF8.GetBytes(message);
            MonitoringgSocket.Send(data);
        }

        public static void CloseSocket()
        {
            SentMessage("EndSocket");

            MonitoringgSocket.Disconnect(false);
            MonitoringgSocket.Close();
        }
    }
}
