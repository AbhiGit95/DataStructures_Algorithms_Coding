using System;
using System.Collections.Generic;
using System.Text;

namespace Comp_Coding
{
    class All_Paths_From_Source_to_Target
    {
        IList<IList<int>> paths = new List<IList<int>>();

        public IList<IList<int>> AllPathsSourceTarget(int[][] graph)
        {
            DFS(0, new HashSet<int>(), graph, graph.Length - 1, new List<int>());
            return paths;
        }

        public void DFS(int start, HashSet<int> visited, int[][] graph, int end, List<int> res)
        {
            if (start == end)
            {
                res.Add(start);
                paths.Add(new List<int>(res));
                return;
            }

            if (visited.Contains(start))
                return;

            visited.Add(start);
            res.Add(start);

            foreach (int n in graph[start])
            {
                DFS(n, visited, graph, end, res);
                res.RemoveAt(res.Count - 1);
                visited.Remove(n);
            }
        }
    }
}
