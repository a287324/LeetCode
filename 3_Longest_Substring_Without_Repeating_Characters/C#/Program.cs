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
        public int LengthOfLongestSubstring(string s)
        {
            if(s.Length == 0 || s.Length == 1)
            {
                return s.Length;
            }

            int lenMax = 0;    // sliding window 的大小
            HashSet<char> set = new HashSet<char>();
            for(int left = 0, right = 0; right < s.Length; ++right)
            {
                char c = s[right];
                // 如果有重複的字元，就一直移除字元，直到重覆字元在 HashSet 中被移除
                while(set.Contains(c))
                {
                    set.Remove(s[left]);
                    left++;
                }
                // 新增字元
                set.Add(c);
                lenMax = Math.Max(lenMax, right - left + 1);
            }
            return lenMax;
        }
    }

    internal class Program
    {
        static void Main()
        {
            Solution sol = new Solution();
            string s = "pwwkew";
            //string s = "au";
            //string s = "abcabcbb";
            Console.WriteLine(sol.LengthOfLongestSubstring(s));
        }
    }

}