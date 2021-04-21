using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Comp_Coding
{
    class GasStation
    {
        public int CanCompleteCircuit(int[] gas, int[] cost)
        {
            var total_gas = 0;
            var current_gas = 0;
            int starting_Station = 0;
            for(int i = 0; i < gas.Length; i++)
            {
                current_gas += gas[i] - cost[i];
                total_gas += gas[i] - cost[i];

                if (current_gas < 0)
                {
                    starting_Station = i+1;
                    current_gas = 0;
                }
            }

            if (total_gas < 0)
                return -1;
            else
                return starting_Station;
        }
    }
}
