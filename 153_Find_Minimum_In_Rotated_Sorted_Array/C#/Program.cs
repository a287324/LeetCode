using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;

namespace LeetCode
{
    public class Solution
    {
        public int FindMin(int[] nums)
        {
            return nums.Min();
        }
    }

    internal class Program
    {
        static void Main()
        {
            Solution sol = new Solution();
            int[] nums = { 3, 4, 5, 1, 2 };
            Console.WriteLine(sol.FindMin(nums));
        }
    }

}