using System;
using System.Collections.Generic;
using System.Text;

namespace Comp_Coding
{
    class High_Five
    {
        public int[][] HighFive(int[][] items)
        {
            SortedDictionary<int, List<int>> map = new SortedDictionary<int, List<int>>();

            foreach (int[] a in items)
            {
                if (map.ContainsKey(a[0]))
                {
                    map[a[0]].Add(a[1]);
                }
                else
                {
                    map.Add(a[0], new List<int>() { a[1] });
                }
            }

            int[][] result = new int[map.Count][];
            int count = 0;
            foreach (int kv in map.Keys)
            {
                result[count] = new int[2];
                int sum = 0;
                int flag = 0;
                map[kv].Sort();
                for (int j = map[kv].Count - 1; j >= 0; j--)
                {
                    sum += map[kv][j];
                    flag++;
                    if (flag == 5)
                        break;
                }

                result[count][0] = kv;
                result[count][1] = sum / 5;
                count += 1;
            }
            return result;
        }
    }
}
