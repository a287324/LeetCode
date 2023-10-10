// See https://aka.ms/new-console-template for more information


using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;

namespace LeetCode // Note: actual namespace depends on the project name.
{
    public class Solution
    {
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            if(strs == null || strs.Length == 0)
            {
                return new List<IList<string>>();
            }
            Dictionary<string, IList<string>> dic = new Dictionary<string, IList<string>>();
            foreach(string s in strs)
            {
                char[] chars = s.ToCharArray();
                Array.Sort(chars);
                string sorted = new string(chars);
                if (!dic.ContainsKey(sorted))
                {
                    dic.Add(sorted, new List<string>());
                }
                dic[sorted].Add(s);
            }
            return dic.Values.ToList();
        }
    }

    internal class Program
    {
        static void Main()
        {
            Solution sol = new Solution();
            string[] str = { "eat", "tea", "tan", "ate", "nat", "bat" };
            IList<IList<string>> ans = sol.GroupAnagrams(str);

            foreach (IList<string> itemX in ans)
            {
                foreach (string itemY in itemX)
                {
                    Console.Write($"{itemY},");
                }
                Console.WriteLine();
            }
        }
    }

}