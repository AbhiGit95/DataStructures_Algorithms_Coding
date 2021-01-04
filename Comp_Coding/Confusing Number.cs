using System;
using System.Collections.Generic;
using System.Text;

namespace Comp_Coding
{
    class Confusing_Number
    {
        public bool ConfusingNumber(int N)
        {
            Dictionary<int, int> confusing_Set = new Dictionary<int, int>();
            confusing_Set.Add(1, 1); confusing_Set.Add(0, 0); confusing_Set.Add(6, 9); confusing_Set.Add(9, 6); confusing_Set.Add(8, 8);
            int temp = N; int rev_N = 0;
            while (temp > 0)
            {
                if (confusing_Set.ContainsKey(temp % 10))
                {
                    rev_N = rev_N * 10 + confusing_Set[(temp % 10)];
                    temp /= 10;
                }

                else
                    return false;
            }

            return rev_N != N;
        }
    }
}
