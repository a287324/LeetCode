// See https://aka.ms/new-console-template for more information


namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main()
        {
            Solution solution = new Solution();
            int[] prices = new int[] { 7, 1, 5, 3, 6, 4 };
            //int[] prices = new int[] { 7, 6, 4, 3, 1 };

            Console.WriteLine("" + solution.MaxProfit(prices));
        }
    }

    public class Solution
    {
        public int MaxProfit(int[] prices)
        {
            int buy = prices[0];
            int profit = 0;
            for(int i = 1; i < prices.Length; i++)
            {
                buy = Math.Min(buy, prices[i]);
                profit = Math.Max(prices[i] - buy, profit);
            }
            return profit;
        }
    }
}




