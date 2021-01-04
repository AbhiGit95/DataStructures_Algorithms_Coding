using System;
using System.Collections.Generic;
using System.Text;

namespace Comp_Coding
{
    class Design_HashSet
    {
        List<int>[] hashset;
        int size;
        public Design_HashSet()
        {
            size = 71;
            hashset = new List<int>[size];


            for (int i = 0; i < size; i++)
            {
                hashset[i] = new List<int>();
            }
        }

        public void Add(int key)
        {
            int location = key % size;
            if (hashset[location].Count == 0)
                hashset[location].Add(key);
            else
            {
                bool found = false;
                foreach (int k in hashset[location])
                {
                    if (k == key)
                    {
                        found = true;
                        break;
                    }
                }
                if (!found)
                    hashset[location].Add(key);
            }
        }

        public void Remove(int key)
        {
            int location = key % size;
            if (hashset[location].Count != 0)
            {
                foreach (int n in hashset[location])
                {
                    if (n == key)
                    {
                        hashset[location].Remove(key);
                        break;
                    }
                }
            }
        }

        /** Returns true if this set contains the specified element */
        public bool Contains(int key)
        {
            int location = key % size;
            if (hashset[location].Count == 0)
                return false;

            else
            {
                foreach (int k in hashset[location])
                {
                    if (k == key)
                    {
                        return true;
                    }
                }
                return false;
            }
        }
    }
}
