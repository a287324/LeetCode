// See https://aka.ms/new-console-template for more information


namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main()
        {
            Solution sol = new Solution();
            //int[] nums = new int[] { 1, 2, 3, 4 };
            //int[] nums = new int[] { -1, 1, 0, -3, 3 };

            string s = "anagram", t = "nagaram";
            //string s = "rat", t = "car";

            //Console.WriteLine("" + solution.MaxProfit(prices));

            if (sol.IsAnagram(s, t))
            {
                Console.WriteLine("TRUE");
            }
            else
            {
                Console.WriteLine("FALSE");
            }

            //int[] ans = sol.ProductExceptSelf(nums);
            //foreach(var item in ans)
            //{
            //    Console.WriteLine("  " + item);
            //}
        }
    }

    public class Solution
    {
        public bool IsAnagram(string s, string t)
        {
            // check length
            if(s.Length !=  t.Length) { return false; }

            // check letter
            int[] letter = new int[26];
            for(int i = 0; i < s.Length; i++)
            {
                letter[s[i] - 'a']++;
                letter[t[i] - 'a']--;
            }

            // 檢查是否所有元素都等於0，如果是回傳true,否則回傳true
            return letter.All(i => i == 0);
        }
    }
}




