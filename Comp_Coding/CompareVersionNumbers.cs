using System;
using System.Collections.Generic;
using System.Text;

namespace Comp_Coding
{
    class CompareVersionNumbers
    {
        public int CompareVersion(string version1, string version2)
        {
            string[] v1 = version1.Split(".", StringSplitOptions.RemoveEmptyEntries);
            string[] v2 = version2.Split(".", StringSplitOptions.RemoveEmptyEntries);

            for(int a = 0; a < v1.Length; a++)
            {
                if(v1[a][0] == '0' && v1[a].Length > 1)
                {
                    int k = 0;
                    while (k != v1[a].Length - 1 && v1[a][k] == '0')
                        k++;

                    v1[a] = v1[a].Substring(k);
                }
            }

            for (int a = 0; a < v2.Length; a++)
            {
                if (v2[a][0] == '0' && v2[a].Length > 1)
                {
                    int k = 0;
                    while (k != v2[a].Length - 1 && v2[a][k] == '0')
                        k++;

                    v2[a] = v2[a].Substring(k);
                }
            }


            int i = 0; int j = 0;

            while(i < v1.Length && j < v2.Length)
            {
                if(v1[i].CompareTo(v2[j]) == 0)
                {
                    i++; j++;
                }
                else
                {
                    return (Convert.ToInt32(v1[i]).CompareTo(Convert.ToInt32(v2[j])));
                }
            }

            while(i < v1.Length)
            {
                if (v1[i].CompareTo("0") == 1)
                    return 1;
                i++;
            }

            while(j < v2.Length)
            {
                if (v2[j].CompareTo("0") == 1)
                    return -1;
                j++;
            }

            return 0;
        }
    }
}
