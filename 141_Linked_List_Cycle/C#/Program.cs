// 方法的概念 : Floyd判圈算法(Floyd Cycle Detection Algorithm)

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
        public ListNode(int x)
        {
            val = x;
            next = null;
        }
    }
    public class Solution
    {
        public bool HasCycle(ListNode head)
        {
            ListNode turtle = head;
            ListNode rabbit = head;

            if (head == null || head.next == null || head.next.next == null)
            {
                return false;
            }
            do
            {
                turtle = turtle.next;
                rabbit = rabbit.next.next;
                if (turtle.next == null || rabbit.next == null || rabbit.next.next == null)
                {
                    return false;
                }
            } while (turtle != rabbit);
            return true;
        }
    }

    internal class Program
    {
        static void Main()
        {
            Solution sol = new Solution();
            ListNode listNode = new ListNode(3);
            listNode.next = new ListNode(2);
            listNode.next.next = new ListNode(0);
            listNode.next.next.next = new ListNode(-4);
            listNode.next.next.next.next = listNode.next;
            if (sol.HasCycle(listNode))
            {
                Console.WriteLine("Y");
            }
            else
            {
                Console.WriteLine("N");
            }
        }
    }

}