// 概念 : 他將 sliding window 在輸入的字串上滑動，藉由不斷放大 window 的視窗大小，直到視窗超出容許值(k)，如果超出容許值(k)就把視窗縮小，並記錄視窗最大的尺寸
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;

namespace LeetCode
{
    public class Solution
    {
        public int CharacterReplacement(string s, int k)
        {
            int[] table = new int[26];
            int size = 0; // right - left + 1
            int countMax = 0;
            for (int left = 0, right = 0; right < s.Length; right++)
            {
                // 紀錄 sliding window 裡面的 letter 個數
                table[s[right] - 'A']++;
                // 更新 sliding window 裡面的 letter 出現的最大次數
                countMax = Math.Max(countMax, table[s[right] - 'A']);
                // 計算 window 的大小
                size = right - left + 1;
                // 如果視窗超過容許值(k)，縮小視窗
                if ((size - countMax) > k)
                {
                    // 更新 table ，但不用更新 countMax ，原因我不清楚，只是很多人都這樣寫，我去找原因也找不太到，因此就先這樣吧，之後有空再找原因。
                    table[s[left] - 'A']--;
                    left++;
                    size--;
                }
            }
            return size;
        }
    }

    internal class Program
    {
        static void Main()
        {
            Solution sol = new Solution();
            string s = "ABAB";
            //string s = "AABABCA";
            Console.WriteLine(sol.CharacterReplacement(s, 2));
        }
    }

}