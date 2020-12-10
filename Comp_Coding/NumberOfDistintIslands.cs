using System;
using System.Collections.Generic;
using System.Text;

namespace Comp_Coding
{
    class NumberOfDistintIslands
    {
        //Keep track of the path to check if the islands can be translated.
        bool[][] visited;
        int[] x = new int[] { 0, -1, 1, 0 };
        int[] y = new int[] { 1, 0, 0, -1 };
        StringBuilder sb;
        public int NumDistinctIslands(int[][] grid)
        {
            if (grid.Length == 0 || grid == null || grid[0].Length == 0)
                return 0;

            int m = grid.Length; int n = grid[0].Length;
            visited = new bool[m][];
            for(int i = 0; i < m; i++)
            {
                visited[i] = new bool[n];
            }

            HashSet<string> set = new HashSet<string>();

            for (int i = 0; i < m; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    if(grid[i][j] == 1 && !visited[i][j])
                    {
                        visited[i][j] = true;
                        sb = new StringBuilder();
                        DFS_helper(grid, i, j, m, n, sb);
                        string path = sb.ToString();
                        if(!set.Contains(path))
                        {
                            set.Add(path);
                        }
                        
                    }
                }
            }

            return set.Count;
        }

        public void DFS_helper(int[][]grid, int i, int j, int m, int n, StringBuilder sb)
        {
            for(int k = 0; k < 4; k++)
            {
                if(isValid(i+x[k],m) && isValid(j+y[k],n) && !visited[i+x[k]][j+y[k]] && grid[i + x[k]][j + y[k]] == 1)
                {
                    visited[i + x[k]][j + y[k]] = true;
                    DFS_helper(grid, i + x[k], j + y[k], m, n, sb.Append(Convert.ToChar(48 + k)));
                    sb.Append('4');
                }
            }
        }

        public bool isValid(int a , int b)
        {
            if (a < b && a >= 0)
                return true;
            return false;
        }
    }
}
