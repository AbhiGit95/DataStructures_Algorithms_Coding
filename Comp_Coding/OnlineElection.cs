using System;
using System.Collections.Generic;
using System.Text;

namespace Comp_Coding
{
    //Will work but algorithm is slow. Can come up with a better solution.
    public class OnlineElection
    {
        Dictionary<int, int> count;
        Dictionary<int, int> time_vote; int max_time = 0;
        public OnlineElection(int[] persons, int[] times)
        {
            count = new Dictionary<int, int>();
            time_vote = new Dictionary<int, int>();
            int max = 0; int prev_time = 0; int prev_winner = -1; max_time = times[times.Length - 1];
            for (int i = 0; i < persons.Length; i++)
            {
                if (prev_winner == -1)
                    prev_winner = persons[i];

                if (count.ContainsKey(persons[i]))
                {
                    count[persons[i]] += 1;
                }
                else
                {
                    count.Add(persons[i], 1);
                }

                if (count[persons[i]] >= max)
                {
                    while (prev_time < times[i])
                    {
                        time_vote.Add(prev_time, prev_winner);
                        prev_time += 1;
                    }
                    prev_winner = persons[i];
                    time_vote.Add(prev_time, prev_winner);
                    prev_time += 1;
                    max = count[persons[i]];
                }
                else
                {
                    while (prev_time <= times[i])
                    {
                        time_vote.Add(prev_time, prev_winner);
                        prev_time += 1;
                    }
                }
            }
        }

        public int Q(int t)
        {
            if (time_vote.ContainsKey(t))
                return time_vote[t];

            else 
                return time_vote[max_time];
        }
    }
}
