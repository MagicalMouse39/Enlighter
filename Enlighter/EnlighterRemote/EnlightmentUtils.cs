﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace EnlighterRemote
{
    class EnlightmentUtils
    {
        public void SendMagicPacket(string ip, string mac)
        {
            if (ip.Trim() == string.Empty)
                ip = "255.255.255.255";

            if (ip.Length == 17)
            {
                char separator = mac[2];
                mac = mac.Replace(separator.ToString(), "");
            }

            string m = string.Empty;
            for (int i = 0; i < 6; i++)
                m += mac;

            mac = "FFFFFFFFFFFF" + m;

            byte[] packet = Enumerable.Range(0, mac.Length)
                     .Where(x => x % 2 == 0)
                     .Select(x => Convert.ToByte(mac.Substring(x, 2), 16))
                     .ToArray();

            TcpClient client = new TcpClient();
        }
    }
}
