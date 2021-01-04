using System;
using System.Collections.Generic;
using System.Text;

namespace Comp_Coding
{
    class PhoneDirectory
    {
        /** Initialize your data structure here
       @param maxNumbers - The maximum numbers that can be stored in the phone directory. */
        HashSet<int> available;
        HashSet<int> taken;
        public PhoneDirectory(int maxNumbers)
        {
            available = new HashSet<int>();
            taken = new HashSet<int>();
            for (int i = 0; i < maxNumbers; i++)
            {
                available.Add(i);
            }
        }

        /** Provide a number which is not assigned to anyone.
            @return - Return an available number. Return -1 if none is available. */
        public int Get()
        {
            if (available.Count == 0)
                return -1;

            IEnumerator<int> enumerator = available.GetEnumerator();
            enumerator.MoveNext();
            int num = enumerator.Current;
            taken.Add(num);
            available.Remove(num);
            return num;
        }

        /** Check if a number is available or not. */
        public bool Check(int number)
        {
            if (taken.Contains(number))
                return false;
            return true;
        }

        /** Recycle or release a number. */
        public void Release(int number)
        {
            if(taken.Contains(number))
            {
                taken.Remove(number);
            }
            available.Add(number);
        }
    }
}
