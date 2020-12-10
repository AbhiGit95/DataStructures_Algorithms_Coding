using System;
using System.Collections.Generic;
using System.Text;

namespace Comp_Coding
{
    class AsFarfromLandasPossible
    {
        public int MaxDistance(int[][] grid)
        {
            if (grid == null || grid.Length == 0)
                return -1;

            int m = grid.Length;
            int n = grid[0].Length;


            int max_dist = int.MinValue;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (grid[i][j] == 0)
                    {
                        int temp = BFS((i, j), grid, m, n);
                        max_dist = Math.Max(max_dist, temp);
                    }
                }
            }

            return max_dist == int.MinValue ? -1 : max_dist;
        }

        int[] row = new int[] { -1, 0, 1, 0 };
        int[] col = new int[] { 0, 1, 0, -1 };

        public int BFS((int, int) val, int[][] grid, int m, int n)
        {
            bool[][] marked = new bool[m][];
            for (int i = 0; i < m; i++)
            {
                marked[i] = new bool[n];

            }
            Queue<(int, int)> bfs_queue = new Queue<(int, int)>();
            bfs_queue.Enqueue(val); marked[val.Item1][val.Item2] = true;
            int level = 0;
            while (bfs_queue.Count != 0)
            {
                int count = bfs_queue.Count;
                for (int j = 0; j < count; j++)
                {
                    var temp = bfs_queue.Dequeue();
                    if (grid[temp.Item1][temp.Item2] == 1)
                    {
                        return level;
                    }

                    else
                    {
                        for (int k = 0; k < 4; k++)
                        {
                            int x = temp.Item1 + row[k];
                            int y = temp.Item2 + col[k];
                            if (isValid(x, m) && isValid(y, n) && !marked[x][y])
                            {
                                marked[x][y] = true;
                                bfs_queue.Enqueue((x, y));
                            }
                        }
                    }
                }
                level++;
            }

            return -1;
        }

        public bool isValid(int x, int m)
        {
            if (x >= 0 && x < m)
                return true;
            return false;
        }
    }
}
