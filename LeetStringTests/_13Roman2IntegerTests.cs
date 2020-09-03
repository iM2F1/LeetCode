using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetString;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetString.Tests
{
    [TestClass()]
    public class _13Roman2IntegerTests
    {
        [TestMethod()]
        public void RomanToIntTest_VI()
        {
            _13Roman2Integer R2I_instance = new _13Roman2Integer	();
            var s = "IV";
            var ret = R2I_instance.RomanToInt	(s);
            Assert.AreEqual	(ret,4);
            //Assert.Fail();
            
        }
        [TestMethod()]
        public void RomanToIntTest_III()
        {
            _13Roman2Integer R2I_instance = new _13Roman2Integer();
            var s1 = "III";
            var ret1 = R2I_instance.RomanToInt(s1);
            Assert.AreEqual(ret1, 3);
            //Assert.Fail();

        }
    }
}