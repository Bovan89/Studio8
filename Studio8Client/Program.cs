using Grpc.Core;
using Studio8Client.controllers;
using Studio8Client.modules;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Studio8Client
{
    class Program
    {
        const string serverAddr = "127.0.0.1:50051";

        static void Main(string[] args)
        {   
            //Работа с консолью
            GetPutConsole gpc = new GetPutConsole();

            //Чтение из args
            using (GetArgs gp = new GetArgs(args))
            {
                CalcRequest cr = gp.GetRequestModel();

                //Валидация
                if (Validate(cr, gpc))
                {
                    //Запрос к серверу
                    SendRequest(cr, gpc);
                }                
            }

            //Продолжаем работу с консолью
            while (true)
            {
                //Получить модель (слово и номер)
                CalcRequest cr = gpc.GetRequestModel();

                //Валидация
                if (Validate(cr, gpc))
                {
                    //Запрос к серверу
                    SendRequest(cr, gpc);
                }
            }
        }

        private static bool Validate(CalcRequest cr, IPut gpc)
        {
            if (cr == null)
            {
                return false;
            }
            
            List<ValidationResult> validationResults = new List<ValidationResult>();
            if (!cr.DoValidate(validationResults))
            {
                foreach (var error in validationResults)
                {
                    gpc.Put(error.ErrorMessage);
                }

                return false;
            }

            return true;
        }

        private static bool SendRequest(CalcRequest cr, IPut gpc)
        {
            try
            {
                if (cr != null)
                {
                    CalcResult result = new ServerConnector(serverAddr).Request(cr);
                    if (result.Message != "")
                    {
                        throw new Exception(result.Message);
                    }
                    gpc.Put($"Результат {cr.Natural} и {cr.Word}: {result.Result}");

                    return true;
                }

                return false;
            }
            catch (Exception e)
            {
                gpc.Put($"Возникла ошибка: {e.Message}");

                return false;
            }
        }
    }
}
