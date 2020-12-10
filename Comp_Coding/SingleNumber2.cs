using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Comp_Coding
{
    class SingleNumber2
    {
        //using Dictionary
        public int SingleNumber(int[] nums)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (map.ContainsKey(nums[i]))
                {
                    map[nums[i]] += 1;
                    if (map[nums[i]] == 3)
                        map.Remove(nums[i]);
                }
                else
                {
                    map.Add(nums[i], 1);
                }
            }
            return map.Keys.First();
        }
    }
}
