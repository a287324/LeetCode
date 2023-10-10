// 參考資料 : https://youtu.be/BLUj14tLhv8?t=7109&si=h6CkIC3_kUTpW9Hr
// 方法的概念 :
// 1. 透過 現在極值(maxNow / minNow) 來決定 subarray 的起點
// 2. 下個極值(maxNext / minNext) 協助 現在極值(maxNow / minNow) 來判斷是否更換起點值
// 3. 歷史極值(max)記錄 現在極大值(maxNow) 的歷史最大值


using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;

namespace LeetCode // Note: actual namespace depends on the project name.
{
    public class Solution
    {
        public int Search(int[] nums, int target)
        {
            return Array.IndexOf(nums, target);
        }
    }

    internal class Program
    {
        static void Main()
        {
            Solution sol = new Solution();
            int[] nums = { 4, 5, 6, 7, 0, 1, 2 };
            int target = 0;
            Console.Write(sol.Search(nums, target));
        }
    }

}