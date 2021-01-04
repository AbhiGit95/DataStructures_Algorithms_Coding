using System;
using System.Collections.Generic;
using System.Text;

namespace Comp_Coding
{
    public class ValidWordAbbr
    {
        Dictionary<string, HashSet<string>> map;
        StringBuilder sb;
        public ValidWordAbbr(string[] dictionary)
        {
            map = new Dictionary<string, HashSet<string>>();
            foreach (string word in dictionary)
            {
                if (word.Length <= 2)
                {
                    if (map.ContainsKey(word))
                    {
                        map[word].Add(word);
                    }
                    else
                    {
                        map.Add(word, new HashSet<string>() { word });
                    }
                }
                else
                {
                    string temp = abbreviator(word);
                    if (map.ContainsKey(temp))
                    {
                        map[temp].Add(word);
                    }
                    else
                    {
                        map.Add(temp, new HashSet<string>() { word });
                    }
                }
            }
        }

        public bool IsUnique(string word)
        {
            if (word.Length <= 2)
            {
                return true;
            }
            else
            {
                string temp = abbreviator(word);
                if (map.ContainsKey(temp) && !map[temp].Contains(word))
                    return false;
                else if (map.ContainsKey(temp) && map[temp].Count > 1)
                    return false;

                return true;
            }

        }

        public string abbreviator(string word)
        {
            sb = new StringBuilder();
            sb.Append(word[0]);
            sb.Append(word.Length - 2);
            sb.Append(word[word.Length - 1]);
            return sb.ToString();
        }
    }

}
