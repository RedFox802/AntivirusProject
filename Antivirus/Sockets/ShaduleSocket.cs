using Antivirus.Shadule;
using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Antivirus.Sockets
{
    static class SheduleSocket
    {
        private static Socket ShaduleSocket;

        private const string ip = "127.0.0.4";
        private const int port = 8084;

        public static void CreateShaduleSocket()
        {
            var tcpEndPoint = new IPEndPoint(IPAddress.Parse(ip), port);
            ShaduleSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            ShaduleSocket.Bind(tcpEndPoint);
            ShaduleSocket.Listen(100);

            while (true)
            {
                bool cont = true;
                Socket listener = ShaduleSocket.Accept();

                while (cont)
                {
                    if (listener.Available > 0)
                    {
                        String message = GetMessage(listener);
                        if (message == "EndSocket") cont = false;
                        else
                        {
                            SentAsync(message, listener);
                        }
                    }
                }
            }
        }

        private static async Task SentAsync(String operation, Socket listener)
        {
            await Task.Run(() => ShaduleHandler.MessageHandlerForShadule(operation));
            String answer = await Task.Run(() => ShaduleHandler.StartTask());
            SentMessage(listener, answer);
        }


        private static string GetMessage(Socket listener)
        {
            var buffer = new byte[256];
            var size = 0;
            var data = new StringBuilder();

            if (listener.Connected)
            {
                size = listener.Receive(buffer);
                data.Append(Encoding.UTF8.GetString(buffer, 0, size));
                return data.ToString();
            }
            else return "";
        }

        private static void SentMessage(Socket listener, String message)
        {
            byte[] messageBuffer = Encoding.UTF8.GetBytes(message);
            if (listener.Connected)
            {
                listener.Send(messageBuffer);
            }
        }

        public static void FinishSocket()
        {
            ShaduleSocket.Close();
        }
    }
}
