using System;
using System.Collections.Generic;
using System.Text;

namespace Comp_Coding
{
    class Maximize_Sum_Of_Array_After_K_Negations
    {
        public int LargestSumAfterKNegations(int[] nums, int k)
        {
            Array.Sort(nums);
            int negativeCount = 0; bool hasZero = false; int n = nums.Length;
            int? smallestNegative = null; int? firstPositive = null;
            for (int i = 0; i < n; i++)
            {
                if (nums[i] < 0)
                {
                    smallestNegative = nums[i];
                    negativeCount++;
                }

                else if (nums[i] == 0)
                    hasZero = true;

                else if (nums[i] > 0 && firstPositive == null)
                    firstPositive = nums[i];
            }

            int sum = 0;

            if (k <= negativeCount)
            {
                foreach (int num in nums)
                {
                    if (k > 0)
                        sum += Math.Abs(num);
                    else
                        sum += num;
                    k--;
                }
            }
            else
            {
                if (hasZero)
                {
                    foreach (int num in nums)
                    {
                        sum += Math.Abs(num);
                    }
                }
                else
                {
                    if ((k - negativeCount % 2) == 0)
                    {
                        foreach (int num in nums)
                        {
                            sum += Math.Abs(num);
                        }
                    }
                    else
                    {
                        foreach (int num in nums)
                        {
                            sum += Math.Abs(num);
                        }

                        int sub = 0;

                        if (smallestNegative.HasValue && firstPositive.HasValue)
                            sub = Math.Min(Math.Abs(smallestNegative.Value), firstPositive.Value);
                        else if (smallestNegative.HasValue)
                            sub = Math.Abs(smallestNegative.Value);
                        else
                            sub = firstPositive.Value;

                        sum -= 2 * sub;
                    }
                }

            }
            return sum;
        }
    }
}
