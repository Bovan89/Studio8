using NUnit.Framework;
using Studio8Server.controllers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Studio8ServerTest
{
    class TestCalcController
    {
        [Test]
        public void Construct()
        {
            CalcController c = new CalcController();

            Assert.IsNotNull(c);
        }

        [Test]
        public void CalcSquare()
        {
            CalcController c = new CalcController();
            CalcRequest cr = new CalcRequest() { Natural = 3, Word = "square"};

            CalcResult result =  c.Calc(cr, null).Result;

            Assert.That(result.Result, Is.EqualTo(9));
        }

        [Test]
        public void CalcCube()
        {
            CalcController c = new CalcController();
            CalcRequest cr = new CalcRequest() { Natural = 2, Word = "cube" };

            CalcResult result = c.Calc(cr, null).Result;

            Assert.That(result.Result, Is.EqualTo(8));
        }

        [Test]
        public void CalcBadWord()
        {
            CalcController c = new CalcController();
            CalcRequest cr = new CalcRequest() { Natural = 2, Word = "HAHAHA" };

            CalcResult result = c.Calc(cr, null).Result;

            Assert.That(result.Message, Is.EqualTo("Слово должно быть cube или square"));
        }

        [Test]
        public void CalcBadNumber()
        {
            CalcController c = new CalcController();
            CalcRequest cr = new CalcRequest() { Natural = -1, Word = "cube" };

            CalcResult result = c.Calc(cr, null).Result;

            Assert.That(result.Message, Is.EqualTo("Число должно быть в диапазоне от 1 до 100"));
        }        
    }
}
