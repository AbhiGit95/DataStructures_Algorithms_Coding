using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Comp_Coding
{
    //This needs a highly optimized code
    public class TimeMap
    {
        /** Initialize your data structure here. */
        public Dictionary<string, SortedDictionary<int,string>> set_map;

        public TimeMap()
        {
            set_map = new Dictionary<string, SortedDictionary<int, string>>();
        }

        public void Set(string key, string value, int timestamp)
        {
            if(set_map.ContainsKey(key))
            {
                set_map[key].Add(timestamp, value);
            }
            else
            {
                SortedDictionary<int, string> sl = new SortedDictionary<int, string>(new ListComparer());
                sl.Add(timestamp, value);
                set_map.Add(key, sl);
            }
        }

        public string Get(string key, int timestamp)
        {
            SortedDictionary<int, string> lst = set_map[key];

            foreach(KeyValuePair<int,string> kv in lst)
            {
                if (kv.Key <= timestamp)
                    return kv.Value;
            }

            return "";
        }

        public class ListComparer : IComparer<int>
        {
            public int Compare(int x,  int y)
            {
                if (x >= y)
                    return -1;
                else
                    return 1;
            }
        }

    }
}
