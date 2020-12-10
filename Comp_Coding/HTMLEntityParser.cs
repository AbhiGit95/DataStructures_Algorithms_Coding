using System;
using System.Collections.Generic;
using System.Text;

namespace Comp_Coding
{
    class HTMLEntityParser
    {
        public string EntityParser(string text)
        {
            Dictionary<string, string> map = new Dictionary<string, string>();
            map.Add("&quot;", "\""); map.Add("&apos;", "\'"); map.Add("&amp;", "&"); 
            map.Add("&gt;", ">"); map.Add("&lt;", "<"); map.Add("&frasl;", "/");

            string[] arr = text.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            StringBuilder sb = new StringBuilder();
            for(int i = 0; i < text.Length; i++)
            {
              if(text[i] == '&')
                {
                    int j = i;
                    while(j < text.Length && !text[j].Equals(';') && !text[j].Equals(' '))
                    {
                        j++;
                    }

                    if(j < text.Length && text[j] == ';')
                    {
                        if(map.ContainsKey(text.Substring(i,j-i+1)))
                        {
                            sb.Append(map[text.Substring(i, j - i + 1)]);
                        }
                        else
                        {
                            sb.Append(text.Substring(i, j - i + 1));
                        }
                    }
                    i = j;
                }
              else
                {
                    sb.Append(text[i]);
                }
            }

            return sb.ToString();
        }
    }
}
