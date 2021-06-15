using System;
using System.Collections.Generic;
using System.Text;

namespace Comp_Coding
{
    class Partition_Equal_Subset_Sum
    {
        bool?[][] memoize;
        public bool CanPartition(int[] nums)
        {
            int sum = 0;
            int n = nums.Length;

            memoize = new bool?[n + 1][];

            for (int i = 0; i < n; i++)
            {
                sum += nums[i];
            }

            if (sum % 2 != 0)
                return false;

            int targetSum = sum / 2;

            for (int i = 0; i <= n; i++)
            {
                memoize[i] = new bool?[targetSum + 1];
            }

            return exists(targetSum, nums, n - 1);
        }

        public bool exists(int target, int[] nums, int i)
        {
            if (target == 0)
            {
                return true;
            }

            if (i < 0 || target < 0)
                return false;

            if (memoize[i][target] != null)
            {
                return memoize[i][target].Value;
            }

            bool result = (exists(target - nums[i], nums, i - 1) || exists(target, nums, i - 1));

            memoize[i][target] = result;
            return result;
        }
    }
}
