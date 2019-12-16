using System;
using System.Collections.Generic;
using System.Text;

namespace Studio8Client.modules
{
    //Класс чтения из массива args - переданного при запуске приложения
    public class GetArgs : IGet, IDisposable
    {
        public string[] Args;

        public GetArgs(string[] args)
        {
            if (args != null &&
                args.Length > 0)
            {
                Args = new string[args.Length];
                args.CopyTo(Args, 0);
            }
        }

        public CalcRequest GetRequestModel()
        {
            try
            {
                if (Args != null &&
                    Args.Length > 1)
                {
                    CalcRequest calcRequestModel = new CalcRequest
                    {
                        Natural = int.Parse(Args[0]),
                        Word = Args[1]
                    };

                    return calcRequestModel;
                }
                else
                {
                    return null;
                }
            }
            catch
            {
                return null;
            }
        }

        public void Dispose()
        {
            Args = null;
        }
    }
}
