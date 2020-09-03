using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetString;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetString.Tests
{
    [TestClass()]
    public class _1108DefangAnIpAddressTests
    {
        [TestMethod()]
        public void DefangIPaddrTest()
        {
            var IP = "1.1.1.1";
            _1108DefangAnIpAddress _1108 = new _1108DefangAnIpAddress();
            var ret = _1108.DefangIPaddr(IP);
            Assert.AreEqual(ret, "1[.]1[.]1[.]1");
        }
    }
}