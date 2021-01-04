using System;
using System.Collections.Generic;
using System.Text;

namespace Comp_Coding
{
    class CarPooling
    {
        public bool CarPooling_(int[][] trips, int capacity)
        {
            int n = trips.Length;

            int[][] car_start = new int[n][];
            int[][] car_end = new int[n][];

            for(int i = 0; i < n; i++)
            {
                car_start[i] = new int[2];
                car_end[i] = new int[2];

                car_start[i][0] = trips[i][0];
                car_start[i][1] = trips[i][1];

                car_end[i][0] = trips[i][0];
                car_end[i][1] = trips[i][2];

            }

            Array.Sort(car_start, new CarComparer());
            Array.Sort(car_end, new CarComparer());

            int start = 0; int end = 0;
            
            while(start < n)
            {
                if(car_start[start][1] < car_end[end][1])
                {
                    capacity -= car_start[start][0];
                    start++;
                }
                else
                {
                    capacity += car_end[end][0];
                    end++;
                }

                if (capacity < 0)
                    return false;

                
            }
            return true;
        }

        public class CarComparer : IComparer<int[]>
        {
            public int Compare(int[]x, int[]y)
            {
                if (x[1] == y[1])
                    return x[0].CompareTo(y[0]);
                else
                    return x[1].CompareTo(y[1]);
            }
        }
    }
}
