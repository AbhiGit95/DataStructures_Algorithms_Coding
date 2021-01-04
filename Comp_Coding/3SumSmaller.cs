using System;
using System.Collections.Generic;
using System.Text;

namespace Comp_Coding
{
    class _3SumSmaller
    {
        public int ThreeSumSmaller(int[] nums, int target)
        {
            if (nums == null || nums.Length == 0)
                return 0;

            Array.Sort(nums);
            int result = 0;
            for (int i = 0; i < nums.Length - 2; i++)
            {
                for (int j = i + 1; j < nums.Length - 1; j++)
                {
                    int diff = target - (nums[i] + nums[j]);
                    int k = BinarySearch(j + 1, nums.Length, nums, diff);
                    if (k != -1)
                    {
                        result += k - j;
                    }
                    else
                        break;
                }
            }

            return result;
        }

        public int BinarySearch(int start, int end, int[] nums, int target)
        {
            int index = -1;
            while (start <= end && start != nums.Length)
            {
                int mid = start + (end - start) / 2;

                if (nums[mid] < target)
                {
                    index = mid;
                    start = mid + 1;
                }
                else
                {
                    end = mid - 1;
                }
            }
            return index;
        }
    }
}
