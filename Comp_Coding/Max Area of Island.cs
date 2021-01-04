using System;
using System.Collections.Generic;
using System.Text;

namespace Comp_Coding
{
    class Max_Area_of_Island
    {
        bool[][] visited;
        int[] x = new int[] { 0, 1, 0, -1 };
        int[] y = new int[] { 1, 0, -1, 0 };
        int count = 0;
        public int MaxAreaOfIsland(int[][] grid)
        {
            if (grid == null || grid.Length == 0 || grid[0].Length == 0)
                return 0;

            int m = grid.Length; int n = grid[0].Length;
            visited = new bool[m][];
            for(int i = 0; i < m; i++)
            {
                visited[i] = new bool[n];
            }
            int max = 0;
            for(int i = 0; i < m; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    if(!visited[i][j] && grid[i][j] == 1)
                    {
                        count = 1;
                        visited[i][j] = true;
                        DFS_helper(grid, i, j, m, n);
                        max = Math.Max(max, count);
                    }
                }
            }
            return max;
        }

        public void DFS_helper(int[][] grid, int i, int j, int m, int n)
        {
            for(int k = 0; k < 4; k++)
            {
                if(isValid(i + x[k], m) && isValid(j + y[k], n) && grid[i + x[k]][j + y[k]] == 1 && !visited[i + x[k]][j+y[k]])
                {
                    visited[i + x[k]][j + y[k]] = true;
                    count += 1;
                    DFS_helper(grid, i + x[k], j + y[k], m, n);
                }
            }
        }

        public bool isValid(int a, int b)
        {
            if (a >= 0 && a < b)
                return true;
            return false;
        }
    }
}
