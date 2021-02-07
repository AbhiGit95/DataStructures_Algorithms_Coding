using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Comp_Coding
{

    class ReverseParentheses
    {
        public string ReverseParentheses_func(string s)
        {
            if (s == null || s.Length == 0)
                return "";

            Stack<char> stack = new Stack<char>();
            Queue<char> qu = new Queue<char>();

            foreach(char c in s)
            {
                if (stack.Count == 0 || c != ')')
                    stack.Push(c);

                else 
                {
                    while (stack.Count != 0 && stack.Peek() != '(')
                    {
                        //Enqueieng in reverse order
                        qu.Enqueue(stack.Pop());
                    }

                    stack.Pop(); //Remove opening brace

                    while (qu.Count > 0)
                    {
                        stack.Push(qu.Dequeue());
                    }
                }
            }

            return new string(stack.Reverse().ToArray());
        }
    }
}
