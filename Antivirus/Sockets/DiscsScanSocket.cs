using Antivirus.Messages;
using AntivirusLib;
using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Antivirus.Sockets
{
    static class DiscsScanSocket
    {
        private static Socket SocketFullScan;

        private const string ip = "127.0.0.2";
        private const int port = 8082;

        public static void CreateSocketFullScan()
        {
            var tcpEndPoint = new IPEndPoint(IPAddress.Parse(ip), port);
            SocketFullScan = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            SocketFullScan.Bind(tcpEndPoint);
            SocketFullScan.Listen(100);

            while (true)
            {
                bool cont = true;
                Socket listener = SocketFullScan.Accept();

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

        public static async Task SentAsync(String operation, Socket listener)
        {
            String answer = await Task.Run(() => FullScanHandler.Processing(operation));
            if (operation != MessagesData.scanFullPause && operation != MessagesData.scanFullContinue && operation != MessagesData.scanFullStop)
            {
                SentMessage(listener, answer);
            };
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
            SocketFullScan.Close();
        }
    }
}
