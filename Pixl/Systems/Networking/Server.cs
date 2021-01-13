using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using SimpleTCP;

namespace Pixl.Systems.Networking
{
    public class Server
    {

        private SimpleTcpServer server = new SimpleTcpServer();

        public void Start(int port)
        {
            server.Start(port);
        }

        public string[] GetAddresses()
        {
            try
            {
                IPAddress[] addresses = server.GetListeningIPs().ToArray();

                List<string> converted = new List<string>();

                foreach(IPAddress e in addresses)
                {
                    converted.Add(e.MapToIPv4().ToString());
                }

                return converted.ToArray();
            }
            catch
            {
                return new string[] { "127.0.0.1" };
            }
        }

        public void Send(byte[] e)
        {
            server.Broadcast(e);
        }

    }
}
