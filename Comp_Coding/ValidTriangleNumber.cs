using System;
using System.Collections.Generic;
using System.Text;

namespace Comp_Coding
{
    class ValidTriangleNumber
    {
        // using Binary Search
        public int BinarySearch(int l, int r, int[] nums, int target)
        {
            while (l <= r && l < nums.Length)
            {
                int mid = (r + l) / 2;

                if (nums[mid] < target)
                {
                    l = mid + 1;
                }

                else
                {
                    r = mid - 1;
                }
            }
            return l;
        }

        public int TriangleNumber(int[] nums)
        {
            Array.Sort(nums);
            int count = 0;

            for (int i = 0; i < nums.Length - 2; i++)
            {
                int k = i + 2;
                for (int j = i + 1; j < nums.Length - 1 && nums[i] != 0; j++)
                {
                    k = BinarySearch(k, nums.Length - 1, nums, nums[i] + nums[j]);
                    count += (k - j - 1);
                }
            }
            return count;
        }
    }
}
