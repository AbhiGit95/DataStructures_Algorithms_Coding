using System;
using System.Collections.Generic;
using System.Text;

namespace Comp_Coding
{
    class EqualSumPartition
    {
        public bool equalsumpartition(int[] arr , int S)
        {
            int sum = 0; int n = arr.Length;
            for(int i = 0; i < n; i++)
            {
                sum += arr[i];
            }

            if (sum % 2 != 0)
                return false;

            SubSetSum s = new SubSetSum();
            return s.SubSetSum_BottomUp(arr, sum / 2);
        }
    }
}
