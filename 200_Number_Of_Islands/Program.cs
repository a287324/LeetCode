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
        public int NumIslands(char[][] grid)
        {
            int islands = 0;
            for(int i = 0; i < grid.Length; i++)
            {
                for(int j = 0; j < grid[i].Length; j++)
                {
                    if (grid[i][j] == '1')
                    {
                        DFS(grid, i, j);
                        islands++;
                    }
                }
            }
            return islands;
        }

        public void DFS(char[][] grid, int i, int j)
        {
            if (i >= 0 && i < grid.Length && 
                j >= 0 && j < grid[i].Length  && 
                grid[i][j] == '1')
            {
                grid[i][j] = '0';
                DFS(grid, i, j + 1);
                DFS(grid, i + 1, j);
                DFS(grid, i, j - 1);
                DFS(grid, i - 1, j);
            }
        }
    }

    internal class Program
    {
        static void Main()
        {
            Solution sol = new Solution();
            //char[][] grid = new char[4][] {
            //    new char[] {'1','1','0','0','0'},
            //    new char[] {'1','1','0','0','0'},
            //    new char[] {'0','0','1','0','0'},
            //    new char[] {'0','0','0','1','1'}
            //};
            //char[][] grid = new char[3][] {
            //    new char[] {'1','1','1'},
            //    new char[] {'0','1','0'},
            //    new char[] {'1','1','1'}
            //};
            char[][] grid = new char[3][] {
                new char[] {'1','0','1','1','1'},
                new char[] {'1','0','1','0','1'},
                new char[] {'1','1','1','0','1'}
            };
            Console.WriteLine(sol.NumIslands(grid));
        }
    }

}