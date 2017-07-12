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
    public class _100_SameTreeTests
    {
        [TestMethod()]
        public void IsSameTreeTest()
        {
            TreeNode tree1 = new TreeNode(0);
            tree1.left = new TreeNode(1);
            tree1.right = new TreeNode(2);

            TreeNode tree2 = new TreeNode(0);
            tree2.left = new TreeNode(1);
            tree2.right = new TreeNode(2);

            TreeNode tree3 = new TreeNode(0);
            tree3.left = new TreeNode(2);
            tree3.right = new TreeNode(2);

            _100_SameTree testObj = new _100_SameTree();
            Assert.AreEqual(true, testObj.IsSameTree(tree1, tree2));
            Assert.AreEqual(false, testObj.IsSameTree(tree1, tree3));
        }
    }
}