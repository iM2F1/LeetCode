using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetString;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetString.Tests
{
    [TestClass()]
    public class _1221_Split_a_String_in_Balanced_StringsTests
    {
        [TestMethod()]
        public void BalancedStringSplitTest()
        {
            var str = "RLRRLLRLRL";
            var _1221= new _1221_Split_a_String_in_Balanced_Strings();
            var ret = _1221.BalancedStringSplit(str);
            Assert.AreEqual(ret,4);
        }
    }
}