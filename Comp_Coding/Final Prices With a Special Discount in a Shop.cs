using System;
using System.Collections.Generic;
using System.Text;

namespace Comp_Coding
{
    class Final_Prices_With_a_Special_Discount_in_a_Shop
    {
        public int[] FinalPrices(int[] prices)
        {
            Stack<int> stack = new Stack<int>();
            int[] smaller = new int[prices.Length];
            for (int i = prices.Length - 1; i >= 0; i--)
            {
                if (stack.Count == 0)
                {
                    stack.Push(prices[i]);
                    smaller[i] = 0;
                }

                else
                {
                    while (stack.Count > 0 && stack.Peek() > prices[i])
                    {
                        stack.Pop();
                    }

                    if (stack.Count == 0)
                    {
                        smaller[i] = 0;
                    }

                    else
                    {
                        smaller[i] = stack.Peek();
                    }
                    stack.Push(prices[i]);
                }
            }

            for (int i = 0; i < prices.Length; i++)
            {
                prices[i] -= smaller[i];
            }

            return prices;
        }
    }
}
