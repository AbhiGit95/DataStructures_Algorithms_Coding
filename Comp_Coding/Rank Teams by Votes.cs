using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Comp_Coding
{
    class Rank_Teams_by_Votes
    {
        public string RankTeams(string[] votes)
        {

            if (votes == null || votes.Length == 0)
                return "";

            int n = votes.Length;
            if (n == 1)
                return votes[0];

           Dictionary<char, CustomItem> map = new Dictionary<char, CustomItem>();
           for(int i = 0; i  < n; i++)
            {
                var word = votes[i];

                for(int j = 0; j < word.Length; j++)
                {
                    if(map.ContainsKey(word[j]))
                    {
                        map[word[j]].arr[j] += 1;
                    }
                    else
                    {
                        int[] arr = new int[word.Length];
                        arr[j] = 1;
                        map.Add(word[j], new CustomItem(word[j], arr));
                    }
                }
            }

            List<CustomItem> temp = new List<CustomItem>(map.Values.ToList());
            temp.Sort(new customComparer(votes[0].Length));

            StringBuilder sb = new StringBuilder();
            for(int i = temp.Count - 1; i >= 0; i--)
            {
                sb.Append(temp[i].c);
            }

            return sb.ToString();
        }

        public class customComparer : IComparer<CustomItem>
        {
            int len;

            public customComparer(int arr_len)
            {
                len = arr_len;
            }
            public int Compare(CustomItem a, CustomItem b)
            {
                for(int i = 0; i < len; i++)
                {
                    if (a.arr[i] != b.arr[i])
                        return a.arr[i].CompareTo(b.arr[i]);
                }

                return b.c.CompareTo(a.c);
            }
        }

        public class CustomItem
        {
            public char c;
            public int[] arr;

            public CustomItem(char C, int[] arr1)
            {
                this.c = C;
                this.arr = arr1;
            }
        }
    }
}
