using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp
{
    public class ResultType
    {
        public ResultType(bool state, int max, int min)
        {
            IsValid = state;
            MaxValue = max;
            MinValue = min;
        }
        public bool IsValid { get; set; }
        public int MaxValue { get; set; }
        public int MinValue { get; set; }

    }
    public class _98_ValidateBinarySearchTree
    {
        public bool IsValidBST(TreeNode root)
        {
            var res = helper(root);
            return res.IsValid;
        }
        private ResultType helper(TreeNode root)
        {
            if (root == null)
            {
                return new ResultType(true, 0, 0);
            }
            ResultType res = new ResultType(true, root.val, root.val);
            if (root.left == null && root.right == null)
            {
                return res;
            }
            if (root.left != null)
            {
                var left = helper(root.left);
                if (!left.IsValid || left.MaxValue >= root.val)
                {
                    return new ResultType(false, 0, 0);
                }
                res.MinValue = left.MinValue;
            }
            if (root.right != null)
            {
                var right = helper(root.right);
                if (!right.IsValid || right.MinValue <= root.val)
                {
                    return new ResultType(false, 0, 0);
                }
                res.MaxValue = right.MaxValue;
            }
            return res;
        }
    }
}
