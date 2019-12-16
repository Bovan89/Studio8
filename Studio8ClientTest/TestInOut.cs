using NUnit.Framework;
using Studio8Client.modules;
using System;

namespace Studio8ClientTest
{
    public class TestGetArgs
    {
        [Test]
        public void Construct()
        {
            GetArgs ga = new GetArgs(null);

            Assert.IsNotNull(ga);
        }

        [Test]
        public void Array()
        {
            string[] sArr = new string[2] { "4", "cube" };

            GetArgs ga = new GetArgs(sArr);
                        
            Assert.That(ga.Args[1], Is.EqualTo("cube"));
        }

        [Test]
        public void GetRequestModel()
        {
            string[] sArr = new string[2] { "4", "cube" };

            GetArgs ga = new GetArgs(sArr);
            CalcRequest cr = ga.GetRequestModel();

            Assert.That(cr.Natural, Is.EqualTo(4));
        }

        [Test]
        public void Dispose()
        {
            string[] sArr = new string[2] { "4", "cube" };

            GetArgs ga;

            using (ga = new GetArgs(sArr))
            {

            }

            Assert.IsNull(ga.Args);
        }
    }
}
