using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace EnlighterReceiver
{
    class Program
    {
        static void Main(string[] args)
        {
            TcpListener server = new TcpListener(new IPEndPoint(Dns.GetHostEntry(Dns.GetHostName()).AddressList[0], 39390));
            server.Start();

            while (true)
            {
                TcpClient client = server.AcceptTcpClient();
                byte[] buffer = new byte[1024];
                client.GetStream().Read(buffer, 0, buffer.Length);
                client.Close();
                server.Stop();

                string msg = Encoding.UTF8.GetString(buffer);

                if (msg == "shutdown")
                    new Process() { StartInfo = new ProcessStartInfo() { FileName = "shutdown.exe", Arguments = "-s -f -t 0" } }.Start();
            }
        }
    }
}
