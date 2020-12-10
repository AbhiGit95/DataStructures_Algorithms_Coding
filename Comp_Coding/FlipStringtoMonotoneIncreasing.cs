using System;
using System.Collections.Generic;
using System.Text;

namespace Comp_Coding
{
    class FlipStringtoMonotoneIncreasing
    {
        public int MinFlipsMonoIncr(string S)
        {
            int zero = 0; int one = 0;
            int zero_start = S.IndexOf('0');
            int zero_end = S.LastIndexOf('0');
            int one_start = S.IndexOf('1');

            if (zero_start == -1 || one_start == -1)
                return 0;

            if (zero_start == zero_end && zero_end > one_start)
                return 1;
            if (one_start == S.Length - 1)
                return 0;

            for (int i = zero_start; i <= zero_end; i++)
            {
                if (S[i] == '1')
                    one += 1;
            }

            for(int i = one_start; i < S.Length; i++)
            {
                if (S[i] == '0')
                    zero += 1;
            }

            return Math.Min(one, zero);
        }
    }
}
