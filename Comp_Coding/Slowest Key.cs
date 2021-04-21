using System;
using System.Collections.Generic;
using System.Text;

namespace Comp_Coding
{
    class Slowest_Key
    {
        public char SlowestKey(int[] releaseTimes, string keysPressed)
        {
            char result = 'a';
            int prev = 0;
            int max = 0;
            int current_max = 0;

            for (int i = 0; i < releaseTimes.Length; i++)
            {
                current_max = releaseTimes[i] - prev;

                if (current_max >= max)
                {
                    if (max == current_max)
                    {
                        if (keysPressed[i].CompareTo(result) == 1)
                            result = keysPressed[i];
                    }
                    else
                    {
                        result = keysPressed[i];
                        max = current_max;
                    }
                    
                }
                prev = releaseTimes[i];
            }
            return result;
        }
    }
}
