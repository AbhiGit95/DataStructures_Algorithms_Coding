using System;
using System.Collections.Generic;
using System.Text;

namespace Comp_Coding
{
    public class Remove_Duplicate_Letters
    {
        public string RemoveDuplicateLetters(string s)
        {
            int[] charMap = new int[26];
            int n = s.Length;
            bool[] flag = new bool[26];

            for (int i = 0; i < n; i++)
            {
                charMap[s[i] - 'a'] += 1;
            }

            Stack<char> stack = new Stack<char>();

            for (int i = 0; i < s.Length; i++)
            {
                if (stack.Count == 0)
                {
                    stack.Push(s[i]);
                    flag[s[i] - 'a'] = true;
                    charMap[s[i] - 'a'] -= 1;
                }

                else
                {
                    while (stack.Count > 0 && stack.Peek() > s[i] && charMap[stack.Peek() - 'a'] >= 1 && flag[stack.Peek() - 'a'] && !flag[s[i] -'a'])
                    {
                    
                       var temp = stack.Pop();
                       flag[temp - 'a'] = false;
                            
                    }

                    if (!flag[s[i] - 'a'])
                    {
                        stack.Push(s[i]);
                        flag[s[i] - 'a'] = true;
                    }
                    charMap[s[i] - 'a'] -= 1;
                }

            }

            StringBuilder sb = new StringBuilder();
            Stack<char> stack2 = new Stack<char>();

            while (stack.Count > 0)
            {
                if (stack2.Count == 0)
                {
                    stack2.Push(stack.Pop());
                }

                sb.Append(stack.Pop());
            }

            char[] arr = sb.ToString().ToCharArray();
            Array.Reverse(arr);

            return new string(arr);
        }
    }
}
