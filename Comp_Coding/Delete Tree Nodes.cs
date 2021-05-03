using System;
using System.Collections.Generic;
using System.Text;

namespace Comp_Coding
{
    class Delete_Tree_Nodes
    {
        public int DeleteTreeNodes(int nodes, int[] parent, int[] value)
        {
            Dictionary<int,List<int>> adjList = new Dictionary<int, List<int>>();

            for(int i = 0; i < nodes; i++)
            {
                if(parent[i] != -1)
                {
                    if (adjList.ContainsKey(parent[i]))
                    {
                        adjList[parent[i]].Add(i);
                    }
                    else
                        adjList.Add(parent[i], new List<int>() { i });
                }
            }

        

            var res = DFS(adjList,  0 , value);
            return res[1];
        }

        public int[] DFS(Dictionary<int,List<int>> adjList,int node, int[] value)
        {
            int sum = value[node];
            int count = 1;

            if(adjList.ContainsKey(node))
            {
                foreach(int n in adjList[node])
                {
                    var res = DFS(adjList, n, value);
                    sum += res[0];
                    count += res[1];
                }
            }

            if (sum == 0)
                return new int[] { 0, 0 };

            else
                return new int[] { sum, count };
        }
    }
}
