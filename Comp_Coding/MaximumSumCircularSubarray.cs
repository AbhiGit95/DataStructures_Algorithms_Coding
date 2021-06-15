using System;
using System.Collections.Generic;
using System.Text;

namespace Comp_Coding
{
    class MaximumSumCircularSubarray
    {
        public int MaxSubarraySumCircular(int[] A)
        {
            if (A == null || A.Length == 0)
                return 0;

            int n = A.Length;

            int index = 0;
            int maxSum = int.MinValue;
            int currSum = 0;

            while (index < 2 * n)
            {
                var num = A[index % n];
                
                if(num > 0)
                {
                    currSum += num;
                    maxSum = Math.Max(currSum, maxSum);
                }
                else
                {
                    currSum = 0;
                }

                index++;
            }

            return maxSum;
        }
    }
}
