using System;
using System.Collections.Generic;
using System.Text;

namespace Comp_Coding
{
    class Palindrome_Permutation
    {
        public bool CanPermutePalindrome(string s)
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

            int odd_count = 0;

            foreach (char c in map.Keys)
            {
                if (map[c] % 2 != 0)
                    odd_count += 1;
                if (odd_count > 1)
                    return false;
            }

            return true;
        }
    }
}
