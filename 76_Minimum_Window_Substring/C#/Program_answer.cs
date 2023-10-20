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
        public string MinWindow(string s, string t)
        {
            int[] count = new int[128];
            int required = t.Length;
            int bestLeft = -1;
            int minLength = s.Length + 1;

            foreach (char c in t)
                count[c]++;

            for (int l = 0, r = 0; r < s.Length; ++r)
            {
                if (--count[s[r]] >= 0)
                    required--;
                while (required == 0)
                {
                    if (r - l + 1 < minLength)
                    {
                        bestLeft = l;
                        minLength = r - l + 1;
                    }
                    if (++count[s[l++]] > 0)
                        required++;
                }
            }

            return bestLeft == -1 ? "" : s.Substring(bestLeft, minLength);
        }
    }

    internal class Program
    {
        static void Main()
        {
            Solution sol = new Solution();
            string s = "ADOBECODEBANC", t = "ABC";
            Console.WriteLine(sol.MinWindow(s, t));
        }
    }

}