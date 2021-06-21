using System;
using System.Collections.Generic;
using System.Text;

namespace Comp_Coding
{
    class Check_if_All_the_Integers_in_a_Range_Are_Covered
    {
        public bool IsCovered(int[][] ranges, int left, int right)
        {

            //Sort on the basis of start time
            // If two ranges have the same start time then take the one with larger interval.

            Array.Sort(ranges, new CustomCompare());
            int? prevStart = null;
            int? prevEnd = null;
            List<int[]> listOfIntervals = new List<int[]>();
            foreach (int[] arr in ranges)
            {
                if (prevStart == null && prevEnd == null)
                {
                    prevStart = arr[0];
                    prevEnd = arr[1];
                }

                else if (arr[0] - 1 <= prevEnd && arr[1] > prevEnd)
                    prevEnd = arr[1];

                else if (arr[0] > prevEnd)
                {
                    listOfIntervals.Add(new int[] { prevStart.Value, prevEnd.Value });
                    prevStart = arr[0];
                    prevEnd = arr[1];
                }

            }
            listOfIntervals.Add(new int[] { prevStart.Value, prevEnd.Value });
            foreach (int[] interval in listOfIntervals)
            {
                if (interval[0] <= left && interval[1] >= right)
                    return true;
            }



            return false;
        }


        public class CustomCompare : IComparer<int[]>
        {
            public int Compare(int[] x, int[] y)
            {
                if (x[0] == y[0])
                {
                    if (x[1] > y[1])
                        return -1;
                    else if (x[1] < y[1])
                        return 1;
                    else
                        return 0;
                }
                else
                    return x[0].CompareTo(y[0]);
            }
        }
    }
}
