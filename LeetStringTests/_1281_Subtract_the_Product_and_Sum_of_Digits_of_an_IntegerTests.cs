using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetString;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetString.Tests
{
    [TestClass()]
    public class _1281_Subtract_the_Product_and_Sum_of_Digits_of_an_IntegerTests
    {
        [TestMethod()]
        public void SubtractProductAndSumTest()
        {
            var num = 234;
            var _1281 = new _1281_Subtract_the_Product_and_Sum_of_Digits_of_an_Integer();
            var ret = _1281.SubtractProductAndSum(num);
            Assert.AreEqual(15, ret);
        }
    }
}