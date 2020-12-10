using System;
using System.Collections.Generic;
using System.Text;

namespace Comp_Coding
{
    class DecodedStringatIndex
    {
        //1. Naive way will give TLE
        public string DecodeAtIndex(string S, int K)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < S.Length; i++)
            {
                if (char.IsLetter(S[i]))
                {
                    sb.Append(S[i]);
                    if(sb.Length >= K)
                    {
                        string a = sb.ToString();
                        return a[K - 1].ToString();
                    }
                }
                else
                {
                    int x = S[i] - 48;
                    if(sb.Length * (x-1) + sb.Length >= K)
                    {

                    }
                    string y = sb.ToString();
                    for (int j = 1; j < x; j++)
                    {
                        sb.Append(y);
                    }

                    if (sb.Length >= K)
                    {
                        string a = sb.ToString();
                        return (a[K - 1]).ToString();
                    }
                }

            }

            return "";
        }

        //2. The optimized approach

        public string DecodeIndex2(String S, int K)
        {
            long size = 0;
            //calculate the length of the decoded string
            for(int i = 0; i < S.Length; i++)
            {
                if (Char.IsLetter(S[i]))
                    size++;
                else
                    size = size * (S[i] - 48);
            }

            for(int i = S.Length - 1; i >= 0; i--)
            {
                K = Convert.ToInt32(K % size);
                if (K == 0 && Char.IsLetter(S[i]))
                    return S[i].ToString();

                else if (Char.IsDigit(S[i]))
                    size = size / (S[i] - '0');

                else
                    size--;
            }

            return "";
        }
    }
}
