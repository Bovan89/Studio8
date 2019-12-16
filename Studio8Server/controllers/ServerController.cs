using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Studio8Server.controllers
{
    public class ServerController
    {
        public string ServerPath { get; private set; }

        public int ServerPort { get; private set; }

        Server Server;

        public ServerController(string serverPath, int serverPort)
        {
            ServerPath = serverPath;
            ServerPort = serverPort;
        }

        public bool Start()
        {
            try
            {
                if (Server != null)
                {
                    return false;
                }

                Server = new Server
                {
                    Services = { CalcService.BindService(new CalcController()) },
                    Ports = { new ServerPort(ServerPath, ServerPort, ServerCredentials.Insecure) }
                };

                Server.Start();
            }
            catch
            {
                if (Server != null)
                {
                    Server.ShutdownAsync().Wait();
                }

                return false;
            }

            return true;
        }

        public bool Stop()
        {
            try
            {
                if (Server != null)
                {
                    Server.ShutdownAsync().Wait();
                }
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }
    }
}
