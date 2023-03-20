using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using UnitTestingPractice.Services;

namespace UnitTestingPractice.UnitTests.ServicesTests
{
    class TipCalculatorServiceTests
    {
        private TipCalculationService _tcs;
        [SetUp]
        public void SetUp ()
        {
            _tcs = new TipCalculationService();
        }

        [Test]
        public void GetTip_InputIs30_Returns5()
        {
            double tip = _tcs.GetTip(30);
            Assert.AreEqual(5.0, tip);
        }

        [Test]
        public void GetTip_InputIs70_Returns7()
        {
            double tip = _tcs.GetTip(70);
            Assert.AreEqual(7.0, tip);
        }
        [Test]
        public void GetTip_InputIsNegative10_Returns0()
        {
            double tip = _tcs.GetTip(-10);
            Assert.AreEqual(0.0, tip);
        }
    }
}
