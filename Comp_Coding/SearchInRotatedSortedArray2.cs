using System;
using System.Collections.Generic;
using System.Text;

namespace Comp_Coding
{
    class SearchInRotatedSortedArray2
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

            //only this part is different as compared to SearchInRotatedSortedArray
            if (nums[start] == nums[end])
            {
                //Ignore those elements to check if there is any different element than nums[start]
                while (nums[start] == nums[end])
                {
                    if (start == end)
                        return nums[start];

                    start += 1;
                }

            }

            int mid = start + (end - start) / 2;
            if (nums[mid] > nums[end])
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
