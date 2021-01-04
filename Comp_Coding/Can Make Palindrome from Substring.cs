using System;
using System.Collections.Generic;
using System.Text;

namespace Comp_Coding
{
    class Can_Make_Palindrome_from_Substring
    {
        // TLE solution
        public IList<bool> CanMakePaliQueries(string s, int[][] queries)
        {
            IList<bool> result = new List<bool>();
            Dictionary<char, int> map = new Dictionary<char, int>();
            foreach (char c in s)
            {
                if (map.ContainsKey(c))
                    map[c] += 1;
                else
                    map.Add(c, 1);
            }
            foreach (int[] q in queries)
            {
                result.Add(canmakePalindrome(s.Substring(q[0], q[1] - q[0] + 1), q[2], map));
            }
            return result;
        }

        public bool canmakePalindrome(string s, int replace, Dictionary<char, int> map)
        {
            
            int odd_Count = 0;
            foreach(char c in map.Keys)
            {
                if (map[c] % 2 != 0)
                    odd_Count += 1;
            }

            return odd_Count == 0 || odd_Count - (replace * 2) <= 1;
        }
    }
}
