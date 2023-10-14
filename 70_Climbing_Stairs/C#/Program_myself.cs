// 方法的概念 :
// 1. 利用排列組合的方式來計算

using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;

namespace LeetCode
{
    public class Solution
    {
        public int ClimbStairs(int n)
        {
            int res = 0;
            int r = 0;
            while(n >= r)
            {
                long reg = Combination(n--, r++);
                res += (int)reg;
            }
            return res;
        }

        public long Combination(long n, long r)
        {
            long res = 1;
            for(long i = 1; i <= r; ++i)
            {
                res = res * (n - r + i) / i;
            }
            return res;
        }
    }

    internal class Program
    {
        static void Main()
        {
            Solution sol = new Solution();
            Console.WriteLine(sol.ClimbStairs(44)); // 1134903170
            //Console.WriteLine(sol.Combination(5, 3));
        }
    }

}