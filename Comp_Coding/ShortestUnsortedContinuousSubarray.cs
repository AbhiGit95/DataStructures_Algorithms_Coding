using System;
using System.Collections.Generic;
using System.Text;

namespace Comp_Coding
{
    class ShortestUnsortedContinuousSubarray
    {
        //T(n) = O(nlogn) -- Scroll down to find an optimized solution in linear time
        public int FindUnsortedSubarray(int[] nums)
        {
            int[] temp = new int[nums.Length];
            Array.Copy(nums, 0, temp, 0, nums.Length);
            Array.Sort(temp);

            int start = int.MaxValue;
            int end = int.MinValue;

            for (int i = 0; i < nums.Length; i++)
            {
                if (temp[i] != nums[i])
                {
                    start = Math.Min(start, i);
                    end = Math.Max(end, i);
                }
            }

            if (start == int.MaxValue && end == int.MinValue)
                return 0;
            else
            {
                return end - start + 1;
            }
        }


        //Optimized solution - Linear Time
        public int FindUnsortedSubarray_Optimized(int[] nums)
        {
            if (nums.Length == 1)
                return 0;

            int start = -1;
            int end = -1;
            int min = int.MaxValue; int max = int.MinValue;
            bool flag_start = false; bool flag_end = false;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] < nums[i - 1])
                {
                    flag_start = true;
                }

                if (flag_start)
                {
                    min = Math.Min(min, nums[i]);
                }
            }

            for (int i = nums.Length - 2; i >= 0; i--)
            {
                if (nums[i] > nums[i + 1])
                {
                    flag_end = true;
                }

                if (flag_end)
                {
                    max = Math.Max(max, nums[i]);
                }
            }


            //find the correct position of min in nums

            for (int i = 0; i < nums.Length; i++)
            {
                if(nums[i] > min)
                {
                    start = i;
                    break;
                }
            }

            //find the correct position of max in nums

            for(int i = nums.Length - 1; i >= 0; i--)
            {
                if(max > nums[i])
                {
                    end = i;
                    break;
                }
            }

            if (start == -1 && end == -1)
                return 0;
            else
            {
                return (end - start + 1);
            }
        }
    }
}
