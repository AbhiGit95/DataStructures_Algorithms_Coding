using System;
using System.Collections.Generic;
using System.Text;

namespace Comp_Coding
{
    class Put_Boxes_Into_the_Warehouse_I
    {
        public int MaxBoxesInWarehouse(int[] boxes, int[] warehouse)
        {
            Array.Sort(boxes);
            int count = 0;

            int n = boxes.Length; int m = warehouse.Length;

            int[] min_arr = new int[m];
            int min = int.MaxValue;

            for (int i = 0; i < m; i++)
            {
                min = Math.Min(min, warehouse[i]);
                min_arr[i] = min;
            }

            int j = 0; int k = m - 1;

            while (j < n && k >= 0)
            {
                if (boxes[j] <= min_arr[k])
                {
                    j++; k--;
                    count++;
                }
                else
                {
                    k--;
                }
            }

            return count;
        }
    }
}
