using System;
using System.Collections.Generic;
using System.Text;

namespace Comp_Coding
{
    class Check_If_a_Number_Is_Majority_Element_in_a_Sorted_Array
    {
        public bool IsMajorityElement(int[] nums, int target)
        {
            int left = Binary_Search_left(nums, 0, nums.Length - 1, target);
            int right = Binary_Search_right(nums, 0, nums.Length - 1, target);

            if (left == -1 || right == -1)
                return false;

            return (right - left + 1) > nums.Length / 2;
        }

        public int Binary_Search_left(int[] nums, int start, int end, int target)
        {
            int result = -1;
            while (start <= end)
            {
                int mid = start + (end - start) / 2;

                if (nums[mid] == target)
                {
                    result = mid;
                    end = mid - 1;
                }

                else if (nums[mid] < target)
                {
                    start = mid + 1;
                }

                else
                {
                    end = mid - 1;
                }
            }

            return result;
        }

        public int Binary_Search_right(int[] nums, int start, int end, int target)
        {
            int result = -1;
            while (start <= end)
            {
                int mid = start + (end - start) / 2;

                if (nums[mid] == target)
                {
                    result = mid;
                    start = mid + 1;
                }

                else if (nums[mid] < target)
                {
                    start = mid + 1;
                }

                else
                {
                    end = mid - 1;
                }
            }

            return result;
        }
    }
}
