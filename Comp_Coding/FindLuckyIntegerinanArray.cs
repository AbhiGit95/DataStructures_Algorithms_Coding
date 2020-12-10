using System;
using System.Collections.Generic;
using System.Text;

namespace Comp_Coding
{
    class FindLuckyIntegerinanArray
    {
        public int FindLucky(int[] arr)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (map.ContainsKey(arr[i]))
                    map[arr[i]] += 1;
                else
                    map.Add(arr[i], 1);
            }
            int result = -1;
            foreach (KeyValuePair<int, int> kv in map)
            {
                if (kv.Key == kv.Value)
                    result = Math.Max(result, kv.Key);
            }
            return result;
        }

    }
}
