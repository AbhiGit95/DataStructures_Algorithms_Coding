using System;
using System.Collections.Generic;
using System.Text;

namespace Comp_Coding
{
    class FileSystem
    {
        Dictionary<string, int> map;
        public FileSystem()
        {
            map = new Dictionary<string, int>();
        }

        public bool CreatePath(string path, int value)
        {
            //[[],["/leet",1],["/leet/code",2],["/leet/code"],["/c/d",1],["/c"]]
            string parent = path.Substring(0, path.LastIndexOf('/'));
            if (parent.Length == 0)// Only /
            {
                //Check if path already exists or not
                if (map.ContainsKey(path))
                {
                    return false;
                }
                else
                {
                    map.Add(path, value);
                }
            }
            else
            {
                //Check if parent exists or not
                if (map.ContainsKey(parent))
                {
                    //Check if path already exists or not
                    if (map.ContainsKey(path))
                    {
                        return false; ;
                    }
                    else
                    {
                        map.Add(path, value);
                    }
                }
                else
                    return false;
            }
            return true;
        }

        public int Get(string path)
        {
            if (map.ContainsKey(path))
                return map[path];
            else
                return -1;
        }
    }
}
