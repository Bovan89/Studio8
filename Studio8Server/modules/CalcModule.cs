using System;
using System.Collections.Generic;
using System.Text;

namespace Studio8Server.modules
{
    interface ICalc
    {
        CalcResult Calc(CalcRequest request);
    }

    public class CalcModule : ICalc
    {
        public CalcResult Calc(CalcRequest request)
        {
            CalcResult result = new CalcResult();

            switch (request.Word)
            {
                case "square":
                    result.Result = Math.Pow(request.Natural, 2);
                    break;
                case "cube":
                    result.Result = Math.Pow(request.Natural, 3);
                    break;
                default:
                    throw new Exception("Недопустимый параметр");
            }

            return result;
        }
    }
}
