using System;
using System.Collections.Generic;
using System.Text;

namespace Comp_Coding
{
    class LongestPalindromicSubstring
    {
        //using Longest Common Substring
        public string LongestPalindrome(string s)
        {
            char[] c = s.ToCharArray();
            StringBuilder sb = new StringBuilder();
            for(int i = c.Length - 1; i >= 0; i--)
            {
                sb.Append(c[i]);
            }

            string rev = sb.ToString();

            int[][] dp = new int[s.Length + 1][];
            for(int i = 0; i < dp.Length; i++)
            {
                dp[i] = new int[s.Length + 1];
            }

            for(int i = 0; i <= s.Length; i++)
            {
                for (int j = 0; j <= s.Length; j++)
                {
                    if(i == 0 || j == 0)
                    {
                        dp[i][j] = 0;
                    }
                }
            }

            int[] index = new int[2]; 
            int max = 0;
            string result = ";";
            for(int i = 1; i <= s.Length; i++)
            {
                for(int j = 1; j <= s.Length; j++)
                {
                    if(s[i-1].Equals(rev[j-1]))
                    {
                        dp[i][j] = dp[i - 1][j - 1] + 1;
                        if(dp[i][j] > max)
                        {
                          
                                string a = s.Substring(i - dp[i][j], dp[i][j]);
                                char[] b = a.ToCharArray(); Array.Reverse(b);
                                string a_rev = new string(b);

                                if(a.Equals(a_rev))
                                {
                                    max = dp[i][j];
                                    result = a;
                                    index[0] = i; index[1] = j;
                                }
                        }
                    }
                    else
                    {
                        dp[i][j] = 0;
                    }
                }
            }
            return result;
        }

        // 2. Using Middle Out Expansion

        public string LongestPalindrome2(string s)
        {
            if (s == null || s.Length == 0)
                return "";

            int start = 0; int end = 0;
            for(int i = 0; i < s.Length; i++)
            {
                int len1 = expand(i, i, s);
                int len2 = expand(i, i + 1, s);
                int len = Math.Max(len1, len2);
                if(len > end - start)
                {
                    start = i - ((len - 1) / 2);
                    end = i + (len / 2);
                }
            }

            return s.Substring(start, end - start + 1);
        }

        public int expand(int left, int right, string s )
        {
            while (left >= 0 && right < s.Length && s[left].Equals(s[right]))
            {
                left--; right++;
            }

            return right - left - 1;
        }
    }
}
