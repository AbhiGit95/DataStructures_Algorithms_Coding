using System;
using System.Collections.Generic;
using System.Text;

namespace Comp_Coding
{
    class OrderedStream
    {
        string[] arr; int ptr;
        public OrderedStream(int n)
        {
            arr = new string[n];
            Array.Fill(arr, "default");
            ptr = 0;
        }

        public IList<string> Insert(int id, string value)
        {
            arr[id - 1] = value;
            IList<string> result = new List<string>();

            while (ptr < arr.Length && !arr[ptr].Equals(null))
            {
                result.Add(arr[ptr]);
                ptr++;

            }
            return result;
        }
    }
}
