using Antivirus.Monitoring;
using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Antivirus.Sockets
{
    static class MonitoringSocket
    {
        private static Socket MonitoringgSocket;

        private const string ip = "127.0.0.3";
        private const int port = 8083;


        public static void CreateMonitoringgSocket()
        {
            var tcpEndPoint = new IPEndPoint(IPAddress.Parse(ip), port);
            MonitoringgSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            MonitoringgSocket.Bind(tcpEndPoint);
            MonitoringgSocket.Listen(100);

            while (true)
            {
                bool cont = true;
                Socket listener = MonitoringgSocket.Accept();

                while (cont)
                {
                    if (listener.Available > 0)
                    {
                        String message = GetMessage(listener);
                        if (message == "EndSocket") cont = false;
                        else
                        {
                            MonitoringHandler.MessageHandlerForMonitoring(message, listener);
                        }
                    }
                }
            }
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

        public static void SentMessage(Socket listener, String message)
        {
            byte[] messageBuffer = Encoding.UTF8.GetBytes(message);
            if (listener.Connected)
            {
                listener.Send(messageBuffer);
            }
        }

        public static void FinishSocket()
        {
            MonitoringgSocket.Close();
        }
    }
}
