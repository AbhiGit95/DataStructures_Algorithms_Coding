using System;
using System.Collections.Generic;
using System.Text;

namespace Comp_Coding
{
    public class Rotate_List
    {
        public ListNode RotateRight(ListNode head, int k)
        {
            if (head == null)
                return null;

            int len = getlistlength(head);
            Console.WriteLine(len);

            if (len == 0)
                return head;

            k %= len;
            Console.WriteLine(k);
            if (k == 0)
                return head;

            int head_pos = len - k;
            Console.WriteLine(head_pos);

            ListNode last = head;
            int count = 1;
            while (count < head_pos)
            {
                last = last.next;
                count += 1;
            }
            Console.WriteLine(last.val);

            ListNode newhead = last.next;
            last.next = null;

            ListNode new_head_last = newhead;

            while (new_head_last.next != null)
            {
                new_head_last = new_head_last.next;
            }

            new_head_last.next = head;
            return newhead;
        }

        public int getlistlength(ListNode head)
        {
            int len = 0;
            while(head != null)
            {
                head = head.next;
                len += 1;
            }
            return len;
        }
    }
}
