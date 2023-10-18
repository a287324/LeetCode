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
            int listLen = 0;
            // 首先尋訪到底一次，確認 List 的總長
            ListNode reg = head;
            while (reg != null)
            {
                reg = reg.next;
                listLen++;
            }
            // 刪除 head 開頭指向的節點
            if(listLen == n)
            {
                head = head.next;
                return head;
            }
            // 先到要刪除的指定節點的前一個節點
            reg = head;
            for(int i = 0; i < (listLen - n - 1); i++)
            {
                reg = reg.next;
            }
            reg.next = reg.next.next;
            return head;
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