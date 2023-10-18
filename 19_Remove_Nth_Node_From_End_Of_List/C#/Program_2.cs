using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;

namespace LeetCode
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
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            // 在 head 前面多加一個空節點(多空節點的目的是如果要刪除的是 head 目前節點，會需要特別處理)
            ListNode newHead = new ListNode();
            newHead.next = head;

            // 根據 n 移動右邊界，讓左邊界與右邊的間距剛好是 n
            ListNode left = newHead;
            ListNode right = head;
            for(int i = 0; i < n; i++)
            {
                right = right.next;
            }
            // 保持左右邊界的距離下，移動右邊界，這樣要刪除的節點剛好是左邊界的下個節點
            while(right != null)
            {
                right = right.next;
                left = left.next;
            }
            left.next = left.next.next;
            return newHead.next;
        }
    }

    internal class Program
    {
        static void Main()
        {
            Solution sol = new Solution();
            // 初始化 (1,2,3,4,5)
            //ListNode list = new ListNode(1);
            //ListNode head = list;
            //for (int i = 2; i <= 5; i++)
            //{
            //    head.next = new ListNode(i);
            //    head = head.next;
            //}

            // 初始化 (1)
            //ListNode list = new ListNode(1);
            //ListNode head = list;

            // 初始化 (1,2)
            ListNode list = new ListNode(1);
            list.next = new ListNode(2);
            ListNode head;
            // 
            head = sol.RemoveNthFromEnd(list, 2);
            while(head != null )
            {
                Console.WriteLine(head.val);
                head = head.next;
            }
        }
    }

}