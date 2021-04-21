using System;
using System.Collections.Generic;
using System.Text;

namespace Comp_Coding
{
    class CourseScheduleII
    {
        public int[] FindOrder(int numCourses, int[][] prerequisites)
        {
            int[] inDegree = new int[numCourses];

            List<int>[] adj_list = new List<int>[numCourses];

          
            foreach(int[] arr in prerequisites)
            {
                inDegree[arr[0]] += 1;

                if (adj_list[arr[1]] == null)
                    adj_list[arr[1]] = new List<int>();

                adj_list[arr[1]].Add(arr[0]);
            }

            Queue<int> queue = new Queue<int>();
            HashSet<int> visited = new HashSet<int>();
            int[] result = new int[numCourses];

            for(int i = 0; i < numCourses; i++)
            {
                if (inDegree[i] == 0)
                    queue.Enqueue(i);
            }

            int index = 0;
            while(queue.Count > 0)
            {
                int course = queue.Dequeue();
                if(!visited.Contains(course))
                {
                    visited.Add(course);
                    result[index] = course;
                    index++;

                    if (adj_list[course] != null)
                    {
                        foreach (int i in adj_list[course])
                        {
                            inDegree[i] -= 1;
                            if (inDegree[i] == 0)
                                queue.Enqueue(i);
                        }
                    }
                }
                
            }

            return index == numCourses ? result : new int[0];
        }
    }
}
