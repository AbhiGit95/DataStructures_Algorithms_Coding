using System;
using System.Collections.Generic;
using System.Text;

namespace Comp_Coding
{
    class SubDomainVisitCount
    {
        public IList<string> SubdomainVisits(string[] cpdomains)
        {
            Dictionary<string, int> map = new Dictionary<string, int>();

            foreach(string s in cpdomains)
            {
                string[] temp = s.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                int visit = Convert.ToInt32(temp[0]);
                if(map.ContainsKey(temp[1]))
                {
                    map[temp[1]] += visit;
                }
                else
                {
                    map.Add(temp[1], visit);
                }
                for(int i = temp[1].IndexOf("."); i != -1; i = temp[1].IndexOf(".",i+1))
                {
                    string subdomain = temp[1].Substring(i + 1);
                    if (map.ContainsKey(subdomain))
                    {
                        map[subdomain] += visit;
                    }
                    else
                    {
                        map.Add(subdomain, visit);
                    }
                }
            }

            IList<string> result = new List<string>();

            foreach(KeyValuePair<string,int>kv in map)
            {
                result.Add(Convert.ToString(kv.Key) + " " + kv.Key);
            }
            return result;
        }
    }
}
