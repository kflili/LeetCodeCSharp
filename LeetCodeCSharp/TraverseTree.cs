using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp
{
    public class TraverseTree
    {
        // use a general template for PreOrder, InOrder, and PostOrder 
        // for non-recursive traversal. 
        // Use Additional O(n) space for visited HashSet 
        public static List<TreeNode> PreOrder(TreeNode root)
        {
            var result = new List<TreeNode>();
            var stack = new Stack<TreeNode>();
            var visited = new HashSet<TreeNode>();
            if (root == null)
            {
                return result;
            }
            stack.Push(root);
            while (stack.Count > 0)
            {
                var head = stack.Peek();
                if (!result.Contains(head))
                {
                    result.Add(head);
                }
                if (head.left != null && visited.Add(head.left))
                {
                    stack.Push(head.left);
                    continue;
                }
                if (head.right != null && visited.Add(head.right))
                {
                    stack.Push(head.right);
                    continue;
                }
                stack.Pop();
            }
            return result;
        }

        public static List<TreeNode> InOrder(TreeNode root)
        {
            var result = new List<TreeNode>();
            var stack = new Stack<TreeNode>();
            var visited = new HashSet<TreeNode>();
            if (root == null)
            {
                return result;
            }
            stack.Push(root);
            while (stack.Count > 0)
            {
                var head = stack.Peek();
                if (head.left != null && visited.Add(head.left))
                {
                    stack.Push(head.left);
                    continue;
                }
                if (!result.Contains(head))
                {
                    result.Add(head);
                }
                if (head.right != null && visited.Add(head.right))
                {
                    stack.Push(head.right);
                    continue;
                }
                stack.Pop();
            }
            return result;
        }

        public static List<TreeNode> PostOrder(TreeNode root)
        {
            var result = new List<TreeNode>();
            var stack = new Stack<TreeNode>();
            var visited = new HashSet<TreeNode>();
            if (root == null)
            {
                return result;
            }
            stack.Push(root);
            while (stack.Count > 0)
            {
                var head = stack.Peek();
                if (head.left != null && visited.Add(head.left))
                {
                    stack.Push(head.left);
                    continue;
                }
                if (head.right != null && visited.Add(head.right))
                {
                    stack.Push(head.right);
                    continue;
                }
                if (!result.Contains(head))
                {
                    result.Add(head);
                }
                stack.Pop();
            }
            return result;
        }

        public static List<List<TreeNode>> GetAllPaths(TreeNode root)
        {
            var result = new List<List<TreeNode>>();
            var stack = new Stack<TreeNode>();
            var path = new List<TreeNode>();
            var visited = new HashSet<TreeNode>();
            if (root == null)
            {
                return result;
            }
            stack.Push(root);
            while (stack.Count > 0)
            {
                TreeNode head = stack.Peek();
                if (!path.Contains(head))
                {
                    path.Add(head);
                }
                if (head.left != null && visited.Add(head.left))
                {
                    stack.Push(head.left);
                    continue;
                }
                if (head.right != null && visited.Add(head.right))
                {
                    stack.Push(head.right);
                    continue;
                }
                if (head.left == null && head.right == null)
                {
                    result.Add(new List<TreeNode>(path));
                }
                path.RemoveAt(path.Count - 1);
                stack.Pop();
            }
            return result;
        }
    }
}
