using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Comp_Coding
{
    class CountLargestGroup
    {
        public int Count_LargestGroup(int n)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();

            for (int i = 1; i <= n; i++)
            {
                int sum = SumOfDigits(i);

                if (map.ContainsKey(sum))
                    map[sum] += 1;
                else
                    map.Add(sum, 1);
            }

            int max = 0;
            int count = 0;
            foreach (int k in map.Keys)
            {
                if (map[k] > max)
                {
                    max = map[k];
                    count = 1;
                }

                else if (map[k] == max)
                    count += 1;
            }

            
            return count;

        }

        public int SumOfDigits(int num)
        {
            int sum = 0;

            while (num > 0)
            {
                sum += num % 10;
                num /= 10;
            }

            return sum;
        }
    }
}
