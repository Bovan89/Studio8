using Grpc.Core;
using Studio8Server.controllers;
using System;

namespace Studio8Server
{
    class Program
    {
        const string Path = "localhost";
        const int Port = 50051;        

        static void Main(string[] args)
        {
            try
            {
                ServerController sc = new ServerController(Path, Port);
                sc.Start();                                

                Console.WriteLine($"Studio8Server запущен: {Path}:{Port}");
                Console.WriteLine("Чтобы выключить сервер нажмите любую кнопку...");
                Console.ReadKey();

                sc.Stop();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Возникла ошибка: {ex.Message}");
            }
        }
    }
}
