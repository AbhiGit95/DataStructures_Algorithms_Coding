using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Comp_Coding
{
    class Vowel_Spellchecker
    {
        HashSet<string> wordset;
        Dictionary<string, string> map_for_Case;
        Dictionary<string, string> map_for_Vowels;
        public string[] Spellchecker(string[] wordlist, string[] queries)
        {
            //This will help in checking if the query word exists in the wordset or not
             wordset = new HashSet<string>();
            //To check if case ignore match word exists.
            map_for_Case = new Dictionary<string, string>();
            map_for_Vowels = new Dictionary<string, string>();

            foreach (string word in wordlist)
            {
                wordset.Add(word);

                string word_lower = word.ToLower();

                if (!map_for_Case.ContainsKey(word_lower))
                {
                    map_for_Case.Add(word_lower, word);
                }

                string word_vow = Vowel_Mask(word_lower);

                if(!map_for_Vowels.ContainsKey(word_vow))
                {
                    map_for_Vowels.Add(word_vow, word);
                }
            }

            string[] result = new string[queries.Length];

            for(int i = 0; i < queries.Length; i++)
            {
                result[i] = wordforquery(queries[i]);
            }

            return result;
        }


        public string wordforquery(string query)
        {
            if (wordset.Contains(query))
                return query;

            string query_lower = query.ToLower();
            if (map_for_Case.ContainsKey(query_lower))
            {
                return map_for_Case[query_lower];    
            }

            string query_vowel = Vowel_Mask(query_lower);

            if (map_for_Vowels.ContainsKey(query_vowel))
                return map_for_Vowels[query_vowel];

            return null;
        }

        public string Vowel_Mask(string word)
        {
            StringBuilder sb = new StringBuilder();
           foreach(char c in word)
            {
                if (isAVowel(c))
                    sb.Append('*');
                else
                    sb.Append(c);
            }
            return sb.ToString();
        }

        public bool isAVowel(char c)
        {
            if (c == 'a' || c == 'e' || c == 'o' || c == 'i' || c == 'u')
                return true;
            return false;
        }
    }
}
