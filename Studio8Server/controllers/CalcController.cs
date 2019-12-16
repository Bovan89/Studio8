using Grpc.Core;
using Studio8Server.modules;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Threading.Tasks;

namespace Studio8Server.controllers
{
    public class CalcController : CalcService.CalcServiceBase
    {
        // Server side handler of the CalcService RPC
        public override Task<CalcResult> Calc(CalcRequest request, ServerCallContext context)
        {
            try
            {
                //Validation
                var results = new List<ValidationResult>();
                if (!request.DoValidate(results))
                {
                    throw new Exception(String.Join(';', results));
                }                

                //Calc
                ICalc calc = new CalcModule();
                return Task.FromResult(calc.Calc(request));
            }
            catch (Exception e)
            {
                return Task.FromResult(new CalcResult() { Message = e.Message });
            }
        }
    }
}
