using System;
using System.Collections.Generic;
using System.Text;

namespace Comp_Coding
{
    class Design_Hit_Counter
    {

        /** Initialize your data structure here. */
        Queue<int> counter;
        int start;
        public Design_Hit_Counter()
        {
            counter = new Queue<int>();
            start = 0;
        }

        /** Record a hit.
            @param timestamp - The current timestamp (in seconds granularity). */
        public void Hit(int timestamp)
        {
            if (start == 0)
                start = timestamp;

            counter.Enqueue(timestamp);
            while (counter.Count > 0 && timestamp - counter.Peek() >= 300)
            {
                counter.Dequeue();
            }
        }

        /** Return the number of hits in the past 5 minutes.
            @param timestamp - The current timestamp (in seconds granularity). */
        public int GetHits(int timestamp)
        {
            if (counter.Count > 0)
            {
                if (timestamp - counter.Peek() >= 300)
                {
                    while (counter.Count > 0 && timestamp - counter.Peek() >= 300)
                    {
                        counter.Dequeue();
                    }
                }

                return counter.Count;
            }
            else
                return 0;
        }
    }
}
