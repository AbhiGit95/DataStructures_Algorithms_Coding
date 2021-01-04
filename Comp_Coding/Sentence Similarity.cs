using System;
using System.Collections.Generic;
using System.Text;

namespace Comp_Coding
{
    class Sentence_Similarity
    {
        public bool AreSentencesSimilar(string[] sentence1, string[] sentence2, IList<IList<string>> similarPairs)
        {
            if (sentence1.Length != sentence2.Length)
                return false;

            if (similarPairs.Count == 0 || similarPairs == null)
            {
                for (int i = 0; i < sentence1.Length; i++)
                {
                    if (sentence1[i] != sentence2[i])
                        return false;
                }
            }

            Dictionary<string, HashSet<string>> map = new Dictionary<string, HashSet<string>>();

            for (int i = 0; i < similarPairs.Count; i++)
            {
                if (!map.ContainsKey(similarPairs[i][0]))
                {
                    map.Add(similarPairs[i][0], new HashSet<string>() { similarPairs[i][1] });
                }

                else
                {
                    map[similarPairs[i][0]].Add(similarPairs[i][1]);
                }

                if (!map.ContainsKey(similarPairs[i][1]))
                {
                    map.Add(similarPairs[i][1], new HashSet<string>() { similarPairs[i][0] });
                }

                else
                {
                    map[similarPairs[i][1]].Add(similarPairs[i][0]);
                }
            }

            for (int i = 0; i < sentence1.Length; i++)
            {
                if (sentence1[i] != sentence2[i] && (!map.ContainsKey(sentence1[i]) || !map.ContainsKey(sentence2[i])))
                {
                    return false;
                }

                else if (sentence1[i] != sentence2[i])
                {
                    if (map.ContainsKey(sentence1[i]) && !map[sentence1[i]].Contains(sentence2[i]))
                        return false;
                    else if (map.ContainsKey(sentence2[i]) && !map[sentence2[i]].Contains(sentence1[i]))
                        return false;
                }

            }

            return true;
        }
    }
}
