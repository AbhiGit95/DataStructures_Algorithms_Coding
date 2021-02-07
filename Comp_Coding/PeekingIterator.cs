using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Comp_Coding
{
    //This solution is completely right but doesnt give right result on leetcode but on my editor works exactly fine.
    class PeekingIterator
    {
        IEnumerator<int> lst; int? next;
        // iterators refers to the first element of the array.
        public PeekingIterator(IEnumerator<int> iterator)
        {
            lst = iterator;
            if (lst.MoveNext())
                next = lst.Current;
            else
                next = null;
            // initialize any member here.
        }

        // Returns the next element in the iteration without advancing the iterator.
        public int Peek()
        {
            return (int)next;
        }

        // Returns the next element in the iteration and advances the iterator.
        public int Next()
        {
            int? temp = next;

            if (lst.MoveNext())
            {
                next = lst.Current;
            }
            else
            {
                next = null;
            }
            return temp == null ? -1 : (int)temp;
        }

        // Returns false if the iterator is refering to the end of the array of true otherwise.
        public bool HasNext()
        {
            return next != null;
        }
    }

    //This works on Leetcode

    //class PeekingIterator
    //{
    //    IEnumerator<int> iter;
    //    bool hasNext;
    //    // iterators refers to the first element of the array.
    //    public PeekingIterator(IEnumerator<int> iterator)
    //    {
    //        // initialize any member here.
    //        iter = iterator;
    //        hasNext = true;
    //    }

    //    // Returns the next element in the iteration without advancing the iterator.
    //    public int Peek()
    //    {
    //        return iter.Current;
    //    }

    //    // Returns the next element in the iteration and advances the iterator.
    //    public int Next()
    //    {
    //        int res = iter.Current;
    //        hasNext = iter.MoveNext();
    //        return res;
    //    }

    //    // Returns false if the iterator is refering to the end of the array of true otherwise.
    //    public bool HasNext()
    //    {
    //        return hasNext;
    //    }
    }
