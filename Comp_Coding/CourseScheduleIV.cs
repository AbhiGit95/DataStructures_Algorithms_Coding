using System;
using System.Collections.Generic;
using System.Text;

namespace Comp_Coding
{
    class CourseScheduleIV
    {
        //public IList<bool> CheckIfPrerequisite(int n, int[][] prerequisites, int[][] queries)
        //{
        //    // prepare adjacency list
        //    Dictionary<int, Vertex> map = new Dictionary<int, Vertex>();
        //    List<int> vertices = new List<int>(); 
        //    foreach(int[]arr in prerequisites)
        //    {
        //        if(map.ContainsKey(arr[0]))
        //        {
        //            map[arr[0]].add_edge(arr[1]);
        //        }
        //        else
        //        {
        //            map.Add(arr[0], new Vertex(arr[0]));
        //            map.Add(arr[1], new Vertex(arr[1]));
        //            vertices.Add(arr[0]); vertices.Add(arr[1]);
        //        }
        //    }

        //    bool[] visited = new bool[vertices.Count];
            
        //    foreach(int v in vertices)
        //    {
        //        visited[v] = true;
        //        foreach(int k in map[v].get_adj())
        //        {

        //        }
        //    }

        //}

       public class Vertex
        {
            int val = 0;
            List<int> adj;
            int component;
            public Vertex(int v)
            {
                this.val = v;
                this.adj = new List<int>();
            }

            public void add_edge(int x)
            {
                this.adj.Add(x);
            }

            public void setcomp(int c)
            {
                this.component = c;
            }

            public List<int> get_adj()
            {
                return adj;
            }
        }
    }
}
