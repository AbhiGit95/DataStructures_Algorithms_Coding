using System;
using System.Collections.Generic;
using System.Text;

namespace Comp_Coding
{
    class ShortestWordDistanceII
    {
        Dictionary<string, List<int>> map;
        public ShortestWordDistanceII(string[] words)
        {
            map = new Dictionary<string, List<int>>();
            for (int i = 0; i < words.Length; i++)
            {
                if (map.ContainsKey(words[i]))
                {
                    map[words[i]].Add(i);
                }

                else
                {
                    map.Add(words[i], new List<int>() { i });
                }
            }
        }

        public int Shortest(string word1, string word2)
        {
            int min = int.MaxValue;
            foreach (int n in map[word1])
            {
                foreach (int k in map[word2])
                {
                    min = Math.Min(Math.Abs(n - k), min);
                }
            }
            return min;
        }
    }
}
