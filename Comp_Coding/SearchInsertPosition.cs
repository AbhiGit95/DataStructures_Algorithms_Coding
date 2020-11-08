using System;
using System.Collections.Generic;
using System.Text;

namespace Comp_Coding
{
    class SearchInsertPosition
    {
        public int SearchInsert(int[] nums, int target)
        {
            if (nums == null || nums.Length == 0)
                return -1;
            else
                return BinarySearch(nums, 0, nums.Length-1, target, -1);

        }

        public int BinarySearch(int[] nums, int start, int end, int target, int index)
        {
            if (start > end)
                return index;
            int mid = start + (end - start) / 2;
            if (nums[mid] == target)
                return mid;
            else if (nums[mid] > target)
            {
                index = mid;
                return BinarySearch(nums, start, mid - 1, target, index);
            }
            else
            {
                index = mid + 1;
                return BinarySearch(nums, mid + 1, end, target, index);
            }
        }
    }
}
