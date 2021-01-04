using System;
using System.Collections.Generic;
using System.Text;

namespace Comp_Coding
{
    class Index_Pairs_of_a_String
    {
        public int[][] IndexPairs(string text, string[] words)
        {
            int n = words.Length;
            List<List<int>> res = new List<List<int>>();

            for(int i = 0; i < n; i++)
            {
                for(int j = text.IndexOf(words[i][0]); j > -1; j = text.IndexOf(words[i][0],j+1))
                {
                    if(text.Substring(j,Math.Min(words[i].Length, text.Length - j)).Equals(words[i]))
                    {
                        res.Add(new List<int> { j, j + words[i].Length -1 });

                    }
                }
            }

            int[][] result = new int[res.Count][];
           for(int i = 0; i < res.Count; i++)
            {
                result[i] = new int[] { res[i][0], res[i][1] };
            }
            Array.Sort(result,new Compare_array());
            return result;
        }

        public class Compare_array : IComparer<int[]>
        {
            public int Compare(int[]x, int[]y)
            {
                if(x[0] == y[0])
                {
                    return x[1].CompareTo(y[1]);
                }

                return x[0].CompareTo(y[0]);
            }
        }
    }
}
