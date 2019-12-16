using NUnit.Framework;
using Studio8Server.modules;
using System;

namespace Studio8ServerTest
{
    public class TestCalcModule
    {
        [Test]
        public void CalcConstruct()
        {
            CalcModule cm = new CalcModule();

            Assert.IsNotNull(cm);
        }

        [Test]
        public void CalcCube()
        {
            CalcRequest req = new CalcRequest() { Natural = 2, Word = "cube" };

            CalcModule cm = new CalcModule();
            CalcResult cr = cm.Calc(req);

            Assert.That(cr.Result, Is.EqualTo(8));
        }

        [Test]
        public void CalcSquare()
        {
            CalcRequest req = new CalcRequest() { Natural = 3, Word = "square" };

            CalcModule cm = new CalcModule();
            CalcResult cr = cm.Calc(req);

            Assert.That(cr.Result, Is.EqualTo(9));
        }

        [Test]
        public void CalcBadWordException()
        {
            string exception = "";

            try
            {
                CalcRequest req = new CalcRequest() { Natural = 1, Word = "q" };
                CalcModule cm = new CalcModule();
                CalcResult cr = cm.Calc(req);
            }
            catch (Exception e)
            {
                exception = e.Message;
            }            

            Assert.That(exception, Is.EqualTo("Недопустимый параметр"));
        }
    }
}
