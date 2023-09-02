// See https://aka.ms/new-console-template for more information


namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main()
        {
            Solution solution = new Solution();
            int[] num = new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
            //int[] num = new int[] { 5, 4, -1, 7, 8 };

            Console.WriteLine("" + solution.MaxSubArray(num));
        }
    }

    public class Solution
    {
        public int MaxSubArray(int[] nums)
        {
            int res = int.MinValue;
            int sum = 0;
            foreach(var item in nums)
            {
                sum = Math.Max(sum + item, item);
                if(res < sum)
                {
                    res = sum;
                }
            }
            return res;
        }
    }
}




