using System;
using System.Collections.Generic;
using System.Text;

namespace Comp_Coding
{
    public class Number_of_Closed_Islands
    {
        int[] x = new int[] { 0, 1, 0, -1 };
        int[] y = new int[] { 1, 0, -1, 0 };
        public int ClosedIsland(int[][] grid)
        {
            if (grid == null || grid.Length == 0)
                return 0;

            int m = grid.Length;
            int n = grid[0].Length;

            bool[][] visited = new bool[m][];

            for(int i = 0; i < m; i++)
            {
                visited[i] = new bool[n];
            }

            int res = 0;

            for(int i = 0; i < m; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    if(grid[i][j] == 0 && !visited[i][j])
                    {
                        //Call the BFS function here to check whether the island is well contained
                        if (BFS(grid, visited, i, j, m, n))
                            res += 1;
                    }
                }
            }
            return res;
        }

        public bool BFS(int[][] grid, bool[][]visited, int i, int j, int m, int n)
        {
            visited[i][j] = true;

            for(int k = 0; k < 4; k++)
            {
                if (isValid(i + x[k], m) && isValid(j + y[k], n) && !visited[i + x[k]][j + y[k]] && grid[i + x[k]][j + y[k]] == 0)
                     BFS(grid, visited, i + x[k], j + y[k], m, n);

                else if(!isValid(i + x[k], m) || !isValid(j + y[k], n))
                {
                    return false;
                }
            }
            return true;
        }


        public bool isValid(int a , int b)
        {
            if (a >= 0 && a < b)
                return true;
            return false;
        }
    }
}
