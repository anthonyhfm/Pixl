using System;
using System.Collections.Generic;
using System.Text;
using SimpleTCP;

namespace Pixl.Systems.Networking
{
    public class Client
    {

        private SimpleTcpClient client = new SimpleTcpClient();

        public bool Connect(string address, int port)
        {
            try
            {
                client.Connect(address, port);
                client.DataReceived += MessageEvent;
                return true;
            }
            catch
            {
                Console.WriteLine("Failed to Connect to " + address);
                return false;
            }
        }

        public void Send(byte[] message)
        {
            client.Write(message);
        }

        EventHandler<Message> MessageEvent;

        


    }
}
