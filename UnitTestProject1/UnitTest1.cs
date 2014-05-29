using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TipAndTestExample;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {

         TipCalculator tc = new TipCalculator(100, 20);
        [TestMethod]
        public void TestTipCalculator()
        {
           
            double tip = tc.CalculateTip();
            Assert.AreEqual(20, tip);
        }

        [TestMethod]
        public void TestTaxCalculation()
        {
            double tax = tc.CalculateTax();
            Assert.AreEqual(9.5, tax);
        }

        [TestMethod]
        public void TestTotalCalcuation()
        {
            double total = tc.CalculateTotal();
            Assert.AreEqual(129.5, total);
        }
    }
}
