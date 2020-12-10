using System;
using System.Collections.Generic;
using System.Text;

namespace Comp_Coding
{
    class Robot_Return_to_Origin
    {
        public bool JudgeCircle(string moves)
        {
            //just simulate the walk
            int[] start = new int[] { 0, 0 };
            foreach (char c in moves)
            {
                if (c == 'L')
                {
                    start[0] -= 1;
                }

                else if (c == 'R')
                {
                    start[0] += 1;
                }

                if (c == 'U')
                {
                    start[1] += 1;
                }

                else if (c == 'D')
                {
                    start[1] -= 1;
                }
            }

            if (start[0] == 0 && start[1] == 0)
                return true;
            else
                return false;
        }
    }
}
