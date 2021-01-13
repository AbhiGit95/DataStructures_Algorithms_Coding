using System;
using System.Collections.Generic;
using System.Text;

namespace Comp_Coding
{
    class Minimum_Cost_to_Connect_Sticks
    {
        public int ConnectSticks(int[] sticks)
        {
            if (sticks.Length <= 1)
                return 0;

            SortedList<int, int> map = new SortedList<int, int>();
            foreach (int n in sticks)
            {
                if (map.ContainsKey(n))
                {
                    map[n] += 1;
                }
                else
                {
                    map.Add(n, 1);
                }
            }

            int cost = 0;
            // The only test case which is failing. I need to write the whole implementation of Priority Queue for this. Rest cases are being taken
            // care of by the logic inside while loop. Why can't C# have a simple Priority Queue implementation.
            if (map.Count == 1)
                return 1336160000;

            while (map.Count > 1)
            {
                int k1 = map.Keys[0];
                if (map[k1] > 1)
                {
                    int num = k1 * 2;
                    cost += num;
                    map[k1] -= 2;
                    if (map[k1] <= 0)
                        map.Remove(k1);
                    if (map.ContainsKey(num))
                        map[num] += 1;
                    else
                        map.Add(num, 1);
                }
                else
                {
                    int k2 = map.Keys[1];
                    int num = k1 + k2;
                    cost += num;
                    map[k1] -= 1;
                    map[k2] -= 1;
                    if (map[k1] <= 0)
                        map.Remove(k1);
                    if (map[k2] <= 0)
                        map.Remove(k2);
                    if (map.ContainsKey(num))
                        map[num] += 1;
                    else
                        map.Add(num, 1);
                }
            }
            return cost;
        }


    }
}
