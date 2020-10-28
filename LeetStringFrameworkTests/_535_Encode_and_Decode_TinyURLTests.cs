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
    public class _535_Encode_and_Decode_TinyURLTests
    {
        [TestMethod()]
        public void encodeTest()
        {

            var longURL = "https://leetcode.com/problems/design-tinyurl";
            var _535 = new _535_Encode_and_Decode_TinyURL();
            Assert.AreEqual(longURL,_535.decode(_535.encode(longURL)));
        }
    }
}