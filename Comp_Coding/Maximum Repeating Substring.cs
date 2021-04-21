using System;
using System.Collections.Generic;
using System.Text;

namespace Comp_Coding
{
    class Maximum_Repeating_Substring
    {
        public int MaxRepeating(string sequence, string word)
        {
            string temp = word;
            int res = 0;

            while(sequence.Contains(temp))
            {
                res++;
                temp = temp + word;
            }

            return res;
        }
    }
}
