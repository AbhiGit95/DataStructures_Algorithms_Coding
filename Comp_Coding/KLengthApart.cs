using System;
using System.Collections.Generic;
using System.Text;

namespace Comp_Coding
{
    class KLengthApart
    {
        //use sliding window to remember the position of previous 1 and then standing at the next 1 calculate the gap and compare.
        public bool KLengthApart_func(int[] nums, int k)
        {
            int n = nums.Length;
            int start = 0; int end = 0; bool flag = false;
            while(end < n)
            {
                if(nums[end] == 1 && !flag)
                {
                    start = end;
                    flag = true;
                }

                else if(nums[end] == 1 && flag)
                {
                    if (end - start - 1  < k)
                        return false;

                    start = end;
                }
                end += 1;
            }

            return true;
        }
    }
}
