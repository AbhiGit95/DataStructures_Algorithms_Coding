using System;
using System.Collections.Generic;
using System.Text;

namespace Comp_Coding
{
    class DLL
    {
        public int value;
        public DLL next;
        public DLL(int val, DLL next)
        {
            this.value = val; this.next = next;
        }
    }
    class MyCircularQueue
    {
        int capacity;
        int size;
        DLL front;
        DLL rear;
        public MyCircularQueue(int k)
        {
            capacity = k; size = k;
            front = new DLL(-1, null);
            rear = front;
        }

        public bool EnQueue(int value)
        {
            if (capacity == 0)
                return false;

            if(front.value == -1)
            {
                front.value = value;
                rear = front;
            }

            else
            {
                DLL node = new DLL(value, null);
                rear.next = node;
                node.next = front;
                rear = node;
            }
            capacity -= 1;
            return true;
        }

        public bool DeQueue()
        {
            if (capacity == size)
                return false;

            //single value present in queue
            else if(capacity == size - 1)
            {
                front.value = -1;
                rear.value = -1;

            }

            else
            {
                front = front.next;
                rear.next = front;
            }

            capacity += 1;
            return true;
        }

        public int Front()
        {
            if (capacity == size)
                return -1;

            return front.value;
        }

        public int Rear()
        {
            if (capacity == size)
                return -1;

            return rear.value;
        }

        public bool IsEmpty()
        {
            return capacity == size;
        }

        public bool IsFull()
        {
            return capacity == 0;
        }
    }
}
