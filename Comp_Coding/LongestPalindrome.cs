using System;
using System.Collections.Generic;
using System.Text;

namespace Comp_Coding
{
    class LongestPalindrome
    {
        public int LongestPalindrome_func(string s)
        {
            Dictionary<char, int> map = new Dictionary<char, int>();

            foreach (char c in s)
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

            int result = 0; int max_odd = 0;

            foreach (KeyValuePair<char, int> kv in map)
            {
                if (kv.Value % 2 != 0)
                {
                    result += kv.Value - 1;
                    max_odd = Math.Max(max_odd, kv.Value);
                }
                else
                {
                    result += kv.Value;
                }
                //    Console.WriteLine("Character : {0} and Occurrence : {1}", kv.Key, kv.Value);
            }

            if (max_odd != 0)
            {
                result += 1;
            }
            // Console.WriteLine("Max_value for odd :{0} ", max_odd);
            return result;
        }
    }
}
