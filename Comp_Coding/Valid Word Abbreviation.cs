using System;
using System.Collections.Generic;
using System.Text;

namespace Comp_Coding
{
    class Valid_Word_Abbreviation
    {
        public bool ValidWordAbbreviation(string word, string abbr)
        {
            if (abbr.Length > word.Length)
                return false;

            int start = 0; int index = 0;
            int n = word.Length; int m = abbr.Length;

            while(start < m && index < n)
            {
                if(Char.IsLetter(abbr[start]))
                {
                    if (!abbr[start].Equals(word[index]))
                        return false;
                    start++;
                    index++;
                }

                else if(Char.IsDigit(abbr[start]))
                {
                    int num = 0;
                    if (abbr[start] - '0' == 0 && (word.Length !=0 || !word[index].Equals("")))
                        return false;
                    while(start < m && Char.IsDigit(abbr[start]))
                    {
                        num = num * 10 + (abbr[start] - '0');
                        start++;
                    }

                    if(start < m)
                    {
                        bool flag = false;
                        for(int j = word.IndexOf(abbr[start]); j > -1; j = word.IndexOf(abbr[start],j+1))
                        {
                            if(j - index  == num)
                            {
                                flag = true;
                                break;
                            }
                        }

                        if (flag)
                        {
                            index += num;
                        }
                        else
                            return false;
                    }

                    else
                    {
                        if (word.Substring(index).Length != num)
                            return false;

                    }
                }
            }

            return true;
        }
    }
}
