using System;
using System.Collections.Generic;
using System.Text;

namespace Comp_Coding
{
    class MakeTheStringGreat
    {
        public string MakeGood(string s)
        {
            if (s.Length == 1)
                return s;
            
            Stack<char> stack = new Stack<char>();
            foreach (char c in s)
            {
                if (stack.Count == 0)
                {
                    stack.Push(c);
                }
                else
                {
                    bool flag = false;
                    if (stack.Count > 0 && ((Char.IsLower(stack.Peek()) && Char.IsUpper(c) && Char.ToLower(c).Equals(stack.Peek())) || (Char.IsUpper(stack.Peek()) && Char.IsLower(c) && Char.ToUpper(c).Equals(stack.Peek()))))
                    {
                        stack.Pop();
                        flag = true;
                    }

                    if (!flag)
                        stack.Push(c);
                 }
            }

            char[] arr = new char[stack.Count];
            for(int i = arr.Length - 1; i >=0; i--)
            {
                arr[i] = stack.Pop();
            }

            string result = new string(arr);
            return result;
        }
    }
}
