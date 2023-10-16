using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;

namespace LeetCode
{
    public class Solution
    {
        public int MaxArea(int[] height)
        {
            int left = 0;
            int right = height.Length - 1;
            int areaNow, areaMax = 0;
            while (left < right)
            {
                areaNow = Math.Min(height[left], height[right]) * (right - left);
                areaMax = Math.Max(areaNow, areaMax);
                if (height[left] < height[right])
                {
                    left++;
                } 
                else
                {
                    right--;
                }
            }
            return areaMax;
        }
    }

    internal class Program
    {
        static void Main()
        {
            Solution sol = new Solution();
            int[] height = { 1, 8, 6, 2, 5, 4, 8, 3, 7 };
            Console.WriteLine(sol.MaxArea(height));
        }
    }

}