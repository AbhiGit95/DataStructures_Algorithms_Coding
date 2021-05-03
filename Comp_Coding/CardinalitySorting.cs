using System;
using System.Collections.Generic;
using System.Text;

namespace Comp_Coding
{
    class CardinalitySorting
    {
        public List<int> cardinalitySort(List<int> nums)
        {
            if (nums == null || nums.Count == 0)
                return new List<int>();

            List<(int,string)> temp = new List<(int,string)>();

           
            foreach(int n in nums)
            {
                var binary = Convert.ToString(n, 2);
                temp.Add((n, binary));
            }

            temp.Sort(new Comparator());

            List<int> result = new List<int>();

            foreach(var n in temp)
            {
                result.Add(n.Item1);
            }

            return result;
        }

        public class Comparator : IComparer<(int,string)>
        {
            public int Compare((int,string) x, (int,string) y)
            {
                if (x.Item2.CompareTo(y.Item2) == 0)
                    return x.Item1.CompareTo(y.Item1);

                return x.Item2.CompareTo(y.Item2);
            }
        }
    }
}
