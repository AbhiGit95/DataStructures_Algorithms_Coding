using System;
using System.Collections.Generic;
using System.Text;

namespace Comp_Coding
{
    class Kill_Process
    {
        public IList<int> KillProcess(IList<int> pid, IList<int> ppid, int kill)
        {
            Dictionary<int, List<int>> map = new Dictionary<int, List<int>>();

            int n = pid.Count;

            for (int i = 0; i < n; i++)
            {
                if (map.ContainsKey(ppid[i]))
                {
                    map[ppid[i]].Add(pid[i]);
                }
                else
                {
                    map.Add(ppid[i], new List<int>() { pid[i] });
                }

                if (!map.ContainsKey(pid[i]))
                {
                    map.Add(pid[i], new List<int>());
                }
            }

            HashSet<int> set = new HashSet<int>();

            Queue<int> qu = new Queue<int>();

            qu.Enqueue(kill);

            while (qu.Count > 0)
            {
                int temp = qu.Dequeue();
                set.Add(temp);

                foreach (int l in map[temp])
                {
                    if (!set.Contains(l))
                    {
                        qu.Enqueue(l);
                    }

                }
            }

            IList<int> result = new List<int>(set);
            return result;

        }
    }
}
