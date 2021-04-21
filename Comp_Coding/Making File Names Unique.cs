using System;
using System.Collections.Generic;
using System.Text;

namespace Comp_Coding
{
    class Making_File_Names_Unique
    {
        public string[] GetFolderNames(string[] names)
        {
            Dictionary<string, int> map = new Dictionary<string, int>();
            string[] result = new string[names.Length];
            int i = 0;

            //["pes","fifa","gta","pes(2019)"]

            foreach (string name in names)
            {
                int index = name.IndexOf('(') == -1 ? name.Length : name.IndexOf('(');
                string temp = name.Substring(0, index);
                //The name doesnt exist with parenthesis
                if (index == -1)
                {
                    if (map.ContainsKey(temp))
                    {
                        map[temp] += 1;
                    }
                    else
                    {
                        map.Add(temp, 1);
                    }

                    if (map[temp] > 1)
                        result[i] = temp + '(' + map[temp] + ')';
                    else
                        result[i] = temp;
                }
                //The name already comes with a parenthesis
                else
                {
                    if (map.ContainsKey(name))
                    {
                        map[name] += 1;
                        result[i] = name + '(' + map[name] + ')';
                    }
                    else
                    {
                        map.Add(name, 1);
                        result[i] = name;
                    }
                }
                i++;
            }
            return result;
        }
    }
}
