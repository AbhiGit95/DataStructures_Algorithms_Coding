using System;
using System.Collections.Generic;
using System.Text;

namespace Comp_Coding
{
    class MissingRanges
    {
        StringBuilder sb;
        public IList<string> FindMissingRanges(int[] nums, int lower, int upper)
        {
            List<string> result = new List<string>();

            if (nums.Length == 0)
            {
                sb = new StringBuilder();
                if (lower == upper)
                {
                    sb.Append(lower);
                    result.Add(sb.ToString());
                }

                else
                {
                    sb.Append(lower);
                    sb.Append("->");
                    sb.Append(upper);
                    result.Add(sb.ToString());
                }
                return result;
            }

            if (nums.Length == 1)
            {
                sb = new StringBuilder();
                //if both low and up is same as the element
                if (nums[0] == lower && nums[0] == upper)
                    return result;

                //if low is same
                else if (nums[0] == lower)
                {
                    //check if the difference between elem and up is not 1
                    if (nums[0] + 1 != upper)
                    {
                        sb.Append(nums[0] + 1);
                        sb.Append("->");
                        sb.Append(upper);
                    }
                    else
                    {
                        sb.Append(upper);
                    }
                    result.Add(sb.ToString());
                    return result;
                }
                else if( nums[0] == upper)
                {
                    if(nums[0] - 1 != lower)
                    {
                        sb.Append(lower);
                        sb.Append("->");
                        sb.Append(nums[0] - 1);
                    }

                    else
                    {
                        sb.Append(lower);
                    }
                    result.Add(sb.ToString());
                    return result;
                }
                   else
                {
                    if(nums[0] - 1 == lower && nums[0] + 1 == upper)
                    {
                        sb.Append(lower);
                        result.Add(sb.ToString());
                        sb.Clear();
                        sb.Append(upper);
                        result.Add(sb.ToString());
                    }

                    else if(nums[0] - 1 == lower)
                    {
                        sb.Append(lower);
                        result.Add(sb.ToString());
                        sb.Clear();
                        sb.Append(nums[0] + 1);
                        sb.Append("->");
                        sb.Append(upper);
                        result.Add(sb.ToString());
                    }

                    else if(nums[0] + 1 == upper)
                    {
                        sb.Append(lower);
                        sb.Append("->");
                        sb.Append(nums[0] - 1);
                        result.Add(sb.ToString());
                        sb.Clear();
                        sb.Append(upper);
                        result.Add(sb.ToString());
                    }

                    else
                    {
                        sb.Append(lower);
                        sb.Append("->");
                        sb.Append(nums[0] - 1);
                        result.Add(sb.ToString());
                        sb.Clear();
                        sb.Append(nums[0] + 1);
                        sb.Append("->");
                        sb.Append(upper);
                        result.Add(sb.ToString());
                    }

                    return result;
                }
            }

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] - nums[i - 1] > 1 && (nums[i - 1] + 1 != nums[i] - 1))
                {
                    sb = new StringBuilder();
                    sb.Append(nums[i - 1] + 1);
                    sb.Append("->");
                    sb.Append(nums[i] - 1);
                    result.Add(sb.ToString());
                }

                else if (nums[i] - nums[i - 1] > 1)
                {
                    sb = new StringBuilder();
                    sb.Append(nums[i - 1] + 1);
                    result.Add(sb.ToString());
                }


               
            }
            if (nums[0] != lower && nums[0] - 1 != lower)
            {
                sb = new StringBuilder();
                sb.Append(lower);
                sb.Append("->");
                sb.Append(nums[0] - 1);
                result.Add(sb.ToString());
            }

            else if (nums[0] != lower)
            {
                sb = new StringBuilder();
                sb.Append(lower);
                result.Add(sb.ToString());
            }


            if (nums[nums.Length - 1] != upper && nums[nums.Length - 1] + 1 != upper)
            {
                sb = new StringBuilder();
                sb.Append(nums[nums.Length - 1] + 1);
                sb.Append("->");
                sb.Append(upper);
                result.Add(sb.ToString());
            }

            else if (nums[nums.Length - 1] != upper)
            {
                sb = new StringBuilder();
                sb.Append(upper);
                result.Add(sb.ToString());
            }

            result.Sort();

            if (result[result.Count - 1][0].Equals('-') && result.Count > 1)
                result.Reverse();

            return result;
        }
    }
}
