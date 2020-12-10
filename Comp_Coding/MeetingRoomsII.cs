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
            Array.Sort(intervals, new RoomSorter());
            Stack<(int, int)> stack = new Stack<(int, int)>();

            int rooms = 0;

            foreach(int[]l in intervals)
            {
                if(stack.Count == 0)
                {
                    stack.Push((l[0], l[1]));
                    rooms += 1;
                }

                else
                {
                    if ( l[1] < stack.Peek().Item2)
                    {
                        rooms += 1;
                    }

                    else if(l[0] < stack.Peek().Item2 && l[1] > stack.Peek().Item2)
                    {
                        rooms += 1;
                        stack.Push((l[0], l[1]));
                    }
                    else
                    {
                        stack.Push((l[0], l[1]));
                    }
                }
            }
            return rooms;
        }

        class RoomSorter : IComparer<int[]>
        {
            public int Compare(int[]x, int[]y)
            {
                if (x[0] == y[0])
                    return x[1].CompareTo(y[1]);
                else
                    return x[0].CompareTo(y[0]);
            }
        }
    }
}
