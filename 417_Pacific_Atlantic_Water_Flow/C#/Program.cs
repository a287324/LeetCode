using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;

namespace LeetCode
{
    public class Solution
    {
        private int[][] dirs = { new int[] { -1, 0 }, 
                                 new int[] { 1, 0 }, 
                                 new int[] { 0, -1 }, 
                                 new int[] { 0, 1 } };
        public IList<IList<int>> PacificAtlantic(int[][] heights)
        {
            IList<IList<int>> res = new List<IList<int>>();

            if(heights == null || heights.Length == 0 || heights[0].Length == 0)
            {
                return res;
            }

            int row = heights.Length;
            int col = heights[0].Length;
            bool[,] pacific = new bool[row, col];
            bool[,] atlantic = new bool[row, col];

            // 左右邊逐個尋訪
            for(int i = 0; i < row; i++)
            {
                DFS(heights, pacific, i, 0);
                DFS(heights, atlantic, i, (col - 1));
            }
            // 上下邊逐個尋訪
            for(int i = 0; i < col; i++)
            {
                DFS(heights, pacific, 0, i);
                DFS(heights, atlantic, (row - 1), i);
            }

            // 都遍歷所有格子後，檢查重複的格子
            for(int i = 0; i < row; i++)
            {
                for(int j = 0; j < col; j++)
                {
                    if (pacific[i, j] && atlantic[i, j])
                    {
                        res.Add(new List<int>() { i, j });
                    }
                }
            }
            return res;
        }
        public void DFS(int[][] grid, bool[,] visited, int i, int j)
        {
            if(!visited[i, j])
            {
                visited[i, j] = true;
                
                foreach(int[] dir in dirs)
                {
                    int x = i + dir[0];
                    int y = j + dir[1];
                    if (x >= 0 && x < grid.Length &&
                       y >= 0 && y < grid[x].Length &&
                       grid[x][y] >= grid[i][j])
                    {
                        DFS(grid, visited, x, y);
                    }
                }
            }
        }
    }

    internal class Program
    {
        static void Main()
        {
            Solution sol = new Solution();
            //int[][] heights = new int[5][] { 
            //    new int[] { 1, 2, 2, 3, 5 }, 
            //    new int[] { 3, 2, 3, 4, 4 }, 
            //    new int[] { 2, 4, 5, 3, 1 }, 
            //    new int[] { 6, 7, 1, 4, 5 }, 
            //    new int[] { 5, 1, 1, 2, 4 } };
            //int[][] heights = new int[2][] {
            //    new int[] { 1, 1 },
            //    new int[] { 1, 1 }};
            int[][] heights = new int[5][] {
                new int[] {1,2,2,3,5},
                new int[] {3,2,3,4,4},
                new int[] {2,4,5,3,1},
                new int[] {6,7,1,4,5},
                new int[] {5,1,1,2,4}};

            IList<IList<int>> res = sol.PacificAtlantic(heights);

            for (int i = 0; i < res.Count; i++)
            {
                for (int j = 0; j < res[i].Count; j++)
                {
                    Console.Write(res[i][j] + ",");
                }
                Console.WriteLine();
            }
        }
    }

}