// See https://aka.ms/new-console-template for more information


namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main()
        {
            Solution solution = new Solution();
            int[] nums = { 2, 11, 15, 7 };
            int target = 9;
            int[] ans;
            ans = solution.TwoSum(nums, target);
            for (int i = 0; i < ans.Length; i++)
            {
                Console.WriteLine("an[" + i + "] = " + ans[i]);
            }
        }
    }

    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];
                if (dic.ContainsKey(complement))
                {
                    return new int[] { dic[complement], i };
                }
                dic[nums[i]] = i;
            }
            throw new Exception("No Solution");
        }
    }
}




