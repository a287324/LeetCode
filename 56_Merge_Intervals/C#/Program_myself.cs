// See https://aka.ms/new-console-template for more information


namespace LeetCode // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main()
        {
            Solution sol = new Solution();
            int[][] intervals = new int[][]
            {
                new int [] { 1, 9},
                new int [] { 20, 21},
                new int [] { 8, 10},
                new int [] { 15, 18}
            };
            int[][] ans = sol.Merge(intervals);
            for (int i = 0; i < ans.Length; i++)
            {
                for(int j = 0; j < ans[i].Length; j++)
                {
                    Console.Write($"{ans[i][j],3}");
                }
                Console.WriteLine();
            }
        }
    }
    public class Solution
    {
        public int[][] Merge(int[][] intervals)
        {
            // 檢查長度
            if(intervals == null || intervals.Length == 1)
            {
                return intervals;
            }

            // 排序
            Array.Sort(intervals, (a, b) => (a[0] - b[0]));

            // 整理
            List<int[]> ans = new List<int[]>();
            ans.Add(intervals[0]);
            for(int i = 1; i < intervals.Length; ++i)
            {
                if (ans[ans.Count - 1][1] < intervals[i][0])
                {
                    ans.Add(intervals[i]);
                }
                else
                {
                    ans[ans.Count - 1][1] = Math.Max(ans[ans.Count - 1][1], intervals[i][1]);
                }
            }
            return ans.ToArray();
        }
    }
}