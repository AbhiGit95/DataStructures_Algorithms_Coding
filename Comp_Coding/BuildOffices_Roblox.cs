using System;
using System.Collections.Generic;
using System.Text;

namespace Comp_Coding
{
    class BuildOffices_Roblox
    {
        static int[] dx = new int[] { 1, -1, 0, 0 };
        static int[] dy = new int[] { 0, 0, -1, 1 };


        public static int findMinDistance(int h, int w, int n)
        {

            int[][] grid = new int[w][];
            for (int i = 0; i < w; i++)
            {
                grid[i] = new int[h];
            }
            return solve(n, w, h, 0, 0, grid);
        }

        static int bfs(int W, int H, int[][] grid)
        {

            int[][] dist = new int[W][];
            for (int i = 0; i < W; i++)
            {
                dist[i] = new int[H];
            }

            for (int i = 0; i < W; i++)
                for (int j = 0; j < H; j++)
                    dist[i][j] = grid[i][j];

            int maxDist = 0;
            Queue<Location> Q = new Queue<Location>();
            for (int i = 0; i < W; i++)
                for (int j = 0; j < H; j++)
                    if (dist[i][j] == 0)
                    {
                        Q.Enqueue(new Location(i, j));
                    }

            while (Q.Count != 0)
            {
                int x = Q.Peek().first;
                int y = Q.Peek().second;
                maxDist = Math.Max(maxDist, dist[x][y]);
                Q.Dequeue();

                for (int d = 0; d < 4; d++)
                {
                    int newx = x + dx[d];
                    int newy = y + dy[d];

                    if (newx >= W || newy >= H || newx < 0 || newy < 0)
                        continue;
                    if (dist[newx][newy] == -1)
                    {
                        dist[newx][newy] = dist[x][y] + 1;
                        Q.Enqueue(new Location(newx, newy));
                    }
                }
            }
            return maxDist;
        }

        static int solve(int left, int W, int H, int row, int col, int[][] grid)
        {
            if (left == 0)
            {
                return bfs(W, H, grid);
            }
            int r = row, c = col;
            if (col >= H)
            {
                r += col / H;
                c = col % H;
            }
            int minDistance = int.MaxValue;
            for (int i = r; i < W; i++)
            {
                for (int j = c; j < H; j++)
                {
                    //Mark Building locations in the recursive call.
                    grid[i][j] = 0;
                    int val = solve(left - 1, W, H, i, j + 1, grid);
                    minDistance = Math.Min(minDistance, val);
                    // Remove the building
                    grid[i][j] = -1;
                }
            }
            return minDistance;
        }
        public class Location
        {
            public int first;
            public int second;
            public Location(int x, int y)
            {
                first = x;
                second = y;
            }
        }
    }
}
