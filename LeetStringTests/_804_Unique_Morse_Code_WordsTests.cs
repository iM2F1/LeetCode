using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetString;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetString.Tests
{
    [TestClass()]
    public class _804_Unique_Morse_Code_WordsTests
    {
        [TestMethod()]
        public void UniqueMorseRepresentationsTest()
        {
            string[] strList= {"gin", "zen", "gig", "msg"};
            var _804= new _804_Unique_Morse_Code_Words();
            var ret =_804.UniqueMorseRepresentations(strList);
            Assert.AreEqual(ret, 2);
        }
    }
}