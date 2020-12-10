using System;
using System.Collections.Generic;
using System.Text;

namespace Comp_Coding
{
    class DiagonalTraverse
    {
        //Simulating the whole thing
        public int[] FindDiagonalOrder(int[][] matrix)
        {
            if (matrix == null || matrix.Length == 0 || matrix[0].Length == 0)
            {
                return new int[0];
            }
            List<int> res = new List<int>();
            bool direction = false;
            int[] start = new int[] { 0, 0 };
            int m = matrix.Length; int n = matrix[0].Length;
            for (int i = 0; i <= m * n - 1; i++)
            {
                if (direction)
                {
                    //Going down the diagonal
                    while (isValid(start[0], m) && isValid(start[1], n))
                    {
                        res.Add(matrix[start[0]][start[1]]);
                        start[0] = start[0] + 1;
                        start[1] = start[1] - 1;
                    }

                    if (isValid(start[0], m))
                    {
                        start[1] = start[1] + 1;
                    }

                    else
                    {
                        start[0] = start[0] - 1;
                        start[1] = start[1] + 2;
                    }
                    direction = false;
                }

                else
                {
                    //Going up the diagonal
                    while (isValid(start[0], m) && isValid(start[1], n))
                    {
                        res.Add(matrix[start[0]][start[1]]);
                        start[0] = start[0] - 1;
                        start[1] = start[1] + 1;
                    }

                    if (isValid(start[1], n))
                    {
                        start[0] += 1;
                    }

                    else
                    {
                        start[0] += 2;
                        start[1] -= 1;
                    }

                    direction = true;
                }
            }

            return res.ToArray();
        }

        public bool isValid(int a, int b)
        {
            if (a >= 0 && a < b)
                return true;
            return false;
        }

        //Another solution using Dictionary
        public int[] FindDiagonalOrder2(int[][] matrix)
        {
            List<int> res = new List<int>();
            if (matrix == null || matrix.Length == 0 || matrix[0].Length == 0)
                return res.ToArray();

            Dictionary<int, List<int>> nums = new Dictionary<int, List<int>>();

            for(int i = 0; i < matrix.Length; i++)
            {
                for(int j = 0; j < matrix[0].Length; j++)
                {
                    int sum = i + j;
                    if(nums.ContainsKey(sum))
                    {
                        nums[sum].Add(matrix[i][j]);
                    }
                    else
                    {
                        nums.Add(sum, new List<int>() { matrix[i][j] });
                    }
                }
            }

            for(int i = 0; i < matrix.Length; i++)
            {
                List<int> temp = nums[i + i];
                if (i % 2 == 0)
                {
                    temp.Reverse();
                }

                    res.AddRange(temp);
            }

            return res.ToArray();
        }

    }
}
