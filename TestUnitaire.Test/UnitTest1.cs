using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestUnitaire.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AdditionSimple()
        {
            var cal = new Calculatrice { Op1 = 7, Op2 = 8 };
            var resPrevu = 15;
            var res = cal.Add();
            Assert.IsTrue(resPrevu == res);
        }
        [TestMethod]
        public void AdditionNeg()
        {
            var cal = new Calculatrice { Op1 = 7, Op2 = -8 };
            var resPrevu = -1;
            var res = cal.Add();
            Assert.IsTrue(resPrevu == res);
        }
        [TestMethod]
        public void DivisonSimple()
        {
            var cal = new Calculatrice { Op1 = 14, Op2 = 2 };
            var resPrevu = 7;
            int res = 0;
            var b = cal.Div(out res);
            Assert.IsTrue(b && resPrevu == res);
        }
        [TestMethod]
        public void DivisonParZero()
        {
            var cal = new Calculatrice { Op1 = 14, Op2 = 0 };
            int res = 0;
            var b = cal.Div(out res);
            Assert.IsTrue(!b);

        }
    }
}
