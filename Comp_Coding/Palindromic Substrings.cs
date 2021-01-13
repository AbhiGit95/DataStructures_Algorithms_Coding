using System;
using System.Collections.Generic;
using System.Text;

namespace Comp_Coding
{
    class Palindromic_Substrings
    {
        public int CountSubstrings(string s)
        {
            int n = s.Length;
            int res = 0;

            if (n == 0)
                return 0;

            bool[][] dp = new bool[n][];

            // single characters are palindromes
            for(int i = 0; i < n; i++)
            {
                dp[i] = new bool[n];
                dp[i][i] = true;
                res += 1;
            }

            // 2 character substrings are palindrome only if both the characters are equal.
            for(int i = 1; i < n; i++)
            {
                if(s[i].Equals(s[i-1]))
                {
                    dp[i-1][i] = true;
                    res += 1;
                }
            }

            // Now checking for 3 length substrings and onwards

            for(int i = 3; i <= n; i++)
            {
                for(int j = 0, k = i + j - 1; k < n; k++, j++ )
                {
                    dp[j][k] = dp[j + 1][k - 1] && s[j].Equals(s[k]);
                    if (dp[j][k])
                        res += 1;
                }
            }

            return res;
        }
    }
}
