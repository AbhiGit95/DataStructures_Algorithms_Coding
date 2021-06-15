using System;
using System.Collections.Generic;
using System.Text;

namespace Comp_Coding
{
    class Repeated_String_Match
    {
        public int RepeatedStringMatch(string a, string b)
        {
            if (a.Equals(b))
                return 1;

            Dictionary<char, int> map_b = new Dictionary<char, int>();
            Dictionary<char, int> map_a = new Dictionary<char, int>();

            foreach (char c in b)
            {
                if (map_b.ContainsKey(c))
                {
                    map_b[c] += 1;
                }

                else
                    map_b.Add(c, 1);
            }

            foreach (char d in a)
            {
                if (map_a.ContainsKey(d))
                {
                    map_a[d] += 1;
                }

                else
                    map_a.Add(d, 1);
            }

            if (map_a.Count < map_b.Count)
                return -1;

            int min_repeat = 0;
            foreach (char k in map_a.Keys)
            {
                if (!map_b.ContainsKey(k))
                    return -1;

                if (map_b[k] > map_a[k])
                {
                    min_repeat = Math.Max(map_b[k] - map_a[k], min_repeat);
                }
            }

            int i = 1;
            StringBuilder sb = new StringBuilder();
            sb.Append(a);
            while (i <= min_repeat)
            {
                sb.Append(a);
                i++;
            }

            string s = sb.ToString();

            if (s.Contains(b))
                return min_repeat + 1;
            return -1;
        }
    }
}
