using System;
using System.Collections.Generic;
using System.Text;

namespace Comp_Coding
{
    class WaterBottles
    {
        public int NumWaterBottles(int numBottles, int numExchange)
        {
            int res = numBottles;
            int refill = numBottles / numExchange;
            int residual = numBottles % numExchange;
            res += refill;
            while (residual + refill >= numExchange)
            {
                int temp = (residual + refill);
                res += (temp / numExchange);
                refill = temp / numExchange;
                residual = temp % numExchange;
            }

            return res;
        }
    }
}
