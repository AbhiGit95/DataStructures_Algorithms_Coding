using System;
using System.Collections.Generic;
using System.Text;

namespace Comp_Coding
{
    class Valid_Word_Square
    {
        public bool ValidWordSquare(IList<string> words)
        {
            int n = words.Count;
            int start = 0;

            for (int i = 0; i < n; i++)
            {
                // if(start > words[i].Length)
                //     return false;

                for (int j = start; j < words[i].Length; j++)
                {
                    char c1 = words[i][j];
                    //if(j > n)
                    //char c2 = words[j][i];

                    //if (c1 != c2)
                    //    return false;
                }

                start += 1;
            }

            return true;
        }
    }
}
