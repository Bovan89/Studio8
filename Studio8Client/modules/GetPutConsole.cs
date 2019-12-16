using System;
using System.Collections.Generic;
using System.Text;

namespace Studio8Client.modules
{
    //Класс чтения/записи в консоль
    public class GetPutConsole : IGet, IPut
    {
        public CalcRequest GetRequestModel()
        {
            CalcRequest calcRequestModel;

            try
            {
                calcRequestModel = new CalcRequest();

                Console.WriteLine("Введите 1-й параметр - натуральное число (n), допустимые значения от 1 до 100");
                calcRequestModel.Natural = int.Parse(Console.ReadLine());

                Console.WriteLine("Введите 2-й параметр - слово, допустимые значения \"square\" или \"cube\"");
                calcRequestModel.Word = Console.ReadLine();
            }
            catch (Exception)
            {
                return null;
            }

            return calcRequestModel;
        }

        public bool Put(string message)
        {
            try
            {
                Console.WriteLine(message);
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }
    }
}
