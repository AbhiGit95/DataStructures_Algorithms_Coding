using System;
using System.Collections.Generic;
using System.Text;

namespace Comp_Coding
{
    class CommonPrefixLength
    {
        //Roblox challenge - Naive Solution - TLE
        public static List<int> commonPrefix(List<string> inputs)
        {
            if(inputs == null || inputs.Count == 0)
            {
                return new List<int>();
            }

            List<int> result = new List<int>();

            foreach (string str in inputs)
            {
                int sum = str.Length;
                HashSet<int> set = new HashSet<int>();

                for (int i = 1; i < str.Length; i++)
                {
                    if (str[i].Equals(str[0]))
                        set.Add(i);
                }

                char[] c = str.ToCharArray();

                foreach (int i in set)
                {
                    sum += getprefixlength(c, i);
                }
                result.Add(sum);
            }

            return result;
        }

        public static int getprefixlength(char[] arr, int index)
        {
            int i = 0;  int j = index; int count = 0;
            while(j < arr.Length && i <= index)
            {
                if (arr[i++] == arr[j++])
                {
                    count++;
                }
                else
                    break;
            }
            return count;
        }
    }
}
