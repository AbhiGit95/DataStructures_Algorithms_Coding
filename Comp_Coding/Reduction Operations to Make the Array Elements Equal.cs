using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Comp_Coding
{
    class Reduction_Operations_to_Make_the_Array_Elements_Equal
    {
        public int ReductionOperations(int[] nums)
        {
            SortedDictionary<int, int> map = new SortedDictionary<int, int>();

            foreach (int n in nums)
            {
                if (map.ContainsKey(n))
                    map[n] += 1;
                else
                    map.Add(n, 1);
            }

            Stack<int> stack = new Stack<int>();

            foreach(int k in map.Keys)
            {
                stack.Push(k);
            }

            int count = 0;
            int currentMax = 0; int nextMax = 0;

            while(stack.Count > 1)
            {
                currentMax = stack.Pop();
                nextMax = stack.Peek();
                count += Steps(map, nextMax, currentMax);
            }
            return count;
        }

        public int Steps(SortedDictionary<int,int> map, int nextMax, int currentMax)
        {
            int count = 0;
            count += map[currentMax];
            map.Remove(currentMax);
            map[nextMax] += count;
            return count;
        }
    }
}
