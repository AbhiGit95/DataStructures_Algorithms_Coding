using System;
using System.Collections.Generic;
using System.Text;

namespace Comp_Coding
{
    // Faster than 100% online submissions of C#
    class DoublyLinkedList
    {
        public string val;
        public DoublyLinkedList prev;
        public DoublyLinkedList next;
        public DoublyLinkedList(string value, DoublyLinkedList prev, DoublyLinkedList next)
        {
            this.val = value;
            this.prev = prev;
            this.next = next;
        }
    }
    class BrowserHistory
    {
        DoublyLinkedList head;
        DoublyLinkedList current;
        public BrowserHistory(string homepage)
        {
            head = new DoublyLinkedList(homepage, null, null);
            current = head;
        }

        public void Visit(string url)
        {
            DoublyLinkedList node = new DoublyLinkedList(url, current, null);
            current.next = node;
            current = node;
        }

        public string Back(int steps)
        {
            int count = 0;
            while(current.prev != null && count != steps)
            {
                current = current.prev;
                count += 1;
            }

            return current.val;
        }

        public string Forward(int steps)
        {
            int count = 0;
            while(current.next != null && count != steps)
            {
                current = current.next;
                count += 1;
            }
            return current.val;
        }
    }
}
