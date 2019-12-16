using NUnit.Framework;
using Studio8Client.controllers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Studio8ClientTest
{
    class TestServerConnector
    {
        [Test]
        public void Construct()
        {
            ServerConnector sc = new ServerConnector();

            Assert.IsNotNull(sc);
        }

        [Test]
        public void ConstructWithPars()
        {
            string serverAddr = "1.1.1.1:80";
            ServerConnector sc = new ServerConnector(serverAddr);

            Assert.That(sc.ServerAddress, Is.EqualTo(serverAddr));            
        }                
    }
}
