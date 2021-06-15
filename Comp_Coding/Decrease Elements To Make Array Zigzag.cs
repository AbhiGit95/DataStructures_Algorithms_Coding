using System;
using System.Collections.Generic;
using System.Text;

namespace Comp_Coding
{
    class Decrease_Elements_To_Make_Array_Zigzag
    {
        public int MovesToMakeZigzag(int[] nums)
        {
            int odd = movesOdd(nums);
            int even = movesEven(nums);

            return Math.Min(odd, even);
        }

        public int movesOdd(int[] nums)
        {
            int n = nums.Length;
            int steps = 0;
            for (int i = 0; i < n; i++)
            {
                var left = -1; var right = -1;
                if (i % 2 != 0 && i != n - 1)
                {
                    left = nums[i] - nums[i - 1];
                    right = nums[i] - nums[i + 1];
                }

                else if (i == n - 1 && i % 2 != 0)
                {
                    left = nums[i] - nums[i - 1];
                }

                if (left >= 0 && right >= 0)
                    steps += Math.Max(left, right) + 1;
                else if (left >= 0)
                    steps += left + 1;
                else if (right >= 0)
                    steps += right + 1;
            }

            return steps;
        }

        public int movesEven(int[] nums)
        {
            int n = nums.Length;
            int steps = 0;

            for (int i = 0; i < n; i++)
            {
                var left = -1; var right = -1;
                if (i % 2 == 0 && i != 0 && i != n - 1)
                {
                    left = nums[i] - nums[i - 1];
                    right = nums[i] - nums[i + 1];
                }
                else if (i % 2 == 0 && i == 0 && i != n - 1)
                {
                    right = nums[i] - nums[i + 1];
                }
                else if (i % 2 == 0 && i == n - 1 && i != 0)
                {
                    left = nums[i] - nums[i - 1];
                }

                if (left >= 0 && right >= 0)
                    steps += Math.Max(left, right) + 1;
                else if (left >= 0)
                    steps += left + 1;
                else if (right >= 0)
                    steps += right + 1;
            }

            return steps;
        }
    }
}
