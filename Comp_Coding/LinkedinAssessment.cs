using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;

namespace Comp_Coding
{
    class LinkedinAssessment
    {
        public static int barterMarket(int comicBooks, int coins, int coinsNeeded, int coinsOffered)
        {
            int result = 0;

            while (comicBooks > 0 && coins > 0)
            {
                if (coins >= coinsNeeded)
                {
                    coins -= coinsNeeded;
                    comicBooks--;
                    result++;
                }
                if (comicBooks > 0 && coins < coinsNeeded)
                {
                    coins += coinsOffered;
                    comicBooks--;
                }
            }
            return result;
        }
        public static long largestRepackaged(List<int> arrivingPackets)
        {
            int max = 0;
            long remainderFromPrev = 0;

            for (int i = 0; i < arrivingPackets.Count; i++)
            {
                long currentVal = remainderFromPrev + arrivingPackets[i];
                int powerOfTwo = getPowerOfTwo(currentVal);
                max = Math.Max(max, powerOfTwo);
                remainderFromPrev = currentVal - (1 << powerOfTwo);
            }
            return 1 << max;
        }

        private static int getPowerOfTwo(long currentVal)
        {
            // The limit on the number is 10^9 which will be less than 2^31
            for (int i = 0; i <= 32; i++)
            {
                long limit = 1 << i;
                if (currentVal < limit)
                {
                    return i - 1;
                }
            }
            return 0;
        }

        public static void findStartAndEndLocations(List<String[]> pairs)
        {
            //Creating the adjacency list
            Dictionary<string, SortedSet<string>> adj_list = new Dictionary<string, SortedSet<string>>();
            SortedDictionary<string, int> map_degrees = new SortedDictionary<string, int>();
            foreach(String[] p in pairs)
            {
                if(adj_list.ContainsKey(p[0]))
                {
                    adj_list[p[0]].Add(p[1]);
                }
                else
                {
                    adj_list.Add(p[0], new SortedSet<string>() { p[1] });
                }

                //add the other vertex as well
                if(!adj_list.ContainsKey(p[1]))
                {
                    adj_list.Add(p[1], new SortedSet<string>());
                }
                

                if(map_degrees.ContainsKey(p[1]))
                {
                    map_degrees[p[1]] += 1;
                }
                else
                {
                    map_degrees.Add(p[1], 1);
                }

                if(!map_degrees.ContainsKey(p[0]))
                {
                    map_degrees.Add(p[0], 0);                
                }
            }

            Dictionary<string,List<string>> result = new Dictionary<string,List<string>>();
            
            foreach(KeyValuePair<string,int> kv in map_degrees)
            {
                if (kv.Value == 0)
                {
                    HashSet<string> visited = new HashSet<string>();
                    List<string> res = new List<string>(); 
                    res = DFS(kv.Key, adj_list, visited,res);
                    result.Add(kv.Key,res);
                }
                
            }

            foreach(KeyValuePair<string,List<string>> kv in result)
            {
                Console.Write(kv.Key + ": " );
                foreach(string s in result[kv.Key])
                {
                    Console.Write(s + " ");
                }
                Console.WriteLine();
            }
        }

        public static List<string> DFS(string start, Dictionary<string, SortedSet<string>> adj_list, HashSet<string> visited, List<string> res)
        {
            if(!visited.Contains(start))
            {
                visited.Add(start);
                if (adj_list[start].Count == 0)
                     res.Add(start);
                else
                {
                    foreach (String v in adj_list[start])
                        DFS(v, adj_list, visited, res);
                }
            }
            return res;
        }


        public static long highestProfit(int numSuppliers, List<long> inventory, long order)
        {
            SortedDictionary<long, int> count = new SortedDictionary<long, int>(new inventory_comparer());

            foreach(long l in inventory)
            {
                if (count.ContainsKey(l))
                    count[l] += 1;
                else
                    count.Add(l, 1);
            }

            long profit = 0;
            long current_order = order;
            while(current_order > 0)
            {
                long key = count.First().Key;
               
                if(count[key] >= current_order)
                {
                    profit += (current_order * key);
                    break;
                }
                else
                {
                    profit += count[key] * key;
                    current_order -= count[key];
                    long new_key = key - 1;
                    int new_val = count[key];
                    count.Remove(key);

                    if (count.ContainsKey(new_key))
                    {
                        count[new_key] += new_val;
                    }
                    else
                        count.Add(new_key, new_val);
                }
            }
            return profit;
        }

        public class inventory_comparer : IComparer<long>
        {
            public int Compare(long x,  long y)
            {
                if (x > y)
                    return -1;
                else if (x < y)
                    return 1;
                else
                    return 0;
            }
        }
    }
}
