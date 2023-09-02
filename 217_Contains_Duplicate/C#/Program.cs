// See https://aka.ms/new-console-template for more information


namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main()
        {
            Solution solution = new Solution();
            //int[] nums = new int[] { 1, 2, 3, 1 };
            //int[] nums = new int[] { 1, 2, 3, 4 };
            int[] nums = new int[] { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 };

            //Console.WriteLine("" + solution.MaxProfit(prices));
            if (solution.ContainsDuplicate(nums))
            {
                Console.WriteLine("TRUE");
            } else
            {
                Console.WriteLine("FALSE");
            }
        }
    }

    public class Solution
    {
        public bool ContainsDuplicate(int[] nums)
        {
            HashSet<int> set = new HashSet<int>();
            foreach(int item in nums)
            {
                if(set.Contains(item))
                {
                    return true;
                }
                set.Add(item);
            }
            return false;
        }
    }
}




