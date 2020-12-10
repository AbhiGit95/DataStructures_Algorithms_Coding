using System;
using System.Collections.Generic;
using System.Text;

namespace Comp_Coding
{
    class ShortestWordDistanceIII
    {
        public int ShortestWordDistance(string[] words, string word1, string word2)
        {
            Dictionary<string, List<int>> map = new Dictionary<string, List<int>>();
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

            int min = int.MaxValue;
            if (word1.Equals(word2))
            {

                for (int j = 0; j < map[word1].Count - 1; j++)
                {
                    var m = map[word1][j + 1];
                    min = Math.Min(m - map[word1][j], min);
                }
            }
            else
            {
                foreach (int n in map[word1])
                {
                    foreach (int k in map[word2])
                    {
                        min = Math.Min(Math.Abs(n - k), min);
                    }
                }
            }

            return min;
        }
    }
}
