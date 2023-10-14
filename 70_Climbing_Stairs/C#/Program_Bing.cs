using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;

namespace LeetCode // Note: actual namespace depends on the project name.
{
    public class Solution
    {
        // 定義一個陣列來存儲已經計算過的結果
        int[] cache = new int[46];
        public int ClimbStairs(int n)
        {
            // 如果n小於等於0，返回0
            if (n <= 0) return 0;
            // 如果n等於1或2，返回n
            if (n == 1 || n == 2) return n;
            // 如果陣列中已經有n對應的結果，直接返回
            if (cache[n] != 0) return cache[n];
            // 否則，遞歸地計算n-1和n-2的結果，並將它們相加
            int result = ClimbStairs(n - 1) + ClimbStairs(n - 2);
            // 將結果存儲到陣列中
            cache[n] = result;
            // 返回結果
            return result;
        }
    }

    internal class Program
    {
        static void Main()
        {
            Solution sol = new Solution();
            Console.WriteLine(sol.ClimbStairs(44));
            //Console.WriteLine(sol.Combination(5, 3));
        }
    }

}