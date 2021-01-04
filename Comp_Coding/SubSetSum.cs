using System;
using System.Collections.Generic;
using System.Text;

namespace Comp_Coding
{
    class SubSetSum
    {
        public bool SubSetSum_Recursive(int[] nums, int S, int n)
        {
            if (S == 0)
                return true;

            else if (n == 0)
                return false;

            if (nums[n - 1] <= S)
            {
                return SubSetSum_Recursive(nums, S - nums[n - 1], n - 1) || SubSetSum_Recursive(nums, S, n - 1);
            }

            else
                return SubSetSum_Recursive(nums, S, n - 1);
        }

        public bool SubSetSum_BottomUp(int[] nums, int S)
        {
            int n = nums.Length;
            bool[][] mat = new bool[n + 1][];

            for(int i = 0; i < n + 1; i++)
            {
                mat[i] = new bool[S + 1];
            }

            for(int i = 0; i < n+1; i++)
            {
                mat[i][0] = true;
            }

            for(int i = 1; i < n+1; i++)
            {
                for(int j = 1; j < S + 1; j++)
                {
                    if(nums[i-1] <= j)
                    {
                        mat[i][j] = mat[i - 1][j - nums[i - 1]] || mat[i - 1][j];
                    }
                    else
                    {
                        mat[i][j] = mat[i - 1][j];
                    }
                }
            }

            return mat[n][S];
            
        }
    }
}
