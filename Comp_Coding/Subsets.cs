using System;
using System.Collections.Generic;
using System.Text;

namespace Comp_Coding
{
    class Subsets
    {
        public IList<IList<int>> Subsets_finder(int[] nums)
        {
            List<List<int>> res = getSubSets(nums, 0);
            IList<IList<int>> result = new List<IList<int>>();

            foreach(List<int> l in res)
            {
                result.Add(l);
            }

            return result;
        }

        public List<List<int>> getSubSets(int[] nums, int index)
        {
            List<List<int>> allsubsets;
            if(nums.Length == index)
            {
                allsubsets = new List<List<int>>();
                allsubsets.Add(new List<int>()); // add empty set
            }

            else
            {
                allsubsets = getSubSets(nums, index + 1);
                int item = nums[index];
                List<List<int>> moresubsets = new List<List<int>>();
                foreach(List<int> subset in allsubsets)
                {
                    List<int> newsubset = new List<int>();
                    newsubset.AddRange(subset);
                    newsubset.Add(item);
                    moresubsets.Add(newsubset);
                }
                allsubsets.AddRange(moresubsets);
            }
            return allsubsets;
        }
    }
}
