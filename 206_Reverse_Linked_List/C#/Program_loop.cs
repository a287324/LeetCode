// 參考資料 : https://youtu.be/BLUj14tLhv8?t=7109&si=h6CkIC3_kUTpW9Hr
// 方法的概念 :
// 1. 透過 現在極值(maxNow / minNow) 來決定 subarray 的起點
// 2. 下個極值(maxNext / minNext) 協助 現在極值(maxNow / minNow) 來判斷是否更換起點值
// 3. 歷史極值(max)記錄 現在極大值(maxNow) 的歷史最大值


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