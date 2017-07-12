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
    public class _141_LinkedListCycleTests
    {
        [TestMethod()]
        public void HasCycleTest()
        {
            _141_LinkedListCycle testObj = new _141_LinkedListCycle();
            var list = new ListNode(1);
            list.next = new ListNode(2);
            list.next.next = new ListNode(3);
            var cycleNode = new ListNode(4);
            list.next.next.next = cycleNode;
            list.next.next.next.next = new ListNode(5);
            list.next.next.next.next.next = new ListNode(6);
            list.next.next.next.next.next.next = cycleNode;

            Assert.AreEqual(true, testObj.HasCycle(list));
        }
    }
}