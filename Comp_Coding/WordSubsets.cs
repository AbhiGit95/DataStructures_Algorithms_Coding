using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Comp_Coding
{
    class WordSubsets
    {
        //Naive method
        public IList<string> WordSubsets_f(string[] A, string[] B)
        {
            IList<string> result = new List<String>();

            int[] B_map = new int[26];

            foreach(string s in B)
            {
                int[] temp = char_map(s);
                for(int i = 0; i < 26; i++)
                {
                    B_map[i] = Math.Max(temp[i], B_map[i]);
                }
            }

            foreach(string s in A)
            {
                int[] temp = char_map(s); bool flag = true;
                for(int i = 0; i < 26; i++)
                {
                    if(B_map[i] > temp[i])
                    {
                        flag = false; break;
                    }
                }
                if (flag)
                    result.Add(s);
            }

            return result;
        }

        public int[] char_map(String S)
        {
            int[] res = new int[26];
            foreach(char c in S)
            {
                res[c - 'a'] += 1;
            }
            return res;
        }
    }
}
