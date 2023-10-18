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

            for (int i = 0; i < s.Length; i++)
            {
                CountPalindroms(s, i, i, ref count);
                CountPalindroms(s, i, i + 1, ref count);
            }

            return count;
        }

        private void CountPalindroms(string s, int leftIndex, int rightIndex, ref int count)
        {
            while (leftIndex >= 0 && rightIndex < s.Length && s[leftIndex] == s[rightIndex])
            {
                leftIndex--;
                rightIndex++;
                count++;
            }
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