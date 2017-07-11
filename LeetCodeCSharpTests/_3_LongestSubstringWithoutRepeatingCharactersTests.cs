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
    public class _3_LongestSubstringWithoutRepeatingCharactersTests
    {
        [TestMethod()]
        public void LengthOfLongestSubstringTest()
        {
            _3_LongestSubstringWithoutRepeatingCharacters testObj = new _3_LongestSubstringWithoutRepeatingCharacters();
            string[] s = { "abcabcbb", "bbbbb", "pwwkew" };
            int[] ans = { 3, 1, 3 };

            Assert.AreEqual(3, testObj.LengthOfLongestSubstring(s[0]));
            Assert.AreEqual(1, testObj.LengthOfLongestSubstring(s[1]));
            Assert.AreEqual(3, testObj.LengthOfLongestSubstring(s[2]));
            
        }
    }
}