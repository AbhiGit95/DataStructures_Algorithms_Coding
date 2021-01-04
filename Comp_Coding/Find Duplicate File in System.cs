using System;
using System.Collections.Generic;
using System.Text;

namespace Comp_Coding
{
    class Find_Duplicate_File_in_System
    {
        public IList<IList<string>> FindDuplicate(string[] paths)
        {
            IList<IList<string>> result = new List<IList<string>>();

            if (paths == null || paths.Length == 0)
                return result;

            Dictionary<string, List<string>> map = new Dictionary<string, List<string>>();
            
            foreach(string s in paths)
            {
                string[] temp = s.Split(new string[] { " ", "." }, StringSplitOptions.RemoveEmptyEntries);
                string path = temp[0];
                for(int i = 2; i < temp.Length; i+= 2)
                {
                    if(map.ContainsKey(temp[i]))
                    {
                        map[temp[i]].Add(path + "/" + temp[i - 1]);
                    }
                    else
                    {
                        map.Add(temp[i], new List<string>() { path + "/" + temp[i - 1] });
                    }
                }
            }

            foreach(string k in map.Keys)
            {
                if(map[k].Count > 1)
                {
                    string app = k.Substring(0, k.IndexOf("("));
                    IList<string> middle_list = new List<string>();
                    foreach(string s in map[k])
                    {
                        middle_list.Add(s + "." + app);
                    }
                    result.Add(middle_list);
                }
            }

            return result;
        }
    }
}
