using System;
using System.Collections.Generic;
using System.Text;

namespace Comp_Coding
{
    class MeetingRooms
    {
        public bool CanAttendMeetings(int[][] intervals)
        {
            if (intervals == null || intervals.Length == 0 || intervals.Length == 1)
                return true;

            int n = intervals.Length;
            Array.Sort(intervals, new TimeComparer());

            for(int i = 1; i < n; i++)
            {
                if (intervals[i][0] < intervals[i - 1][1])
                    return false;
            }

            return true;
        }

        public class TimeComparer : IComparer<int[]>
        {
            public int Compare(int[] x, int[] y)
            {
                if (x[0] == y[0])
                    return x[1].CompareTo(y[1]);
                else
                    return x[0].CompareTo(y[0]);
            }
        }
    }
}
