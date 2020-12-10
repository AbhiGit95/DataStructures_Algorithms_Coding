using System;
using System.Collections.Generic;
using System.Text;

namespace Comp_Coding
{
    class SingleNumberIII
    {
        // using Dictionary
        public int[] SingleNumber(int[] nums)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (map.ContainsKey(nums[i]))
                {
                    map.Remove(nums[i]);
                }
                else
                {
                    map.Add(nums[i], 1);
                }
            }
            int[] result = new int[2]; int k = 0;
            foreach (KeyValuePair<int, int> kv in map)
            {
                result[k] = kv.Key;
                k += 1;
            }

            return result;
        }
    }
}
