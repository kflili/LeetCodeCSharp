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
    public class _26_RemoveDuplicatesfromSortedArrayTests
    {
        [TestMethod()]
        public void RemoveDuplicatesTest()
        {
            _26_RemoveDuplicatesfromSortedArray testObj = new _26_RemoveDuplicatesfromSortedArray();
            int[] nums = { 1, 1, 2 };

            int length = testObj.RemoveDuplicates(nums);

            Assert.AreEqual(2, length);
        }
    }
}