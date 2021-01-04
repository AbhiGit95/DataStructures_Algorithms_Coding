using System;
using System.Collections.Generic;
using System.Text;

namespace Comp_Coding
{
    class Two_Sum_III___Data_structure_design
    {
        /** Initialize your data structure here. */
        Dictionary<int, int> map;
        public Two_Sum_III___Data_structure_design()
        {
            map = new Dictionary<int, int>();
        }

        /** Add the number to an internal data structure.. */
        public void Add(int number)
        {
            if (map.ContainsKey(number))
            {
                map[number] += 1;
            }
            else
            {
                map.Add(number, 1);
            }
        }

        /** Find if there exists any pair of numbers which sum is equal to the value. */
        public bool Find(int value)
        {
            foreach (int k in map.Keys)
            {
                if (map.ContainsKey(value - k))
                {
                    int temp = value - k;
                    if (temp == k)
                    {
                        if (map[k] > 1)
                            return true;
                    }
                    else
                        return true;
                }

            }
            return false;
        }
    }
}
