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
    public class _112_PathSum
    {
        public bool HasPathSum(TreeNode root, int sum)
        {
            if (root == null)
            {
                return false;
            }
            if (root.left == null && root.right == null)
            {
                if (sum == root.val)
                {
                    return true;
                } else
                {
                    return false;
                }
            }
            if (root.left != null && HasPathSum(root.left, sum - root.val))
            {
                return true;
            } 
            if (root.right != null && HasPathSum(root.right, sum - root.val))
            {
                return true;
            }
            return false;
        }
    }
}
