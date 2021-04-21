using System;
using System.Collections.Generic;
using System.Text;

namespace Comp_Coding
{
    class Meeting_Scheduler
    {
        public IList<int> MinAvailableDuration(int[][] slots1, int[][] slots2, int duration)
        {
            Array.Sort(slots1, new starttimecomparer());
            Array.Sort(slots2, new starttimecomparer());

            /*
             * Possible Cases : 
             * 1) The slots do not intersect, then do nothing.
             * 2) The slots intersect and check if that intersection is as large as the duration.
             * 3) Slots are nested in one another and check if the nested slot is as large as the duration.
             */

            int a = slots1.Length; int b = slots2.Length;
            IList<int> result = new List<int>();
            int start1 = 0; int start2 = 0;
            
            while(start1 < a && start2 < b)
            {
                //if no intersection move the pointer with lower end time among the both ahead
                if(slots1[start1][1] <= slots2[start2][0]) 
                {
                    start1 += 1;
                }
                else if(slots2[start2][1] <= slots1[start1][0])
                {
                    start2 += 1;
                }
                //check for nested intervals
                //If slot1 is nested in slot2
                else if (slots1[start1][0] >= slots2[start2][0] && slots1[start1][1] <= slots2[start2][1])
                {
                    if (slots1[start1][1] - slots1[start1][0] >= duration)
                    {
                        result.Add(slots1[start1][0]);
                        result.Add(slots1[start1][0] + duration);
                        break;
                    }
                    start1 += 1;
                }
                //If slot2 is nested in slot1
                else if (slots2[start2][0] >= slots1[start1][0] && slots2[start2][1] <= slots1[start1][1])
                {
                    if (slots2[start2][1] - slots2[start2][0] >= duration)
                    {
                        result.Add(slots2[start2][0]);
                        result.Add(slots2[start2][0] + duration);
                        break;
                    }
                    start2 += 1;
                }

                //check for some amount of intersection
                //when slot1 partially intersects with slot2 : here slot1 starts before slot2
                else if(slots1[start1][0] < slots2[start2][0] && slots1[start1][1] > slots2[start2][0] && slots1[start1][1] < slots2[start2][1])
                {
                    if(slots1[start1][1] - slots2[start2][0] >= duration)
                    {
                        result.Add(slots2[start2][0]);
                        result.Add(slots2[start2][0] + duration);
                        break;
                    }
                    start1 += 1;
                }
                //when slot2 partially intersects with slot1 : here slot2 starts before slot1
                else if (slots2[start2][0] < slots1[start1][0] && slots2[start2][1] > slots1[start1][0] && slots2[start2][1] < slots1[start1][1])
                {
                    if (slots2[start2][1] - slots1[start1][0] >= duration)
                    {
                        result.Add(slots1[start1][0]);
                        result.Add(slots1[start1][0] + duration);
                        break;
                    }
                    start2 += 1;
                }

            }
            return result;
        }

        public class starttimecomparer : IComparer<int[]>
        {
            public int Compare(int[]x, int[]y)
            {
                if (x[0] < y[0])
                    return -1;
                else if (x[0] > y[0])
                    return 1;
                else
                    return x[1].CompareTo(y[1]);
            }
        }
    }
}
