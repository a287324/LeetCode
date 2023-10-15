// 參考資料 : https://ithelp.ithome.com.tw/articles/10218585
// 方法的概念 :
// 1. 費波那契數列

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
            double a1 = 1 / Math.Sqrt(5);
            double b2 = Math.Pow((1 + Math.Sqrt(5)) / 2, n + 1);
            double c3 = Math.Pow((1 - Math.Sqrt(5)) / 2, n + 1);
            int fx = (int)(a1 * (b2 - c3));
            return fx;
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