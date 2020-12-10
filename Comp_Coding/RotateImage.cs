using System;
using System.Collections.Generic;
using System.Text;

namespace Comp_Coding
{
    class RotateImage
    {
        public void Rotate(int[][] matrix)
        {
            int n = matrix.Length;
            for(int layer = 0; layer < n/2; layer ++)
            {
                //the image will be roated in n/2 iterations. Note : in n iterations the array will be restored to original form
                int first = layer; // indicates the upper left corner of the matrix/submatrix in consideration
                int last = n - 1 - first; // indicates the bottom right corner of the matrix/ submatrix in consideration.
                for(int i = first; i < last; i++)
                {
                    int offset = i - first; // will help in moving through the elements.

                    int top = matrix[first][i]; // get the element of the first row of the matrix/submatrix

                    matrix[first][i] = matrix[last - offset][first]; // get the elements of the first column of the matrix/submatrix from bottom to top manner.

                    matrix[last - offset][first] = matrix[last][last - offset]; // get the elements of the last row of the matrix/submatrix in right to left manner.

                    matrix[last][last - offset] = matrix[i][last]; // get the elements of the last column of the matrix/submatrix from top to bottom manner;

                    matrix[i][last] = top; // swap the topmost left corner element with the topmost right corner element of the matrix/submatrix.
                }
            }

        }
    }
}
