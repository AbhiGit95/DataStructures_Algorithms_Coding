using System;
using System.Collections.Generic;
using System.Text;

namespace Comp_Coding
{
    class Put_Boxes_Into_the_Warehouse_II
    {
        public int MaxBoxesInWarehouse(int[] boxes, int[] warehouse)
        {
            int n = boxes.Length; int m = warehouse.Length;
            int res = 0;
            Array.Sort(boxes);

            int start = 0; int end = m - 1; int box = n - 1;
            while(box >= 0 && start <= end)
            {
                if(boxes[box] <= warehouse[start])
                {
                    start++;
                    res++;
                }

                else if(boxes[box] <= warehouse[end])
                {
                    end--; res++;
                }
                box--;
            }
            return res;
        }
    }
}
