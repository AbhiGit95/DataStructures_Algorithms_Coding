using System;
using System.Collections.Generic;
using System.Text;

namespace Comp_Coding
{
    class Strobogrammatic_Number
    {
        public bool IsStrobogrammatic(string num)
        {
            Dictionary<char, char> map = new Dictionary<char, char>();
            map.Add('6', '9'); map.Add('9', '6'); map.Add('8', '8'); map.Add('0', '0'); map.Add('1', '1');

            int start = 0; int end = num.Length - 1;
            while (start <= end)
            {
                if (((map.ContainsKey(num[start])) && map[num[start]].Equals(num[end])) || ((map.ContainsKey(num[end])) && map[num[end]].Equals(num[start])))
                {
                    start++; end--;
                }
                else
                    return false;
            }

            return true;
        }
    }
}
