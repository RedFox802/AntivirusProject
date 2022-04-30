using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace UIAntivirus.ServiceInteraction
{
    static class ShaduleSocket
    {

        private static Socket MyShaduleSocket;

        private const string ip = "127.0.0.4";
        private const int port = 8084;

        public static bool StartSocket()
        {
            var tcpEndPoint = new IPEndPoint(IPAddress.Parse(ip), port);
            MyShaduleSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            MyShaduleSocket.Connect(tcpEndPoint);
            return MyShaduleSocket.Connected;
        }

        public static String GetAnswer()
        {
            var buffer = new byte[256];
            var size = 0;
            var answer = new StringBuilder();

            do
            {
                size = MyShaduleSocket.Receive(buffer);
                answer.Append(Encoding.UTF8.GetString(buffer, 0, size));
            }
            while (MyShaduleSocket.Available > 0);

            return answer.ToString();
        }


        public static void SentMessage(String message)
        {
            var data = Encoding.UTF8.GetBytes(message);
            MyShaduleSocket.Send(data);
        }

        public static void CloseSocket()
        {
            SentMessage("EndSocket");

            MyShaduleSocket.Disconnect(false);
            MyShaduleSocket.Close();
        }
    }
}
