using System;
using System.Collections.Generic;
using System.Text;

namespace Comp_Coding
{
    class Reconstruct_Itinerary
    {
        Dictionary<string, List<string>> map_list;
        IList<string> result;
        public IList<string> FindItinerary(IList<IList<string>> tickets)
        {
            map_list = new Dictionary<string, List<string>>();
            result = new List<string>();

            if (tickets == null || tickets.Count == 0)
                return result;

            foreach(IList<string> s in tickets)
            {
                if(map_list.ContainsKey(s[0]))
                {
                    map_list[s[0]].Add(s[1]);
                }

                else
                {
                    map_list.Add(s[0], new List<string>() { s[1] });
                }

                //if (!map_list.ContainsKey(s[1]))
                //    map_list.Add(s[1], new List<string>());

            }

            foreach(List<string> lst in map_list.Values)
            {
                lst.Sort();
            }
            
            Stack<string> stack = new Stack<string>();
            stack.Push("JFK");
            //Post Order Traversal
            while(stack.Count != 0)
            {
                while(map_list.ContainsKey(stack.Peek()) && map_list[stack.Peek()].Count != 0)
                {
                    string temp = map_list[stack.Peek()][0];
                    map_list[stack.Peek()].RemoveAt(0);
                    stack.Push(temp);
                }

                result.Insert(0, stack.Pop());
            }
            return result;
        }
    }
}
