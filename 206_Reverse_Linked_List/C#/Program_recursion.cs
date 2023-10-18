using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;

namespace LeetCode // Note: actual namespace depends on the project name.
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
    public class Solution
    {
        public ListNode ReverseList(ListNode head)
        {
            // 一直遞迴直到找到最後的節點，以此讓 newHead 指向最後一個節點
            if(head == null || head.next == null)
            {
                return head;
            }
            ListNode newHead = ReverseList(head.next);
            // 接著將原先的 ListNode 的連接方向反轉，這樣回傳的 List 就會是反轉的 List
            head.next.next = head;
            head.next = null;
            return newHead;
        }
    }

    internal class Program
    {
        static void Main()
        {
            Solution sol = new Solution();

            // 初始化
            ListNode head = new ListNode(1);
            ListNode cur = head;
            for (int i = 2; i <= 5; ++i)
            {
                cur.next = new ListNode(i);
                cur = cur.next;
            }
            // 
            ListNode res = sol.ReverseList(head);
            // 顯示
            cur = res;
            while( cur != null )
            {
                Console.WriteLine(cur.val);
                cur = cur.next;
            }
        }
    }

}