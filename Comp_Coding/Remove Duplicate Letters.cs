using System;
using System.Collections.Generic;
using System.Text;

namespace Comp_Coding
{
    public class Remove_Duplicate_Letters
    {
        public string RemoveDuplicateLetters(string s)
        {
            int[] char_Map = new int[26];

            foreach(char c in s)
            {
                char_Map[c - 'a'] += 1;
            }

            int unique_char = 0;
            for(int i = 0; i < 26; i++)
            {
                if (char_Map[i] > 0)
                    unique_char += 1;
            }

            return null;
        }
    }
}
