using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;

namespace LeetCode
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }

    public class Solution
    {
        public bool IsSameTree(TreeNode p, TreeNode q)
        {
            // 如果兩個節點都為空，則返回真
            if (p == null && q == null)
            {
                return true;
            }
            // 如果其中一個節點為空，另一個不為空，則返回假
            if (p == null || q == null)
            {
                return false;
            }
            // 如果兩個節點的值不相等，則返回假
            if (p.val != q.val)
            {
                return false;
            }
            // 遞歸地比較兩個節點的左右子樹是否相同
            return IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right);
        }
    }

    internal class Program
    {
        // 深度優先走訪 - 前序走訪
        public static void PreOrderTraversal(TreeNode root)
        {
            if (root != null)
            {
                Console.Write(root.val + ",");
                PreOrderTraversal(root.left);
                PreOrderTraversal(root.right);
            }
        }
        // 深度優先走訪 - 中序走訪
        public static void InOrderTraversal(TreeNode root)
        {
            if (root != null)
            {
                InOrderTraversal(root.left);
                Console.Write(root.val + ",");
                InOrderTraversal(root.right);
            }
        }
        // 深度優先走訪 - 後序走訪
        public static void PostOrderTraversal(TreeNode root)
        {
            if (root != null)
            {
                PostOrderTraversal(root.left);
                PostOrderTraversal(root.right);
                Console.Write(root.val + ",");
            }
        }
        // 廣度優先搜尋
        public static void levelTraversal(TreeNode root)
        {
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            while (queue.Count != 0)
            {
                TreeNode curr = queue.Dequeue();
                Console.Write(curr.val + ",");
                if(curr.left != null)
                {
                    queue.Enqueue(curr.left);
                }
                if(curr.right != null)
                {
                    queue.Enqueue(curr.right);
                }
            }
        }
        static void Main()
        {
            // 建立資料
            TreeNode p = new TreeNode(4);
            p.left = new TreeNode(2);
            p.left.left = new TreeNode(1);
            p.left.right = new TreeNode(3);

            p.right = new TreeNode(7);
            p.right.left = new TreeNode(6);
            p.right.right = new TreeNode(9);

            TreeNode q = new TreeNode(4);
            q.left = new TreeNode(2);
            q.left.left = new TreeNode(1);
            q.left.right = new TreeNode(3);

            q.right = new TreeNode(7);
            q.right.left = new TreeNode(6);
            q.right.right = new TreeNode(9);
            // 
            Solution sol = new Solution();
            if(sol.IsSameTree(p, q))
            {
                Console.WriteLine("Y");
            } else
            {
                Console.WriteLine("N");
            }

        }
    }

}