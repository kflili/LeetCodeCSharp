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
    public class _8_StringtoIntegeratoiTests
    {
        [TestMethod()]
        public void MyAtoiTest()
        {
            _8_StringtoIntegeratoi testObj = new _8_StringtoIntegeratoi();

            Assert.AreEqual(123, testObj.MyAtoi("123"));
            Assert.AreEqual(0, testObj.MyAtoi("   "));
            Assert.AreEqual(1, testObj.MyAtoi("  1aaa"));
            Assert.AreEqual(0, testObj.MyAtoi("aaa"));
            Assert.AreEqual(-123, testObj.MyAtoi("   -123"));
        }
    }
}