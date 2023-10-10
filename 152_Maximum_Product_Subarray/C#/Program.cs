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
        public int MaxProduct(int[] nums)
        {
            if(nums == null ||  nums.Length == 0)
            {
                return 0;
            }

            if(nums.Length == 1)
            {
                return nums[0];
            }
            int maxNow, minNow;
            int max;
            int maxNext, minNext;
            max = maxNow = minNow = nums[0];
            for(int i = 1; i < nums.Length; i++)
            {
                maxNext = maxNow * nums[i];
                minNext = minNow * nums[i];
                maxNow = Math.Max(Math.Max(maxNext, minNext), nums[i]);
                minNow = Math.Min(Math.Min(maxNext, minNext), nums[i]);
                max = Math.Max(max, maxNow);
            }
            return max;
        }
    }

    internal class Program
    {
        static void Main()
        {
            Solution sol = new Solution();
            int[] nums = {-2, 3, -4};
            int ans = sol.MaxProduct(nums);
            Console.WriteLine(ans);
        }
    }

}