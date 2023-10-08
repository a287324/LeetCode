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
                new int [] { 1, 3},
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
            // 如果區間數組為空或只有一個區間，直接返回
            if (intervals == null || intervals.Length <= 1)
            {
                return intervals;
            }
            // 對區間按照左端點進行排序
            Array.Sort(intervals, (a, b) => a[0] - b[0]);
            // 創建一個列表來存儲合併後的區間
            List<int[]> merged = new List<int[]>();
            // 遍歷區間
            foreach (int[] interval in intervals)
            {
                // 如果列表為空或者當前區間與前一個區間不重疊，直接加入到列表中
                if (merged.Count == 0 || merged[merged.Count - 1][1] < interval[0])
                {
                    merged.Add(interval);
                }
                // 否則，將當前區間與前一個區間合併，更新右端點為兩者的最大值
                else
                {
                    merged[merged.Count - 1][1] = Math.Max(merged[merged.Count - 1][1], interval[1]);
                }
            }
            // 將列表轉換為二維數組並返回
            return merged.ToArray();
        }
    }
}