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
    public class _104_MaximumDepthofBinaryTreeTests
    {
        [TestMethod()]
        public void MaxDepthTest()
        {
            TreeNode t = new TreeNode(4);
            t.left = new TreeNode(2);
            t.right = new TreeNode(5);
            t.left.left = new TreeNode(1);
            t.left.right = new TreeNode(3);

            _104_MaximumDepthofBinaryTree testObj = new _104_MaximumDepthofBinaryTree();
            Assert.AreEqual(3, testObj.MaxDepth(t));
        }
    }
}