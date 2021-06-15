using System;
using System.Collections.Generic;
using System.Text;

namespace Comp_Coding
{
    class Before_and_After_Puzzle
    {
        public IList<string> BeforeAndAfterPuzzles(string[] phrases)
        {
            Dictionary<string, List<(string, int)>> mapPhrases = new Dictionary<string, List<(string, int)>>();

            int n = phrases.Length;

            for (int i = 0; i < n; i++)
            {

                if(phrases[i].IndexOf(' ') == -1)
                {
                    if(mapPhrases.ContainsKey(phrases[i]))
                    {
                        mapPhrases[phrases[i]].Add((string.Empty, i));
                    }
                    else
                    {
                        mapPhrases.Add(phrases[i], new List<(string, int)>() { (string.Empty, i) });
                    }
                }

                else
                {
                    var firstWord =  phrases[i].Substring(0, phrases[i].IndexOf(' '));

                    var phraseToAdd = phrases[i].Substring(phrases[i].IndexOf(' ') + 1, phrases[i].Length - phrases[i].IndexOf(' ') - 1);

                    if (mapPhrases.ContainsKey(firstWord))
                    {

                        mapPhrases[firstWord].Add((phraseToAdd, i));
                    }
                    else
                    {
                        mapPhrases.Add(firstWord, new List<(string, int)>() { (phraseToAdd, i) });
                    }
                }
                
            }

            HashSet<string> set = new HashSet<string>();

            for (int i = 0; i < n; i++)
            {
                string lastWord = string.Empty;

                if (phrases[i].IndexOf(' ') == -1)
                    lastWord = phrases[i];
                else
                    lastWord = phrases[i].Substring(phrases[i].LastIndexOf(' ') + 1, phrases[i].Length - phrases[i].LastIndexOf(' ') - 1);

                if (mapPhrases.ContainsKey(lastWord))
                {
                    foreach (var pair in mapPhrases[lastWord])
                    {
                        if (pair.Item2 != i)
                        {
                            if(pair.Item1 == string.Empty)
                            {
                                set.Add(phrases[i]);
                            }
                            else
                                set.Add(phrases[i] + " " + pair.Item1);
                        }
                    }
                }
            }

            List<string> result = new List<string>(set);
            result.Sort();

            return result;
        }
    }
}
