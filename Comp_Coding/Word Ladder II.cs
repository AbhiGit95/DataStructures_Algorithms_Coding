using System;
using System.Collections.Generic;
using System.Text;

namespace Comp_Coding
{
    class Word_Ladder_II
    {
        IList<IList<string>> result = new List<IList<string>>();

        public IList<IList<string>> FindLadders(string beginWord, string endWord, IList<string> wordList)
        {
            // create the set for containing each word
            HashSet<string> set = new HashSet<string>();

            foreach (string word in wordList)
            {
                set.Add(word);
            }

            if (!set.Contains(endWord))
                return null;


            // The dictionary will act as an adjacency list
            Dictionary<string, List<string>> adjList = new Dictionary<string, List<string>>();
            adjList.Add(beginWord, helper(beginWord, set));

            foreach (string w in wordList)
            {
                if (!adjList.ContainsKey(w))
                {
                    adjList.Add(w, helper(w, set));
                }
            }

            HashSet<string> visited = new HashSet<string>();

            //Do a Bfs to get the minimum path length
            Queue<(string, int)> bfs = new Queue<(string, int)>();

            bfs.Enqueue((beginWord, 0));

            int? minDist = null;

            while (bfs.Count > 0)
            {
                if (minDist.HasValue)
                    break;

                var node = bfs.Dequeue();
                visited.Add(node.Item1);
                foreach (var word in adjList[node.Item1])
                {
                    if(!visited.Contains(word))
                    {
                        if (word == endWord)
                        {
                            minDist = node.Item2 + 1;
                        }

                        else
                        {
                            bfs.Enqueue((word, node.Item2 + 1));
                        }
                    }
                }
            }

            visited.Clear();
            visited.Add(beginWord);
            foreach (string word in adjList[beginWord])
            {
                if (word == endWord)
                    result.Add(new List<string>() { beginWord, word });
                else
                    DFS(word, adjList, visited, endWord, new List<string>() { beginWord, word }, 1, minDist.Value);
            }

            return result;
        }


        public void DFS(string word, Dictionary<string, List<string>> adjList, HashSet<string> visited, string end, List<string> res, int step, int minDist)
        {
            if (step > minDist)
                return;

            if (word == end)
            {
                result.Add(new List<string>(res));
                return;
            }

            visited.Add(word);

            

            foreach (string next in adjList[word])
            {
                if (!visited.Contains(next))
                {
                    res.Add(next);
                    DFS(next, adjList, visited, end, res, step + 1, minDist);

                    res.RemoveAt(res.Count - 1);
                    if(visited.Contains(next))
                        visited.Remove(next);

                }
            }
        }


        // helper function for generating the adjacency list.
        public List<string> helper(string word, HashSet<string> set)
        {
            char[] arr = word.ToCharArray();
            int n = arr.Length;
            List<string> result = new List<string>();

            for (int i = 0; i < n; i++)
            {
                char original = arr[i];

                for (int j = 0; j < 26; j++)
                {
                    if (arr[i] != j + 'a')
                    {
                        arr[i] = Convert.ToChar(j + 'a');
                        string temp = new string(arr);

                        if (set.Contains(temp))
                        {
                            result.Add(temp);
                        }
                    }

                    arr[i] = original;
                }
            }

            return result;
        }
    }
}
