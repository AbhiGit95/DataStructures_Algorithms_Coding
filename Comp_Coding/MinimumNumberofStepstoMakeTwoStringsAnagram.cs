using System;
using System.Collections.Generic;
using System.Text;

namespace Comp_Coding
{
    class MinimumNumberofStepstoMakeTwoStringsAnagram
    {
        public int MinSteps(string s, string t)
        {
            Dictionary<char, int> map = new Dictionary<char, int>();
            foreach (char c in t)
            {
                if (map.ContainsKey(c))
                {
                    map[c] += 1;
                }
                else
                {
                    map.Add(c, 1);
                }
            }

            foreach (char c in s)
            {
                if (map.ContainsKey(c))
                {
                    if (map[c] == 1)
                        map.Remove(c);
                    else
                        map[c] -= 1;
                }
            }

            int result = 0;
            foreach(KeyValuePair<char,int> kv in map)
            {
                result += kv.Value;
            }
            return result;
        }
    }
}
