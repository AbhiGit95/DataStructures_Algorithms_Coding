using System;
using System.Collections.Generic;
using System.Text;

namespace Comp_Coding
{
    class StringIterator
    {
        int current = 0; int span = 0; string s; char a; int n = 0;
        public StringIterator(string compressedString)
        {
            this.s = compressedString;
            n = s.Length;
            a = ' ';
        }

        public char Next()
        {
            if(!HasNext())
            {
                return ' ';
            }

            if(span == 0)
            {
                a = s[current++];
                while(current < n && Char.IsDigit(s[current]) )
                {
                    span = span * 10 + s[current++] - '0';
                }
            }
            span--;
            return a;
        }

        public bool HasNext()
        {
            return current != n || span != 0;
        }
    }
}
