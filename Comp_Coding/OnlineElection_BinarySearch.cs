using System;
using System.Collections.Generic;
using System.Text;

namespace Comp_Coding
{
    class OnlineElection_BinarySearch
    {
        Dictionary<int, int> count;
        Dictionary<int, int> time_vote; int max_time = 0;
        int[] t_copy;
        public OnlineElection_BinarySearch(int[] persons, int[] times)
        {
            t_copy = new int[times.Length];
            for (int i = 0; i < times.Length; i++)
            {
                t_copy[i] = times[i];
            }

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
                    time_vote.Add(times[i], persons[i]);
                    prev_winner = persons[i];
                    max = count[persons[i]];
                }

                else
                {
                    time_vote.Add(times[i], prev_winner);
                }

            }
        }

        public int Q(int t)
        {
            if (time_vote.ContainsKey(t))
                return time_vote[t];

            else if (t > max_time)
                return time_vote[max_time];

            else
            {
                int index = BinarySearch(t_copy, 0, t_copy.Length - 1, t);
                return time_vote[index];
            }
        }

        public int BinarySearch(int[] times, int start, int end, int target)
        {
            if (start > end)
            {
                return times[end];
            }

            int mid = start + (end - start) / 2;
            if (times[mid] == target)
                return times[mid];

            else if (times[mid] > target)
                return BinarySearch(times, start, mid - 1, target);

            else
                return BinarySearch(times, mid + 1, end, target);
        }
    }
}
