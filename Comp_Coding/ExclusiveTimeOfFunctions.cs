using System;
using System.Collections.Generic;
using System.Text;

namespace Comp_Coding
{
    class ExclusiveTimeOfFunctions
    {
        public int[] ExclusiveTime(int n, IList<string> logs)
        {
            int[] result = new int[n];

            Stack<(string,int)> stack = new Stack<(string,int)>();

            foreach(string log in logs)
            {
                if(log.Contains("start"))
                {
                    if(stack.Count == 0)
                        stack.Push((log, -1));
                    else
                    {
                        var current = log.Split(":", StringSplitOptions.RemoveEmptyEntries);
                        var prev = stack.Peek().Item1.Split(":", StringSplitOptions.RemoveEmptyEntries);

                        if(prev[2] == "end")
                        {
                            var parent = stack.Peek().Item2;
                        }

                        else if(prev[2] == "start")
                        {

                        }
                    }
                }
            }

            return result;
        }
    }
}
