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
            ListNode pre = null;
            ListNode cur = head;
            ListNode next;
            while (cur != null)
            {
                // 保存下個 Node 位置
                next = cur.next;
                // 讓 List 指向反向
                cur.next = pre;
                // 循著 List 下去做
                pre = cur;
                cur = next;
            }
            return pre;
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