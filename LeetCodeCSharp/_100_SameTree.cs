using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
namespace LeetCodeCSharp
{
    public class _100_SameTree
    {
        public bool IsSameTree(TreeNode p, TreeNode q)
        {
            if (p == null)
            {
                return q == null;
            }
            if (q == null)
            {
                return false;
            }

            if (p.val == q.val && IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right))
            {
                return true;
            }
            return false;
        }
    }
}
