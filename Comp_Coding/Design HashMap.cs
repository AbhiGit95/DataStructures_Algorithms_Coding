using System;
using System.Collections.Generic;
using System.Text;

namespace Comp_Coding
{
    class Design_HashMap
    {
        public class Point
        {
            public int p1;
            public int p2;

            public Point(int x, int y)
            {
                this.p1 = x; this.p2 = y;
            }
        }

        /** Initialize your data structure here. */
        List<Point>[] hmap;
        int size;
        public Design_HashMap()
        {
            this.size = 71;
            this.hmap = new List<Point>[size];
            for (int i = 0; i < size; i++)
            {
                hmap[i] = new List<Point>();
            }
        }

        /** value will always be non-negative. */
        public void Put(int key, int value)
        {
            int location = key % this.size;
            if (hmap[location].Count == 0)
            {
                hmap[location].Add(new Point(key, value));
            }

            else
            {
                bool found = false;
                foreach (Point p in hmap[location])
                {
                    if (p.p1 == key)
                    {
                        found = true;
                        p.p2 = value;
                        break;
                    }
                }

                if (!found)
                {
                    hmap[location].Add(new Point(key, value));
                }
            }
        }

        /** Returns the value to which the specified key is mapped, or -1 if this map contains no mapping for the key */
        public int Get(int key)
        {
            int location = key % this.size;
            if (hmap[location].Count == 0)
                return -1;

            foreach (Point p in hmap[location])
            {
                if (p.p1 == key)
                {
                    return p.p2;
                }
            }
            return -1;
        }

        /** Removes the mapping of the specified value key if this map contains a mapping for the key */
        public void Remove(int key)
        {
            int location = key % this.size;

            if (hmap[location].Count != 0)
            {
                for (int i = 0; i < hmap[location].Count; i++)
                {
                    if (hmap[location][i].p1 == key)
                    {
                        hmap[location].RemoveAt(i);
                        break;
                    }
                }
            }
        }
    }
}
