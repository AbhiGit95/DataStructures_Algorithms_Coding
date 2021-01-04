using System;
using System.Collections.Generic;
using System.Text;

namespace Comp_Coding
{
    class Check_Array_Formation_Through_Concatenation
    {
        public bool CanFormArray(int[] arr, int[][] pieces)
        {
            Dictionary<int, int> map_arr = new Dictionary<int, int>();
            Dictionary<int, int> rev_map = new Dictionary<int, int>();
            HashSet<int> set = new HashSet<int>();

            for (int i = 0; i < arr.Length; i++)
            {
                map_arr.Add(arr[i], i);
                rev_map.Add(i, arr[i]);
            }

            foreach (int[] m in pieces)
            {
                for (int a = 0; a < m.Length; a++)
                {
                    set.Add(m[a]);
                }
            }

            foreach (int[] l in pieces)
            {
                for (int a = 1; a < l.Length; a++)
                {
                    if (map_arr.ContainsKey(l[a]) && map_arr.ContainsKey(l[a - 1]))
                    {
                        if (map_arr[l[a]] < map_arr[l[a - 1]])
                            return false;

                        else if (rev_map.ContainsKey(map_arr[l[a - 1]] + 1) && rev_map[map_arr[l[a - 1]] + 1] != l[a])
                            return false;
                    }
                }
            }

            foreach (KeyValuePair<int,int> kv in map_arr)
            {
                if (!set.Contains(kv.Key))
                    return false;
            }
                return true;
        }
    }
}
