using NUnit.Framework;
using Studio8Client.modules;
using System;
using System.Collections.Generic;
using System.Text;

namespace Studio8ClientTest
{
    class TestGetPutConsole
    {
        [Test]
        public void Construct()
        {
            GetPutConsole g = new GetPutConsole();

            Assert.IsNotNull(g);
        }

        [Test]
        public void Put()
        {
            GetPutConsole g = new GetPutConsole();

            g.Put("123");                        
        }
    }
}
