using System;
using System.Collections.Generic;
using System.Text;

namespace Comp_Coding
{
    class Merge_k_Sorted_Lists
    {
        //Accepted but runtime is very low.0
        public ListNode MergeKLists(ListNode[] lists)
        {
            int n = lists.Length;
            ListNode merger = null;
            for (int i = 1; i < n; i++)
             {
                merger = merge2Lists(merger, lists[i]);
             }
            return merger;
        }

        public ListNode merge2Lists(ListNode a, ListNode b)
        {
            ListNode head = null;
            ListNode current = null;
            while(a != null && b != null)
            {
                if(a.val <= b.val)
                {
                    //set the head
                    if(head == null)
                    {
                        head = a;
                        current = head;
                    }
                    else
                    {
                        current.next = new ListNode(a.val);
                        current = current.next;
                    }
                    a = a.next;
                }
                else
                {
                    //set the head
                    if(head == null)
                    {
                        head = b;
                        current = head;
                    }
                    else
                    {
                        current.next = new ListNode(b.val);
                        current = current.next;
                    }
                    b = b.next;
                }
            }

            while (a != null)
            {
                if(head == null)
                {
                    head = a;
                    current = head;
                }
                else
                {
                    current.next = new ListNode(a.val);
                    current = current.next;
                }
                a = a.next;
            }

            while (b != null)
            {
                if (head == null)
                {
                    head = b;
                    current = head;
                }
                else
                {
                    current.next = new ListNode(b.val);
                    current = current.next;
                }
                b = b.next;
            }

            return head;
        }
    }
}
