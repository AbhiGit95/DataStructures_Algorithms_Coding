using System;
using System.Collections.Generic;
using System.Text;

namespace Comp_Coding
{
    class Two_Sum_Less_Than_K
    {
        public int TwoSumLessThanK(int[] nums, int k)
        {
            if (nums == null || nums.Length == 0)
                return -1;

            Array.Sort(nums);
            int sum = -1;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                int num = BinarySearch(i + 1, nums.Length - 1, nums, k - nums[i]);
                if (num == -1)
                    break;
                sum = Math.Max(sum, nums[num] + nums[i]);
            }

            return sum;
        }

        public int BinarySearch(int start, int end, int[] nums, int target)
        {
            int res = -1;
            while (start <= end)
            {
                int mid = start + (end - start) / 2;

                if (nums[mid] >= target)
                {
                    end = mid - 1;
                }
                else
                {
                    res = mid;
                    start = mid + 1;
                }
            }

            return res;
        }
    }
}
