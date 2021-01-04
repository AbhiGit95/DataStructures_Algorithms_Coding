using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Comp_Coding
{
    class MeetingRoomsII
    {
        public int MinMeetingRooms(int[][] intervals)
        {
            int n = intervals.Length;
            int[] start_time = new int[n];
            int[] end_time = new int[n];

            for(int i = 0; i < n; i++)
            {
                start_time[i] = intervals[i][0];
                end_time[i] = intervals[i][1];
            }

            Array.Sort(start_time);
            Array.Sort(end_time);

            int rooms = 0;
            int start = 0; int end = 0;
            while(start < n)
            {
                if (start_time[start] < end_time[end])
                    rooms += 1;
                else
                {
                    end += 1;
                }

                start += 1;
            }

            return rooms;
        }

    }
}
