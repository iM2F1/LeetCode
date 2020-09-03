using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetString;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace LeetString.Tests
{
    [TestClass()]
    public class _1436_Destination_CityTests
    {
        [TestMethod()]
        public void DestCityTest()
        {
            var _1436= new _1436_Destination_City();
            IList<IList<string>> paths=new List<IList<string>>();
            paths.Add(new List<string>() {"B", "C"});
            paths.Add(new List<string>() {"C", "D"});
            paths.Add(new List<string>() {"D", "A"});
            var ret = _1436.DestCity(paths);
            Assert.AreEqual("A",ret);
        }
    }
}