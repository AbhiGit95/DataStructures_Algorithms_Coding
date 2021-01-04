using System;
using System.Collections.Generic;
using System.Text;

namespace Comp_Coding
{
    class Moving_Average_from_Data_Stream
    {
        int window = 0; int sum = 0; int start = 0;
        List<int> lst;
        /** Initialize your data structure here. */
        public Moving_Average_from_Data_Stream(int size)
        {
            window = size;
            lst = new List<int>();
        }

        public double Next(int val)
        {
            if (lst.Count < window)
            {
                sum += val;
                lst.Add(val);
                return ((double)sum / (double)lst.Count);
            }

            else
            {
                sum -= lst[start];
                start += 1;
                sum += val;
                lst.Add(val);
                return ((double)sum / (double)window);
            }
        }
    }
}
