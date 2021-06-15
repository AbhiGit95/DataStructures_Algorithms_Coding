using System;
using System.Collections.Generic;
using System.Text;

namespace Comp_Coding
{
    class Repeated_Substring_Pattern
    {
        public bool RepeatedSubstringPattern(string s)
        {
            int n = s.Length;
            for (int i = n / 2; i > 0; i--)
            {
                if (n % i == 0)
                {
                    var repeat = n / i;
                    if (check(s.Substring(0, i), s, repeat))
                        return true;
                }
            }
            return false;
        }

        public bool check(string a, string b, int count)
        {
            int start = 0;
            StringBuilder sb = new StringBuilder();

            while (start <= count)
            {
                sb.Append(a);

                // if (sb.Length > b.Length)
                //     return false;

                if (sb.Length == b.Length)
                {
                    if (sb.ToString().Equals(b))
                        return true;

                    return false;
                }

                start++;
            }

            return sb.ToString().Contains(b);
        }
    }
}

