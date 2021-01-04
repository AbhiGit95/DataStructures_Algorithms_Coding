using System;
using System.Collections.Generic;
using System.Text;

namespace Comp_Coding
{
    public class MaxStack
    {

        Stack<int> stack;
        Stack<int> max_Stack;
        /** initialize your data structure here. */
        public MaxStack()
        {
            stack = new Stack<int>();
            max_Stack = new Stack<int>();
        }

        public void Push(int x)
        {
            stack.Push(x);
            if (max_Stack.Count == 0)
            {
                max_Stack.Push(x);
            }
            else
            {
                if (max_Stack.Peek() <= x)
                {
                    max_Stack.Push(x);
                }
            }
        }

        public int Pop()
        {
            int t = stack.Pop();
            if (max_Stack.Peek() == t)
            {
                max_Stack.Pop();
            }
            return t;
        }

        public int Top()
        {
            return stack.Peek();
        }

        public int PeekMax()
        {

            return max_Stack.Peek();
        }

        public int PopMax()
        {
            int temp = max_Stack.Pop();
            Stack<int> temp_stack = new Stack<int>();
            while (stack.Peek() != temp)
            {
                temp_stack.Push(stack.Pop());
            }
            stack.Pop();
            while (temp_stack.Count != 0)
            {
                int t = temp_stack.Pop();
                Push(t);
            }
            return temp;
        }

    }
}
