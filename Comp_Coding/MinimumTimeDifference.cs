using System;
using System.Collections.Generic;
using System.Text;

namespace Comp_Coding
{
    class MinimumTimeDifference
    {
        public int FindMinDifference(IList<string> timePoints)
        {
            if (timePoints == null || timePoints.Count == 0)
                return 0;

            List<string> newlist = (List<string>)timePoints;
            newlist.Sort(new TimeComparer());

            return -1;
        }

        public class TimeComparer : IComparer<string>
        {
            public int Compare(string a, string b)
            {
                string[] temp1 = a.Split(":", StringSplitOptions.RemoveEmptyEntries);
                string[] temp2 = b.Split(":", StringSplitOptions.RemoveEmptyEntries);

                if (temp1[0].CompareTo(temp2[0]) == 1)
                    return 1;
                else if(temp1[0].CompareTo(temp2[0]) == 0)
                {
                    if (temp1[1].CompareTo(temp2[1]) == 1)
                        return 1;
                    else if (temp1[1].CompareTo(temp2[1]) == 0)
                        return 0;
                    else
                        return -1;
                }
                else
                {
                    return -1;
                }
            }
        }
    }
}
