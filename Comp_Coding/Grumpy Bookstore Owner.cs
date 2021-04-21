using System;
using System.Collections.Generic;
using System.Text;

namespace Comp_Coding
{
    class Grumpy_Bookstore_Owner
    {
        public int MaxSatisfied(int[] customers, int[] grumpy, int X)
        {
            int customers_satisfied_withoutgrumpy = 0;
            int n = customers.Length;

            for(int i = 0; i < n; i++)
            {
                if (grumpy[i] == 0)
                    customers_satisfied_withoutgrumpy += customers[i];
            }

            int max_satisfied_customers = 0;

            for(int i = 0; i < X; i++)
            {
                if (grumpy[i] == 1)
                    customers_satisfied_withoutgrumpy += customers[i];
            }

            max_satisfied_customers = Math.Max(max_satisfied_customers, customers_satisfied_withoutgrumpy);

            int start = X;
            while(start < n)
            {
                if(grumpy[start] == 1)
                {
                    customers_satisfied_withoutgrumpy += customers[start];
                }
                if(grumpy[start - X] == 1)
                {
                    customers_satisfied_withoutgrumpy -= customers[start - X];
                }
                max_satisfied_customers = Math.Max(max_satisfied_customers, customers_satisfied_withoutgrumpy);
                start++;
            }
            max_satisfied_customers = Math.Max(max_satisfied_customers, customers_satisfied_withoutgrumpy);
            return max_satisfied_customers;
        }
    }
}
