using System;
using System.Collections.Generic;
using System.Text;

namespace Comp_Coding
{
    class ExpressiveWords
    {
        public int ExpressiveWords2(string S, string[] words)
        {
            if (S == "" || S.Trim() == "" || S == null)
                return 0;
            Encoded_String main_word = StringEncoding(S);
            bool flag = true; int result = 0;
           foreach (string w in words)
            {
                flag = true;
                Encoded_String temp = StringEncoding(w);
                if (!main_word.key.Equals(temp.key))
                {
                    flag = false;
                }
                else
                {
                    for(int i = 0; i < main_word.count.Count; i++)
                    {
                        int x = main_word.count[i];
                        int y = temp.count[i];
                        // If the count of the character in main word is less than querie word then it is not possible
                        // If the count of the character in main word is less than 3 and it is not equal to temp word then not possible
                        if (x < 3 && x != y || (y > x))
                        {
                            flag = false;
                            break;
                        }
                    }
                }
                if (flag)
                    result += 1;
            }
            return result;
        }

        public Encoded_String StringEncoding(string S)
        {
            List<int> count = new List<int>();
            int c = 1; StringBuilder sb = new StringBuilder();
            for(int i = 1; i < S.Length; i++)
            {
                if (S[i] == S[i - 1])
                    c += 1;
                else
                {
                    count.Add(c);
                    sb.Append(S[i - 1]);
                    c = 1;
                }
            }

            count.Add(c);
            sb.Append(S[S.Length - 1]);

            return new Encoded_String(sb.ToString(), count);
        }

        public class Encoded_String
        {
           public string key;
           public List<int> count;

            public Encoded_String(string k, List<int> c)
            {
                this.key = k;
                this.count = c;
            }
        }
    }
}
