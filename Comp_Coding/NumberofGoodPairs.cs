using System;
using System.Collections.Generic;
using System.Text;

namespace Comp_Coding
{
    class NumberofGoodPairs
    {
        public int NumIdenticalPairs(int[] nums)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (map.ContainsKey(nums[i]))
                {
                    map[nums[i]] += 1;
                }
                else
                {
                    map.Add(nums[i], 1);
                }
            }

            int pairs = 0;
            foreach (KeyValuePair<int, int> kv in map)
            {
                if (kv.Value > 1)
                {
                    pairs += (kv.Value * (kv.Value - 1)) / 2; ;
                }
            }
            return pairs;
        }
    }
}
