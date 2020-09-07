using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetString;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetString.Tests
{
    [TestClass()]
    public class _1309_Decrypt_String_from_Alphabet_to_Integer_MappingTests
    {
        [TestMethod()]
        public void FreqAlphabetsTest()
        {
            var str = "12345678910#11#12#13#14#15#16#17#18#19#20#21#22#23#24#25#26#1";
            var _1309= new _1309_Decrypt_String_from_Alphabet_to_Integer_Mapping();
            var ret = _1309.FreqAlphabets(str);
            Assert.AreEqual("abcdefghijklmnopqrstuvwxyza",ret);
        }
    }
}