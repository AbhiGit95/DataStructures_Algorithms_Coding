using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Comp_Coding
{
    class DesignAleaderboard
    {
        Dictionary<int, int> map;

        public DesignAleaderboard()
        {
            map = new Dictionary<int, int>();
        }

        public void AddScore(int playerId, int score)
        {
            if (!map.ContainsKey(playerId))
            {
                map.Add(playerId, score);
            }
            else
            {
                map[playerId] += score;
            }
        }

        public int Top(int K)
        {
            int count = 0;
            int result = 0;

            foreach (KeyValuePair<int, int> kv in map.OrderByDescending(x => x.Value))
            {
                if (count < K)
                {
                    result += kv.Value;
                    count += 1;
                }
            }

            return result;
        }

        public void Reset(int playerId)
        {
            map.Remove(playerId);
        }
    }
}
