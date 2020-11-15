using System;
using System.Collections.Generic;
using System.Text;

namespace Comp_Coding
{
    class CapacityToShipPackagesWithinDDays
    {
        //In Progress
        public int ShipWithinDays(int[] weights, int D)
        {
            int sum = 0;
            foreach (int w in weights)
            {
                sum += w;
            }

            int min_weight = (int)Math.Ceiling((double)sum / D);
            int temp = 0;
            foreach (int w in weights)
            {
                temp += w;
                if (temp >= min_weight)
                    break;
            }

            return temp;
        }
    }
}
