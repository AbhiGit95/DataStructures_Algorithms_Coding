using System;
using System.Collections.Generic;
using System.Text;

namespace Comp_Coding
{
    class CountOfSubsetSumsWithGivenSum
    {
        public int countOfSubsetSum_recursive(int[]nums, int S, int n)
        {
            if (S == 0)
                return 1;
            else if (n == 0 && S != 0)
                return 0;

            if (nums[n - 1] <= S)
            {
                return (countOfSubsetSum_recursive(nums, S - nums[n - 1], n - 1) + countOfSubsetSum_recursive(nums, S, n - 1));
            }
            else
                return countOfSubsetSum_recursive(nums, S, n - 1);
        }

        public int countOfSubsetSum_bottomup(int[]nums, int S, int n)
        {
            int[][] dp = new int[n + 1][];
            for(int i = 0; i < n + 1; i++)
            {
                dp[i] = new int[S + 1];
            }

            for(int i = 0; i < n + 1; i++)
            {
                dp[i][0] = 1; 
            }

            for(int i = 1; i < n + 1; i++)
            {
                for(int j = 1; j < S + 1; j++)
                {
                    if(nums[i-1] <= j)
                    {
                        dp[i][j] = dp[i - 1][j] + dp[i - 1][j - nums[i - 1]];
                    }
                    else
                    {
                        dp[i][j] = dp[i - 1][j];
                    }
                }
            }

            return dp[n][S];
        }

    }
}
