using System;
using System.Collections.Generic;
using System.Text;

namespace Comp_Coding
{
    class Insert_Interval
    {
        public int[][] Insert(int[][] intervals, int[] newInterval)
        {
            int n = intervals.Length;
            int[][] result = new int[n + 1][];

            for(int i = 0; i <= n; i++)
            {
                result[i] = new int[2];
            }

            int index = 0; 

            for(int i = 0; i <=n; i++)
            {
               if(i == 0)
                {
                    //The new interval's end time ends at or before the start time of first interval.
                    if(newInterval[1] <= intervals[i][0])
                    {
                        result[index][0] = newInterval[0];
                        result[index][1] = newInterval[1];
                    }
                }
            }
            return new int[0][];
        }
    }
}
