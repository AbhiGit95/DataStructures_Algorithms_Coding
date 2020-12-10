using System;
using System.Collections.Generic;
using System.Text;

namespace Comp_Coding
{
    class SplitaStringinBalancedStrings
    {
        public int BalancedStringSplit(string s)
        {
            int L = 0; int R = 0; int count = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'L')
                    L++;
                else
                    R++;

                if (L == R)
                {
                    count += 1;
                    L = 0; R = 0;
                }

            }
            return count;
        }
    }
}
