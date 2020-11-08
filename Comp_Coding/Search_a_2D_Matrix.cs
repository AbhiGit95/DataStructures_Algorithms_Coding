using System;
using System.Collections.Generic;
using System.Text;

namespace Comp_Coding
{
    class Search_a_2D_Matrix
    {
        public bool SearchMatrix(int[][] matrix, int target)
        {
            if (matrix == null || matrix.Length == 0 || matrix[0].Length == 0 || matrix[0] == null)
                return false;

            int index = BinarySearch(matrix, target, 0, matrix.Length - 1, matrix[0].Length-1);
            if (index == -1)
                return false;
            else
            {
                for(int i = 0; i < matrix[index].Length; i++)
                {
                    if (matrix[index][i] == target)
                        return true;
                }
                return false;
            }
        }

        public int BinarySearch(int[][]matrix, int target, int start, int end, int row_end)
        {
            if (start > end)
                return -1;

            int mid = start + (end - start) / 2;
            if (matrix[mid][0] <= target && matrix[mid][row_end] >= target)
                return mid;

            else if (matrix[mid][0] > target)
                return BinarySearch(matrix, target, start, mid - 1, row_end);

            else 
                return BinarySearch(matrix, target, mid + 1, end, row_end);
        }
    }
}
