using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Comp_Coding
{
    class Least_Number_of_Unique_Integers_after_K_Removals
    {
        public int FindLeastNumOfUniqueInts(int[] arr, int k)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();
           

            foreach (int n in arr)
            {
                if (map.ContainsKey(n))
                    map[n] += 1;
                else
                    map.Add(n, 1);
            }

            var result = 0;

           foreach(KeyValuePair<int,int> kv in map.OrderBy(x => x.Value))
           {
                if (k > 0)
                {
                    if (k < kv.Value)
                        result += 1;
                    k -= kv.Value;
                }
                else
                    result += 1;
           }
            

            return result;
        }
    }
}
