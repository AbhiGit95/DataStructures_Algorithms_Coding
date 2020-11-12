using System;
using System.Collections.Generic;
using System.Text;

namespace Comp_Coding
{
    class FindRightInterval
    {
        public int[] FindRightInterval1(int[][] intervals)
        {
            if (intervals == null || intervals.Length == 0)
                return new int[] { -1 };
            else if(intervals.Length == 1)
                return new int[] { -1 };

            Dictionary<int, int> map = new Dictionary<int, int>();
            for(int i = 0; i < intervals.Length; i++)
            {
                //add start time of the interval as it is unique
                map.Add(intervals[i][0], i);
            }
            int[] result = new int[intervals.Length];
            Array.Sort(intervals, new IntervalComparer());
            int start = 0; int end = intervals.Length - 1;
            foreach(int[] a in intervals)
            {
                var interval_start = BinarySearch(intervals, start, end, a[1],-1);
                if(interval_start.Item1 != -1 || (interval_start.Item1 == -1 && map.ContainsKey(-1) && interval_start.Item2 <= end))
                {
                    int interval_index = map[interval_start.Item1];
                    result[map[a[0]]] = interval_index;
                }

                else 
                {
                    result[map[a[0]]] = -1;
                }
            }
            return result;
        }


        public (int,int) BinarySearch(int[][] intervals, int start, int end, int target, int index)
        {
            if (start > end)
                return (index,start);

            int mid = start + (end - start) / 2;

            if (intervals[mid][0] == target)
                return (intervals[mid][0],start);

            else if (intervals[mid][0] > target)
                return BinarySearch(intervals, start, mid-1, target, intervals[mid][0]);

            else
               return BinarySearch(intervals, mid + 1, end, target, index);
        }

        public class IntervalComparer : IComparer<int[]>
        {
            public int Compare(int[] x, int[] y)
            {
                return x[0].CompareTo(y[0]);
            }
        }
    }
}
