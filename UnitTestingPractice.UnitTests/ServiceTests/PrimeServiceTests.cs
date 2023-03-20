using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using UnitTestingPractice.Services;

namespace UnitTestingPractice.UnitTests.PrimeServiceTests
{
    [TestFixture]
    public class PrimeServiceTests
    {
        private PrimeServices _primeService;
        [SetUp]
        public void SetUp()
        {
            _primeService = new PrimeServices();
        }

        [Test]
        public void IsPrime_InputIs1_ReturnsFalse()
        {
            Assert.IsFalse(_primeService.IsPrime(1), "1 should not be prime");
        }

        [Test]
        public void IsPrime_InputIs2_ReturnTrue()
        {
            Assert.IsTrue(_primeService.IsPrime(2), "2 Should be prime");
        }

        [Test]
        public void IsPrime_InputsIsPrime_ReturnsTrue()
        {
            Assert.IsTrue(_primeService.IsPrime(13), "Number should be prime");
        }

        [Test]
        public void IsPrime_InputIsNonPrime_ReturnsFalse()
        {
            Assert.IsFalse(_primeService.IsPrime(14), "Number should be non prime");
        }

        [Test]
        public void IsPrime_InputIsNegetive_ReturnsFalse()
        {
            Assert.IsFalse(_primeService.IsPrime(-5), "Negetive number should be non prime");
        }
    }
}
