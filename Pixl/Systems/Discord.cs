using DiscordRPC;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pixl.Systems
{
    public class Discord
    {

        public DiscordRpcClient client;

		public class DiscordDetails
        {
			public string ClientID { get; set; }

			public string Details { get; set; }

			public string State { get; set; }

			public Assets Assets { get; set; }
        }

        public void Initialize(DiscordDetails details)
        {
			client = new DiscordRpcClient(details.ClientID);

			//Connect to the RPC
			client.Initialize();

			//Set the rich presence
			//Call this as many times as you want and anywhere in your code.
			client.SetPresence(new RichPresence()
			{
				Details = details.Details,
				State = details.State,
				Assets = details.Assets
			});
		}

		public void Update()
        {
			client.Invoke();
        }

    }
}
