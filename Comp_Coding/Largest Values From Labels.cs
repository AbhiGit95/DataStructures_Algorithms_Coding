using System;
using System.Collections.Generic;
using System.Text;

namespace Comp_Coding
{
    class Largest_Values_From_Labels
    {
        public int LargestValsFromLabels(int[] values, int[] labels, int num_wanted, int use_limit)
        {
            List<(int, int)> value_label = new List<(int, int)>();
            int n = values.Length;
            for(int i = 0; i < n; i++)
            {
                value_label.Add((values[i], labels[i]));
            }

            value_label.Sort(new valueSorter());
            int result = 0;

            Dictionary<int, int> label_Count = new Dictionary<int, int>();

            int prev_label = -1;

            foreach((int,int) tup in value_label)
            {
                if (num_wanted > 0)
                {
                    if (prev_label == -1)
                    {
                        prev_label = tup.Item2;
                        result += tup.Item1;
                        label_Count.Add(tup.Item2, 1);
                        num_wanted--;
                    }
                    else
                    {
                        if(tup.Item2 == prev_label)
                        {
                            if(label_Count[tup.Item2] < use_limit)
                            {
                                result += tup.Item1;
                                label_Count[tup.Item2] += 1;
                                num_wanted--;
                            }
                        }
                        else
                        {
                            if(label_Count.ContainsKey(tup.Item2))
                            {
                                if (label_Count[tup.Item2] < use_limit)
                                {
                                    result += tup.Item1;
                                    label_Count[tup.Item2] += 1;
                                    num_wanted--;
                                }
                            }
                            else
                            {
                                result += tup.Item1;
                                label_Count.Add(tup.Item2, 1);
                                num_wanted--;
                            }
                            prev_label = tup.Item2;                        }
                    }
                }

                else
                    break;
            }

            return result;
        }

        public class valueSorter : IComparer<(int,int)>
        {
            public int Compare((int, int)x, (int,int)y)
            {
                if (x.Item1 > y.Item1)
                    return -1;
                else if (x.Item1 < y.Item1)
                    return 1;
                else
                    return 0;
            }
        }
    }
}
