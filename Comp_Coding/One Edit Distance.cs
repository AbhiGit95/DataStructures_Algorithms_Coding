using System;
using System.Collections.Generic;
using System.Text;

namespace Comp_Coding
{
    class One_Edit_Distance
    {
        public bool IsOneEditDistance(string s, string t)
        {
            if ((s.Length == 0 && t.Length == 0) || (s == "" && t == ""))
                return false;

            if (s.Length == t.Length)
                return replace(s, t);
            else if (s.Length + 1 == t.Length)
                return edit(s, t);
            else if (s.Length - 1 == t.Length)
                return edit(t, s);
            else
                return false;
        }

        public bool replace(string s, string t)
        {
            int count = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != t[i])
                {
                    count += 1;
                }

                if (count >= 2)
                    return false;
            }
            return count == 1 ? true : false;
        }

        public bool edit(string a, string b)
        {
            int i = 0; int j = 0;
            while (i < a.Length && j < b.Length)
            {
                if (a[i] != b[j])
                {
                    if (i != j)
                        return false;
                    j++;
                }
                else
                {
                    i++; j++;
                }
            }
            return true;
        }
    }
}
