using System;
using System.Collections.Generic;
using System.Text;

namespace Comp_Coding
{
    class SortList
    {
        //Naive method : Can use Merge Sort for better performance
        public ListNode SortLinkedList(ListNode head)
        {
            List<int> list = new List<int>();
            ListNode temp = head;
            while(temp != null)
            {
                list.Add(temp.val);
                temp = temp.next;
            }

            list.Sort();
            ListNode dummy = new ListNode(0);
            ListNode dummy2 = dummy;
            foreach(int n in list)
            {
                ListNode node = new ListNode(n);
                dummy2.next = node;
                dummy2 = dummy2.next;
            }

            return dummy.next;
        }
    }

    public class LinkedListSorter : IComparer<int>
    {
        public int Compare(int x, int y)
        {
            return x.CompareTo(y);
        }
    }
    public class ListNode
    {
      public int val;
      public ListNode next;
      public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
  }

}