using System;
using System.Collections.Generic;
using System.Text;

namespace Comp_Coding
{
    class CountUnhappyFriends
    {
        HashSet<int> visited;
        public int UnhappyFriends(int n, int[][] preferences, int[][] pairs)
        {
            int res = 0;

            visited = new HashSet<int>();

            Dictionary<int, int> map = new Dictionary<int, int>();

            HashSet<int> friends = new HashSet<int>();

            foreach (int[] a in pairs)
            {
                friends.Add(a[0]);
                friends.Add(a[1]);

                map.Add(a[0], a[1]);
                map.Add(a[1], a[0]);
            }

            foreach (int[] p in pairs)
            {

                int f1 = p[0];
                int f2 = p[1];

                if (!visited.Contains(f1))
                    res += prefNumber(preferences, f1, f2, friends, map);

                if (!visited.Contains(f2))
                    res += prefNumber(preferences, f2, f1, friends, map);
            }
            return res;
        }

        public int prefNumber(int[][] preferences, int f1, int f2, HashSet<int> friends, Dictionary<int, int> map)
        {
            var pref = preferences[f1];
            visited.Add(f1);

            int result = 0;

            for (int i = 0; i < pref.Length; i++)
            {
                if (friends.Contains(pref[i]) && pref[i] == f2)
                    return 0;

                else if (friends.Contains(pref[i]) && pref[i] != f2)
                {
                    visited.Add(pref[i]);
                    if (NotHappy(preferences[pref[i]], friends, f1, map[pref[i]]))
                        result += 2;
                }
            }
            return result;
        }

        public bool NotHappy(int[] pref, HashSet<int> friends, int f1, int f3)
        {

            for (int i = 0; i < pref.Length; i++)
            {
                if (friends.Contains(pref[i]) && pref[i] == f1)
                    return true;
                else if (friends.Contains(pref[i]) && pref[i] == f3)
                    return false;
            }

            return false;
        }
    }
}
