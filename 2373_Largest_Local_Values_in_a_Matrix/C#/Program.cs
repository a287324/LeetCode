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

            int[][] grid = new int[][] {
                new int[] { 9, 9, 8, 1 },
                new int[] { 5, 6, 2, 6 },
                new int[] { 8, 2, 6, 4 },
                new int[] { 6, 2, 2, 2 }
            };

            //int[,] grid = new int[,] { { 9, 9 }, { 8, 6 } };

            //string s = "anagram", t = "nagaram";
            //string s = "rat", t = "car";

            //Console.WriteLine("" + solution.MaxProfit(prices));

            //if (sol.IsAnagram(s, t))
            //{
            //    Console.WriteLine("TRUE");
            //}
            //else
            //{
            //    Console.WriteLine("FALSE");
            //}

            //int[] ans = sol.ProductExceptSelf(nums);
            //foreach(var item in ans)
            //{
            //    Console.WriteLine("  " + item);
            //}

            int[][] ans = sol.LargestLocal(grid);
            for(int i = 0; i < ans.Length; i++)
            {
                for(int j = 0; j < ans[i].Length; j++)
                {
                    Console.Write("  " + ans[i][j]);
                }
                Console.WriteLine(" ");
            }
        }
    }

    public class Solution
    {
        public int[][] LargestLocal(int[][] grid)
        {
            int gridSize = grid.Length;
            int[][] ans = new int[gridSize-2][];

            for(int i = 0; i < gridSize-2; i++)
            {
                ans[i] = new int[gridSize - 2];
                for (int j = 0; j < gridSize-2; j++)
                {
                    for(int m = i; m <= i+2; m++)
                    {
                        for(int n = j; n <= j+2; n++)
                        {
                            ans[i][j] = Math.Max(ans[i][j], grid[m][n]);
                        }
                    }
                }
            }
            return ans;
        }
    }
}




