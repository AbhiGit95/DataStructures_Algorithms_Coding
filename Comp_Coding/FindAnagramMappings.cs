using System;
using System.Collections.Generic;
using System.Text;

namespace Comp_Coding
{
    class FindAnagramMappings
    {
        public int[] AnagramMappings(int[] A, int[] B)
        {
            Dictionary<int, List<int>> map = new Dictionary<int, List<int>>();
            for (int i = 0; i < B.Length; i++)
            {
                if (map.ContainsKey(B[i]))
                {
                    map[B[i]].Add(i);
                }
                else
                {
                    map.Add(B[i], new List<int>() { i });
                }
            }

            int[] P = new int[A.Length];
            int index = 0;
            foreach (int a in A)
            {
                if (map.ContainsKey(a))
                {
                    if (map[a].Count > 1)
                    {
                        P[index] = map[a][0];
                        map[a].RemoveAt(0);
                    }
                    else
                    {
                        P[index] = map[a][0];
                        map.Remove(a);
                    }
                }
                index += 1;
            }
            return P;
        }
    }
}
