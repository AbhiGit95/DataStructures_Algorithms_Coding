using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Comp_Coding
{
    class Reduce_Array_Size_to_The_Half
    {
        public int MinSetSize(int[] arr)
        {
            int limit = arr.Length / 2;
            Dictionary<int, int> map = new Dictionary<int, int>();
            foreach (int a in arr)
            {
                if (map.ContainsKey(a))
                    map[a] += 1;
                else
                    map.Add(a, 1);
            }

            int count = 0;
            foreach (KeyValuePair<int, int> kv in map.OrderByDescending(x => x.Value))
            {
                limit -= kv.Value;
                count += 1;
                if (limit <= 0)
                    break;
            }
            return count;
        }
    }
}
