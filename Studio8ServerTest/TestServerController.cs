using Grpc.Core;
using NUnit.Framework;
using Studio8Server.controllers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Studio8ServerTest
{
    class TestServerController
    {
        [Test]
        public void Construct()
        {
            string path = "path";
            int port = 1;

            ServerController c = new ServerController(path, port);
            
            Assert.IsNotNull(c);
        }

        [Test]
        public void Path()
        {
            string path = "path";
            int port = 1;

            ServerController c = new ServerController(path, port);
            
            Assert.That(c.ServerPath, Is.EqualTo(path));
        }

        [Test]
        public void Port()
        {
            string path = "path";
            int port = 1;

            ServerController c = new ServerController(path, port);

            Assert.That(c.ServerPort, Is.EqualTo(port));
        }

        [Test]
        public void StartRequestStop()
        {
            string path = "localhost";
            int port = 50051;

            ServerController sc = new ServerController(path, port);
            sc.Start();

            Channel channel = new Channel(path + ":" + port, ChannelCredentials.Insecure);
            var client = new CalcService.CalcServiceClient(channel);
            CalcRequest cr = new CalcRequest() { Natural = 3, Word = "square" };
            CalcResult result = client.Calc(cr);

            channel.ShutdownAsync().Wait();

            sc.Stop();

            Assert.That(result.Result, Is.EqualTo(9));
        }
    }
}
