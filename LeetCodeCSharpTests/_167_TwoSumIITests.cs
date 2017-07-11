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
    public class _167_TwoSumIITests
    {       
        [TestMethod()]
        public void TwoSumTest()
        {
            // arrange  
            _167_TwoSumII testObj = new _167_TwoSumII();
            int[] nums = { 2, 7, 11, 15 };
            int target = 9;

            // act
            int[] result = testObj.TwoSum(nums, target);

            // assert
            Assert.AreEqual(1, result[0]);
            Assert.AreEqual(2, result[1]);           
        }
    }
}