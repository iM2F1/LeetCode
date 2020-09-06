using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetString;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetString.Tests
{
    [TestClass()]
    public class _1512_Number_of_Good_PairsTests
    {
        [TestMethod()]
        public void NumIdenticalPairsTest()
        {
            var nums = new int[6] {1, 2, 3, 1, 1, 3};
            _1512_Number_of_Good_Pairs _1512= new _1512_Number_of_Good_Pairs();
            var ret = _1512.NumIdenticalPairs(nums);
            Assert.AreEqual(4,ret);
            
        }
    }
}