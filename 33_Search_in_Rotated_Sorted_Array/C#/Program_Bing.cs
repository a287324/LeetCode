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
            // 如果數組為空，直接返回-1
            if (nums == null || nums.Length == 0)
            {
                return -1;
            }
            // 定義左右兩個指針，分別指向數組的開始和結束
            int left = 0, right = nums.Length - 1;
            // 當左指針小於等於右指針時，進行循環
            while (left <= right)
            {
                // 計算中間位置
                int mid = left + (right - left) / 2;
                // 如果中間位置的值等於目標值，直接返回
                if (nums[mid] == target)
                {
                    return mid;
                }
                // 如果左邊是有序的
                if (nums[left] <= nums[mid])
                {
                    // 如果目標值在左邊的範圍內，則在左邊繼續搜索
                    if (target >= nums[left] && target < nums[mid])
                    {
                        right = mid - 1;
                    }
                    // 否則，在右邊繼續搜索
                    else
                    {
                        left = mid + 1;
                    }
                }
                // 如果右邊是有序的
                else
                {
                    // 如果目標值在右邊的範圍內，則在右邊繼續搜索
                    if (target > nums[mid] && target <= nums[right])
                    {
                        left = mid + 1;
                    }
                    // 否則，在左邊繼續搜索
                    else
                    {
                        right = mid - 1;
                    }
                }
            }
            // 如果沒有找到目標值，返回-1
            return -1;
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