using System;
using System.Collections.Generic;
using System.Text;

namespace Comp_Coding
{
    class LongestContinuousSubarrayWithAbsoluteDiffLessThanorEqualtoLimit
    {
        //using sliding window
        public int LongestSubarray(int[] nums, int limit)
        {
            int max = int.MinValue;
            int min = int.MaxValue;
            int n = nums.Length; int window_size = 0; int max_window = 0;
            int start = 0; int end = 0; int max_index = 0; int min_index = 0;
            while(end < n)
            {
                if(nums[end] >= max)
                {
                    max = nums[end]; max_index = end;
                }
                if(nums[end] <= min)
                {
                    min = nums[end]; min_index = end;
                }

                if(Math.Abs(max-min) <= limit)
                {
                    window_size += 1;
                    end += 1;
                }
                else
                {
                    // The absolute difference between the maximum and minimum element in the subarray is greater than the limit
                    max_window = Math.Max(window_size, max_window);
                   if(nums[end] == max)
                    {
                        start = min_index + 1; min = nums[start];
                        for(int i = start; i < end; i++)
                        {
                            if(nums[i] <= min)
                            {
                                min = nums[i]; min_index = i;
                            }
                        }
                    }
                   else
                    {
                        start = max_index + 1;
                        max = nums[start];
                        for (int i = start; i < end; i++)
                        {
                            if (nums[i] >= max)
                            {
                                max = nums[i]; max_index = i;
                            }
                        }
                    }
                    window_size = end - start;
                }
            }
            max_window = Math.Max(max_window, window_size);
            return max_window;
        }
    }
}
