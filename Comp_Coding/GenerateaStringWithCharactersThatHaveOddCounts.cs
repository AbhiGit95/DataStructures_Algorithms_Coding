using System;
using System.Collections.Generic;
using System.Text;

namespace Comp_Coding
{
    class GenerateaStringWithCharactersThatHaveOddCounts
    {
        public string GenerateTheString(int n)
        {
            Random rand = new Random();
            StringBuilder sb = new StringBuilder();
            int[] char_map = new int[26];
            if (n % 2 == 0)
            {
                int x = rand.Next(0, 25);
                char_map[x] = 1;
                for (int i = 1; i <= n - 1; i++)
                {
                    sb.Append((char)(97 + x));
                }
                x = rand.Next(0, 25);
                while (char_map[x] == 1)
                {
                    x = rand.Next(0, 25);
                }
                char_map[x] = 1;
                sb.Append((char)(97 + x));
            }

            else
            {
                int x = rand.Next(0, 25);
                char_map[x] = 1;
                sb.Append((char)(97 + x));
                if (n > 1)
                {
                    x = rand.Next(0, 25);
                    while (char_map[x] == 1)
                    {
                        x = rand.Next(0, 25);
                    }
                    char_map[x] = 1;
                    for (int i = 2; i <= n - 1; i++)
                    {
                        sb.Append((char)(97 + x));
                    }
                    while (char_map[x] == 1)
                    {
                        x = rand.Next(0, 25);
                    }
                    sb.Append((char)(97 + x));
                }
            }

            return sb.ToString();
        }
    }
}
