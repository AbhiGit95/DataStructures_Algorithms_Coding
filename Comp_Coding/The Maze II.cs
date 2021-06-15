using System;
using System.Collections.Generic;
using System.Text;

namespace Comp_Coding
{
    public class The_Maze_II
    {
        int minsteps = int.MaxValue;
        int[] x = new int[] { -1, 1, 0, 0 };
        int[] y = new int[] { 0, 0, -1, 1 };

        public enum Move
        {
            UP = 1,
            DOWN = 2,
            LEFT = 3,
            RIGHT = 4
        };

        public int ShortestDistance(int[][] maze, int[] start, int[] destination)
        {
            if (maze == null || maze.Length == 0)
                return -1;

            int m = maze.Length; int n = maze[0].Length;
            bool[][] visited = new bool[m][];

            for (int i = 0; i < m; i++)
            {
                visited[i] = new bool[n];
            }

            DFS(start[0], start[1], m, n, destination, maze, visited, 0);

            return minsteps == int.MaxValue ? -1 : minsteps;
        }


        public void DFS(int i, int j, int m, int n, int[] destination, int[][] maze, bool[][] visited, int steps)
        {

            if (visited[i][j])
                return;

            if (maze[i][j] == 1)
                return;

            visited[i][j] = true;

            if (destination[0] == i && destination[1] == j)
            {
                minsteps = Math.Min(steps, minsteps);
                return;
            }

            for (int k = 0; k < 4; k++)
            {
                int x2 = i + x[k];
                int y2 = j + y[k];

                if (isValid(x2, m) & isValid(y2, n))
                    DFS(x2, y2, m, n, destination, maze, visited, steps + 1);
            }

            visited[i][j] = false;
        }

        public bool isValid(int a, int b)
        {
            if (a >= 0 & a < b)
                return true;
            return false;
        }
    }
}
