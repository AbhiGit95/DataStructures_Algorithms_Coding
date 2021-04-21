using System;
using System.Collections.Generic;
using System.Text;

namespace Comp_Coding
{
    class StrangePrinterII
    {
        HashSet<int> unique_colors = new HashSet<int>();

        int[] x = new int[] { 1, 0, -1, 0 };
        int[] y = new int[] { 0, 1, 0, -1 };
        public bool IsPrintable(int[][] targetGrid)
        {
            if (targetGrid.Length == 1 && targetGrid[0].Length == 1)
                return true;

            int m = targetGrid.Length; int n = targetGrid.Length;
            bool[][] visited = new bool[m][];

            for(int i = 0; i < m; i++)
            {
                visited[i] = new bool[n];
            }

            for(int i = 0; i < m; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    if(!visited[i][j])
                    {
                        if(!unique_colors.Contains(targetGrid[i][j]))
                        {
                            //make a call to BFS function
                            BFS(targetGrid, visited, i, j, m, n, targetGrid[i][j]);

                            //Add unique colors to the set
                            unique_colors.Add(targetGrid[i][j]); 
                        }
                        else
                        {
                            //since the same color has not been visited that means it is a disconnected block
                            return false;
                        }
                            
                    }
                    
                }
            }

            return true;

        }

        public void BFS(int[][] grid, bool[][] visited, int i, int j, int m, int n, int color)
        {
            if (!isValid(i, m) || !isValid(j, n) || grid[i][j] != color || visited[i][j] )
                return;

            visited[i][j] = true;

            for(int k = 0; k < 4; k++)
            {
                
                BFS(grid, visited, i + x[k], j + y[k], m, n, color);
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
