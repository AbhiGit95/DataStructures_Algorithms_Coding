using System;
using System.Collections.Generic;
using System.Text;

namespace Comp_Coding
{
    class KnapSack
    {
        /**
         * @method - Knapsack_recursive : Recursive approach to solve Knapsack Problem
         * @arguments - int[] val : Integer Array containing the value of items
         * int[] w_arr - Integer Array containing the weights of the items.
         * int W - Integer capacity of the Knapsack
         * int n - Number of items to select from
         */
        public int Knapsack_recursive(int[] val, int[] w_arr, int W, int n)
        {
            if (n == 0 || W == 0)
                return 0;

            if (w_arr[n - 1] <= W)
                return Math.Max(val[n - 1] + Knapsack_recursive(val, w_arr, W - w_arr[n - 1], n - 1), Knapsack_recursive(val, w_arr, W, n - 1));

            else
                return Knapsack_recursive(val, w_arr, W, n - 1);
        }

        public int Knapsack_memoized(int[] val, int[] w_arr, int W, int n)
        {
            int[][] mem = new int[n+1][];
            for(int i = 0; i <= n; i++)
            {
                mem[i] = new int[W + 1];
                Array.Fill(mem[i], -1);
            }
            return Knapsack_memoizedhelper(val, w_arr, W, n, mem);
        }

        /*
         * Memoization used in Knapsack
         */
        public int Knapsack_memoizedhelper(int[] val, int[] w_arr, int W, int n, int[][]mem)
        {
            if (n == 0 || W == 0)
                return 0;

            else if (mem[n][W] != -1)
                return mem[n][W];

            else if(w_arr[n-1] <= W)
                return mem[n][W] = Math.Max(val[n - 1] + Knapsack_recursive(val, w_arr, W - w_arr[n - 1], n - 1), Knapsack_recursive(val, w_arr, W, n - 1));
            else
                return mem[n][W] = Math.Max(val[n - 1] + Knapsack_recursive(val, w_arr, W - w_arr[n - 1], n - 1), Knapsack_recursive(val, w_arr, W, n - 1));
        }

        /*
         * Bottom Up approach of KnapSack.
         */
        public int Knapsack_bottomUp(int[] val, int[] w_arr, int W, int n)
        {
            int[][] dp = new int[n + 1][];
            for (int i = 0; i <= n; i++)
            {
                dp[i] = new int[W + 1];
            }

            Array.Fill(dp[0], 0);
            for(int i = 0; i <=n; i++)
            {
                dp[i][0] = 0;
            }

            for(int i = 1; i < n+1; i++)
            {
                for(int j = 1; j < W + 1; j++)
                {
                    if(w_arr[i-1] <= j)
                    {
                        dp[i][j] = Math.Max(val[i - 1] + dp[i - 1][j - w_arr[i - 1]], dp[i - 1][j]);
                    }
                    else
                    {
                        dp[i][j] = dp[i - 1][j];
                    }
                }
            }

            return dp[n][W];
        }
    }
}
