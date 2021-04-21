using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Comp_Coding
{
    class Maximum_Number_of_Occurrences_of_a_Substring
    {
        public int MaxFreq(string s, int maxLetters, int minSize, int maxSize)
        {
            int[] char_map = new int[26];

            for(int i = 0; i < minSize; i++)
            {
                char_map[s[i] - 'a']++;
            }

            Dictionary<string, int> map = new Dictionary<string, int>();

            if (check_constraint(maxLetters, char_map))
                map.Add(s.Substring(0, minSize), 1);

            int n = s.Length;
            int start = 0;
            while(start < n - minSize)
            {
                char_map[s[start] - 'a']--;
                char_map[s[start + minSize] - 'a']++;

                if(check_constraint(maxLetters, char_map))
                {
                    string sub = s.Substring(start+1, minSize);
                    if (map.ContainsKey(sub))
                        map[sub]++;
                    else
                        map.Add(sub, 1);
                }
                start++;
            }

            return map.Count == 0 ? 0 : map.Values.Max();
        }

        public bool check_constraint(int maxLetters, int[] char_map)
        {
            int count = 0;

            for(int i = 0; i < 26; i++)
            {
                if (char_map[i] >= 1)
                    count++;
            }

            return count <= maxLetters ? true : false;
        }
    }
}
