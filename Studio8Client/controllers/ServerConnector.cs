using Grpc.Core;
using Studio8Client.modules;
using System;
using System.Collections.Generic;
using System.Text;

namespace Studio8Client.controllers
{
    public class ServerConnector
    {
        public string ServerAddress { get; set; }

        public ServerConnector()
        {
        }

        public ServerConnector(string serverAddr)
        {
            ServerAddress = serverAddr;
        }

        public CalcResult Request(CalcRequest request)
        {
            Channel channel = new Channel(ServerAddress, ChannelCredentials.Insecure);

            var client = new CalcService.CalcServiceClient(channel);

            CalcResult result = client.Calc(request);

            channel.ShutdownAsync().Wait();

            return result;            
        }        
    }
}
