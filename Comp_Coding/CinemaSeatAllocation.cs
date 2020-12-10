using System;
using System.Collections.Generic;
using System.Text;

namespace Comp_Coding
{
    class CinemaSeatAllocation
    {
        public int MaxNumberOfFamilies(int n, int[][] reservedSeats)
        {
            SortedDictionary<int, HashSet<int>> map = new SortedDictionary<int, HashSet<int>>();

            for (int i = 0; i < reservedSeats.Length; i++)
            {
                if (map.ContainsKey(reservedSeats[i][0]))
                {
                    map[reservedSeats[i][0]].Add(reservedSeats[i][1]);
                }
                else
                {
                    map.Add(reservedSeats[i][0], new HashSet<int>() { reservedSeats[i][1] });
                }
            }

            int count = 0;
            int start = 1;
            foreach(KeyValuePair<int,HashSet<int>> kv in map)
            {
                count += (kv.Key - start) * 2;
                start = kv.Key + 1;

                    int count1 = 1; int count2 = 1; int count3 = 1;
                    for (int j = 2; j <= 5; j++)
                    {
                        if (map[kv.Key].Contains(j))
                        {
                            count1 = 0; break;
                        }
                    }

                    for (int j = 4; j <= 7; j++)
                    {
                        if (map[kv.Key].Contains(j))
                        {
                            count2 = 0; break;
                        }
                    }

                    for (int j = 6; j <= 9; j++)
                    {
                        if (map[kv.Key].Contains(j))
                        {
                            count3 = 0; break;
                        }
                    }
                    count += Math.Max(count2, count1 + count3);
            }
            count += Math.Max(0, n + 1 - start) * 2;
            return count;
        }
    }
}
