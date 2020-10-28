using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetStringFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetStringFramework.Tests
{
    [TestClass()]
    public class _1480_Running_Sum_of_1d_ArrayTests
    {
        [TestMethod()]
        public void RunningSumTest()
        {
            var _1480= new _1480_Running_Sum_of_1d_Array();
            var nums = new int[] { 1, 2, 3, 4 };
            var expect = new int[] {1, 3, 6, 10};
            var ret = _1480.RunningSum(nums);
            CollectionAssert.AreEqual(expect,ret);
        }
    }
}