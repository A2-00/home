using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrimeCheckerLib;

namespace PrimeCheckerTests
{
    [TestClass]
    public class PrimeCheckerTests
    {
        [TestMethod]
        public void IsPrime_NumberLessThan2_ReturnsFalse()
        {
            Assert.IsFalse(PrimeChecker.IsPrime(0));
            Assert.IsFalse(PrimeChecker.IsPrime(1));
            Assert.IsFalse(PrimeChecker.IsPrime(-5));
            Assert.IsFalse(PrimeChecker.IsPrime(-100));
        }

        [TestMethod]
        public void IsPrime_SmallPrimes_ReturnsTrue()
        {
            Assert.IsTrue(PrimeChecker.IsPrime(2));
            Assert.IsTrue(PrimeChecker.IsPrime(3));
            Assert.IsTrue(PrimeChecker.IsPrime(5));
            Assert.IsTrue(PrimeChecker.IsPrime(7));
            Assert.IsTrue(PrimeChecker.IsPrime(11));
            Assert.IsTrue(PrimeChecker.IsPrime(13));
        }

        [TestMethod]
        public void IsPrime_SmallComposites_ReturnsFalse()
        {
            Assert.IsFalse(PrimeChecker.IsPrime(4));
            Assert.IsFalse(PrimeChecker.IsPrime(6));
            Assert.IsFalse(PrimeChecker.IsPrime(8));
            Assert.IsFalse(PrimeChecker.IsPrime(9));
            Assert.IsFalse(PrimeChecker.IsPrime(10));
            Assert.IsFalse(PrimeChecker.IsPrime(12));
        }

        [TestMethod]
        public void IsPrime_LargePrime_ReturnsTrue()
        {
            Assert.IsTrue(PrimeChecker.IsPrime(7919)); // известное простое
            Assert.IsTrue(PrimeChecker.IsPrime(104729));
        }

        [TestMethod]
        public void IsPrime_LargeComposite_ReturnsFalse()
        {
            Assert.IsFalse(PrimeChecker.IsPrime(1000000));
            Assert.IsFalse(PrimeChecker.IsPrime(999999));
        }
    }
}