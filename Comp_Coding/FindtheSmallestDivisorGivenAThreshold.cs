using System;
using System.Collections.Generic;
using System.Text;

namespace Comp_Coding
{
    class FindtheSmallestDivisorGivenAThreshold
    {
        public int SmallestDivisor(int[] nums, int threshold)
        {
            int divisor = 1; 
            while (true)
            { 
                decimal sum = 0;
                 foreach(int x in nums)
                {
                    sum += Math.Ceiling((decimal)x/(decimal)divisor);
                }

                if (sum <= threshold)
                    break;
                divisor += 1;
            }

            return divisor;
        }
    }
}
