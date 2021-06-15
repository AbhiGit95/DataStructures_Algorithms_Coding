using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Comp_Coding
{
    class Reformat_Phone_Number
    {
        public string ReformatNumber(string number)
        {
            if (String.IsNullOrEmpty(number))
                return string.Empty;

            string[] array = number.Split(new char[] { ' ', '-' }, StringSplitOptions.RemoveEmptyEntries);
            string arr = string.Join("", array);

            if (arr.Length <= 4)
            {
                return arr.Length == 4 ? helper(arr, true,0) : helper(arr, false,0);
            }

            StringBuilder sb = new StringBuilder();
            int i = 0; int n = arr.Length;

            while(n - i > 4)
            {
                for (int j = i; j < i + 3; j++)
                    sb.Append(arr[j]);

                sb.Append('-');
                i += 3;
            }

            string s = sb.ToString();
            string rem = n - i == 4 ? helper(arr, true, i) : helper(arr,false,i);

            return s + rem;
        }

        public string helper(string arr, bool flag, int index)
        {
            StringBuilder sb = new StringBuilder();
            int count = 0;

            if (flag)
            { 
                while(index < arr.Length)
                {
                    if (count == 2)
                        sb.Append('-');

                    sb.Append(arr[index]);
                    count++; index++;
                }
            }
            else
            {
                while(index < arr.Length)
                {
                    sb.Append(arr[index]);
                    index++;
                }
            }

            return sb.ToString();
        }
    }
}
