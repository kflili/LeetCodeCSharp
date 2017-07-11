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
    public class _242_ValidAnagramTests
    {
        [TestMethod()]
        public void IsAnagramTest()
        {
            _242_ValidAnagram testObj = new _242_ValidAnagram();
            string s1 = "anagram", t1 = "nagaram";
            string s2 = "rat", t2 = "car";

            Assert.AreEqual(true, testObj.IsAnagram(s1, t1));
            Assert.AreEqual(false, testObj.IsAnagram(s2, t2));
        }
    }
}