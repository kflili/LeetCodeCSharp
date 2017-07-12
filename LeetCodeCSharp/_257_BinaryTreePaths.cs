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
    public class _257_BinaryTreePaths
    {
        public IList<string> BinaryTreePaths(TreeNode root)
        {
            IList<string> paths = new List<string>();
            if (root == null)
            {
                return paths;
            }
            if (root.left == null && root.right == null)
            {               
                paths.Add(root.val.ToString());
                return paths;
            }
            if (root.left != null)
            {
                foreach(string path in BinaryTreePaths(root.left))
                {
                    //generally we can use StringBuilder

                    //StringBuilder sb = new StringBuilder();
                    //sb.Append(root.val.ToString());
                    //sb.Append("->");
                    //sb.Append(path);
                    //paths.Add(sb.ToString());
                    string nPath = path.Insert(0, root.val.ToString() + "->");
                    paths.Add(nPath);
                }
            }
            if (root.right != null)
            {
                foreach(string path in BinaryTreePaths(root.right))
                {
                    string nPath = path.Insert(0, root.val.ToString() + "->");
                    paths.Add(nPath);
                }
            }
            return paths;
        }
    }
}
