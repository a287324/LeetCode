// See https://aka.ms/new-console-template for more information


namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main()
        {
            Solution sol = new Solution();
            int[] nums = new int[] { 1, 2, 3, 4 };
            //int[] nums = new int[] { -1, 1, 0, -3, 3 };

            //Console.WriteLine("" + solution.MaxProfit(prices));
            //if (solution.ContainsDuplicate(nums))
            //{
            //    Console.WriteLine("TRUE");
            //} else
            //{
            //    Console.WriteLine("FALSE");
            //}
            int[] ans = sol.ProductExceptSelf(nums);
            foreach(var item in ans)
            {
                Console.WriteLine("  " + item);
            }
        }
    }

    public class Solution
    {
        public int[] ProductExceptSelf(int[] nums)
        {
            int[] prod = new int[nums.Length];
            int num = 1;

            // 計算第 i 個左邊所有數值的乘積(不包含自己)
            for(int i = 0; i < nums.Length; i++)
            {
                prod[i] = num;
                num *= nums[i];
            }

            // 計算第 i 個右邊所有數值的乘積(不包含自己)
            num = 1;
            for(int i = nums.Length - 1; i >= 0; i--)
            {
                prod[i] *= num;
                num *= nums[i];
            }
            return prod;
        }
    }
}




