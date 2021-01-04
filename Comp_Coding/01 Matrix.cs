using System;
using System.Collections.Generic;
using System.Text;

namespace Comp_Coding
{
    class _01_Matrix
    {
        public int[][] UpdateMatrix(int[][] matrix)
        {
            int m = matrix.Length; int n = matrix[0].Length;
            int[][] mat = new int[m][];

            for (int i = 0; i < m; i++)
            {
                mat[i] = new int[n];
                Array.Fill(mat[i], int.MaxValue - 500);
            }

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matrix[i][j] == 1)
                    {
                        if (i > 0)
                        {
                            mat[i][j] = Math.Min(mat[i - 1][j] + 1, mat[i][j]);
                        }
                        if (j > 0)
                        {
                            mat[i][j] = Math.Min(mat[i][j - 1] + 1, mat[i][j]);
                        }
                    }
                    else
                    {
                        mat[i][j] = 0;
                    }
                }
            }

            for (int i = m - 1; i >= 0; i--)
            {
                for (int j = n - 1; j >= 0; j--)
                {
                    if (matrix[i][j] == 1)
                    {
                        if (i < m - 1)
                        {
                            mat[i][j] = Math.Min(mat[i][j], 1 + mat[i + 1][j]);
                        }
                        if (j < n - 1)
                        {
                            mat[i][j] = Math.Min(mat[i][j], mat[i][j + 1] + 1);
                        }
                    }
                }

            }
            return mat;

        }
    }
}
