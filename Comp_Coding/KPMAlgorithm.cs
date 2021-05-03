using System;
using System.Collections.Generic;
using System.Text;

namespace Comp_Coding
{
    class KPMAlgorithm
    {

        public bool KMP_SubstringSearch(string text, string pattern)
        {
            int[] lps = GetPrefixArray(pattern);

            int n = lps.Length; int m = text.Length;

            int i = 0; int j = 0;

            while(i < m && j < n)
            {
                if(text[i] == pattern[j])
                {
                    i++;
                    j++;
                }
                else
                {
                    if( j != 0)
                    {
                        j = lps[j - 1];
                    }
                    else
                    {
                        i++;
                    }
                }
            }

            return j == n;
        }

        public int[] GetPrefixArray(string pattern)
        {
            int i = 1; int j = 0;
            int n = pattern.Length;
            int[] result = new int[n];
            result[0] = 0;

            while(i < n)
            {
                if(pattern[i] == pattern[j])
                {
                    result[i] = result[j] + 1;
                    i++; j++;
                }

                else
                {
                    if( j != 0)
                    {
                        j = result[i - 1];
                    }
                    else
                    {
                        result[i] = 0;
                        i++;
                    }
                }
            }
            return result;
        }

    }
}
