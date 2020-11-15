using System;
using System.Collections.Generic;
using System.Text;

namespace Comp_Coding
{
    class PartitionArrayIntoThreePartsWithEqualSum
    {
        //136ms faster than 90.48%
        public bool CanThreePartsEqualSum(int[] A)
        {
            int n = A.Length;
            int cum_sum = 0;
            for (int i = 0; i < n; i++)
            {
                cum_sum += A[i];
            }

            if (cum_sum % 3 != 0)
                return false;
            else

            {
                int temp = 0; int count = 0; int target = cum_sum / 3;
                for (int i = 0; i < n; i++)
                {
                    temp += A[i];
                    if (temp == target)
                    {
                        count += 1;
                        temp = 0;
                    }
                }

                if (count >= 3)
                    return true;
                else
                    return false;
            }
        }
    }
}
