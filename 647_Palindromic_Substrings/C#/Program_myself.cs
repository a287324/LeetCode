using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;

namespace LeetCode
{
    public class Solution
    {
        public int CountSubstrings(string s)
        {
            int count = 0;
            int len = s.Length;

            char[] charsInv = s.ToCharArray();
            Array.Reverse(charsInv);
            string sInv = new string(charsInv);

            count += len;   // 字元數為 1 可省略，因為每個字都一定是 Palindromic
            for (int w = 2; w <= len; w++)   // 控制字元數
            {
                for(int i = 0; i < (len - w + 1); i++) // 控制起始值
                {
                    string segmentStr = s.Substring(i, w);
                    string segmentStrInv = sInv.Substring((len - i - w), w);
                    if (segmentStr == segmentStrInv)
                    {
                        count++;
                    }
                }
            }
            return count;
        }
    }

    internal class Program
    {
        static void Main()
        {
            Solution sol = new Solution();
            string str = "abbac";
            Console.WriteLine(sol.CountSubstrings(str));
        }
    }

}