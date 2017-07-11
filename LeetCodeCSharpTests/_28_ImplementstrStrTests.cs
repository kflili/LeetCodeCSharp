using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCodeCSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp.Tests
{
    [TestClass()]
    public class _28_ImplementstrStrTests
    {
        [TestMethod()]
        public void StrStrTest()
        {
            _28_ImplementstrStr testObj = new _28_ImplementstrStr();
            string s = "abcddkew", t = "cdd";

            Assert.AreEqual(2, testObj.StrStr(s, t));
        }
    }
}