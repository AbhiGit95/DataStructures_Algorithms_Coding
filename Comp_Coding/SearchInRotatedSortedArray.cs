using System;
using System.Collections.Generic;
using System.Text;

namespace Comp_Coding
{
    /*
     * LeetCode - 33
     */
    class SearchInRotatedSortedArray
    {
        public int Search(int[] nums, int target)
        {
            return BinarySearch(nums, 0, nums.Length - 1, target);
        }

        public int BinarySearch(int[] nums, int start, int end, int target)
        {
            if (start > end)
                return -1;

            int mid = start + (end - start) / 2;

            if (nums[mid] == target)
                return mid;

            //check if the rotation exists on left side
            if(nums[start] < nums[mid])
            {
                if(target < nums[mid] && target >= nums[start]) // Then the number has to exist in the left half if it is to
                {
                    //search on the left side
                    return BinarySearch(nums, start, mid - 1, target);
                }
                else
                {
                    //search on the right side
                    return BinarySearch(nums, mid + 1, end, target); //eg [3,4,5,6,7,8,1,2] target = 2 : so search has to be on right half. nums[mid] = 6
                }
            }

            //check if rotation exists on right half or not
            else if(nums[mid] < nums[end])
            {
                if(target > nums[mid] && target <= nums[end])
                {
                    //target has to exist in the right half
                    return BinarySearch(nums, mid + 1, end, target);
                }
                else
                {
                    //search on the left half
                    return BinarySearch(nums, start, mid - 1, target); //eg : [8,1,2,3,4,5,6,7] target = 8, nums[mid] = 3 and nums[end] = 7
                }
            }

            else if(nums[mid] == nums[start]) //possibility that all the elements are same in the array.
            {
                if(nums[mid] != nums[end])
                {
                    //element might be present in the right half
                    return BinarySearch(nums, mid + 1, end, target);
                }
                else
                {
                    //search in both halves because nums[start] = nums[mid] = nums[end] : [5,5,5,5,6,6,5,5] and target = 6
                    int index = BinarySearch(nums, start, mid - 1, target);
                    if (index == -1) // not present in left half
                        return BinarySearch(nums, mid + 1, end, target); //search on right half
                    else
                        return index;
                }
            }
            return -1;
        }
    }
}
