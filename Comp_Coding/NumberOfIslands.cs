using System;
using System.Collections.Generic;
using System.Text;

namespace Comp_Coding
{
    class NumberOfIslands
    {
        //without changing the input array.
        public int NumIslands(char[][] grid)
        {
            if (grid == null || grid.Length == 0 || grid[0].Length == 0)
                return 0;

            int m = grid.Length; int n = grid[0].Length;
            bool[][] visited = new bool[m][];

            int result = 0;

            for (int i = 0; i < m; i++)
            {
                visited[i] = new bool[n];
            }

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (grid[i][j] == '1' && !visited[i][j])
                    {
                        DFS_helper(grid, i, j, m, n, visited);
                        result += 1;
                    }

                }
            }
            return result;
        }

        int[] x = new int[] { 0, -1, 0, 1 };
        int[] y = new int[] { 1, 0, -1, 0 };

        public void DFS_helper(char[][] grid, int i, int j, int m, int n, bool[][] visited)
        {
            visited[i][j] = true;
            for (int k = 0; k < 4; k++)
            {
                if (isValid(i + x[k], m) && isValid(j + y[k], n) && !visited[i + x[k]][j + y[k]] && grid[i + x[k]][j + y[k]] == '1')
                {
                    DFS_helper(grid, i + x[k], j + y[k], m, n, visited);
                }

            }
        }

        public bool isValid(int a, int b)
        {
            if (a >= 0 && a < b)
                return true;
            else
                return false;
        }
    }
}
