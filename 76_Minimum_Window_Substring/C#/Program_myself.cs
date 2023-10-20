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
        public string MinWindow(string s, string t)
        {
            // 建立 t 的表格
            Dictionary<char, int> dict = new Dictionary<char, int>();
            for (int i = 0; i < t.Length; i++)
            {
                if(!dict.ContainsKey(t[i]))
                {
                    dict.Add(t[i], 1);
                }
                else
                {
                    dict[t[i]]++;
                }
            }

            // 尋找符合條件的 substring
            string matchStr = "";
            int matchLen = Int32.MaxValue;
            int matchCount = 0;
            for (int left = 0, right = 0; right < s.Length; right++)
            {
                // 確認此字母有在 t 裡面
                if (dict.ContainsKey(s[right]))
                {
                    // 更新 table
                    dict[s[right]]--;
                    // 更新匹配次數
                    if (dict[s[right]] == 0)
                    {
                        matchCount++;
                    }
                    // 確認目前的 sliding window 都包含 t 的字母
                    if(matchCount == dict.Count)
                    {
                        // 將 left 指針移動到有包含 t 的字母，並且跳過可移除的字母
                        while(true)
                        {
                            if (!dict.ContainsKey(s[left]))
                            {
                                left++;
                            } else if (dict[s[left]] < 0)
                            {
                                dict[s[left]]++;
                                left++;
                            } else
                            {
                                break;
                            }
                        }
                        // 紀錄資料(如果找到長度更短的字串)
                        if(matchLen > (right-left+1))
                        {
                            // 紀錄資料
                            matchLen = right - left + 1;
                            matchStr = s.Substring(left, matchLen);
                            // 讓左指針離開含有 t 字母的位置
                            dict[s[left]]++;
                            left++;
                            matchCount--;
                        }
                    }
                }
            }
            return matchStr;
        }
    }

    internal class Program
    {
        static void Main()
        {
            Solution sol = new Solution();
            //string s = "ADOBECODEBANC", t = "ABC";
            string s = "AOOBOAOOCA", t = "ABC";
            Console.WriteLine(sol.MinWindow(s, t));
        }
    }

}