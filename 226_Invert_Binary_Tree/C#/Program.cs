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
        public TreeNode InvertTree(TreeNode root)
        {
            // 如果根節點為空，直接返回
            if (root == null)
            {
                return root;
            }
            // 將根節點的左右子節點互換
            TreeNode temp = root.left;
            root.left = root.right;
            root.right = temp;
            // 遞歸地反轉左右子樹
            InvertTree(root.left);
            InvertTree(root.right);
            // 返回根節點
            return root;
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
            TreeNode root = new TreeNode(4);
            root.left = new TreeNode(2);
            root.left.left = new TreeNode(1);
            root.left.right = new TreeNode(3);

            root.right = new TreeNode(7);
            root.right.left = new TreeNode(6);
            root.right.right = new TreeNode(9);

            // 
            Solution sol = new Solution();
            TreeNode res = sol.InvertTree(root);

            // 顯示結果
            levelTraversal(root);

        }
    }

}