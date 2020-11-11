using System;
using System.Collections.Generic;
using System.Text;

namespace Comp_Coding
{
    class FindMinimumInSortedArray
    {
        public int FindMin(int[] nums)
        {
            if (nums.Length == 0)
                return 0;
            return BinarySearch(nums, 0, nums.Length - 1);
        }

        public int BinarySearch(int[] nums, int start, int end)
        {
            if (start == end)
                return nums[start];

            int mid = start + (end - start) / 2;
            if(nums[mid] > nums[end])
            {
                //recurse on Right side
                return BinarySearch(nums, mid + 1, end);
            }
            else
            {
                return BinarySearch(nums, start, mid);
            }
        }
    }
}
