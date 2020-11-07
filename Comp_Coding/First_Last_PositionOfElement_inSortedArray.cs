using System;
using System.Collections.Generic;
using System.Text;

namespace Comp_Coding
{
    class First_Last_PositionOfElement_inSortedArray
    {
        public int[] SearchRange(int[] nums, int target)
        {
            if (nums == null || nums.Length == 0)
                return new int[] { -1, -1 };

            int left = BinarySearch_left(nums, 0, nums.Length - 1, target);
            int right = BinarySearch_right(nums, 0, nums.Length - 1, target);

            return new int[] { left, right };
        }

        public int BinarySearch_left(int[] nums, int start, int end, int target)
        {
            if (start > end)
                return -1;

            int mid = start + (end - start) / 2;

            if(nums[mid] == target)
            {
                if(mid - 1 >= start && nums[mid-1] == target)
                {
                    return BinarySearch_left(nums, start, mid - 1, target);
                }
                else
                {
                    return mid;
                }
            }
            else if(nums[mid] < target)
            {
                return BinarySearch_left(nums, mid + 1, end, target);
            }
            else
            {
                return BinarySearch_left(nums, start, mid - 1, target);
            }
        }

        public int BinarySearch_right(int[] nums, int start, int end, int target)
        {
            if (start > end)
                return -1;

            int mid = start + (end - start) / 2;

            if(nums[mid] == target)
            {
                if(mid+1 <= end && nums[mid+1] == target)
                {
                    return BinarySearch_right(nums, mid + 1, end, target);
                }
                else
                {
                    return mid;
                }
            }

            if(nums[mid] > target)
            {
                return BinarySearch_right(nums, start, mid - 1, target);
            }
            else
            {
                return BinarySearch_right(nums, mid + 1, end, target);
            }
        }
    }
}
