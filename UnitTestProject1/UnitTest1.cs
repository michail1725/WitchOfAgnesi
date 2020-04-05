using WitchOfAgnesi;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CalculationsTest1()
        {
            FuncCalc funcCalc = new FuncCalc();
            double leftB = -3, rightB = 3, step = 1;
            funcCalc.aNum = 2;
            double[] expresult = { 0.61538, 1, 1.6, 2, 1.6, 1, 0.61538 };
            int p = 0;
            for (double i = leftB; i <= rightB; i += step) {
                Assert.AreEqual(expresult[p], Math.Round(funcCalc.Calculate(i), 5));
                p += 1;
            }
        }
        [TestMethod]
        public void CalculationsTest2()
        {
            FuncCalc funcCalc = new FuncCalc();
            double leftB = -10, rightB = 10, step = 5;
            funcCalc.aNum = 5;
            double[] expresult = { 1, 2.5, 5, 2.5, 1 };
            int p = 0;
            for (double i = leftB; i <= rightB; i += step)
            {
                Assert.AreEqual(expresult[p], Math.Round(funcCalc.Calculate(i), 5));
                p += 1;
            }
        }
        [TestMethod]
        public void CalculationsTest3()
        {
            FuncCalc funcCalc = new FuncCalc();
            double leftB = -1, rightB = 1, step = 0.5;
            funcCalc.aNum = 2;
            double[] expresult = { 1.6, 1.88235, 2, 1.88235, 1.6 };
            int p = 0;
            for (double i = leftB; i <= rightB; i += step)
            {
                Assert.AreEqual(expresult[p], Math.Round(funcCalc.Calculate(i), 5));
                p += 1;
            }
        }
    }
}
