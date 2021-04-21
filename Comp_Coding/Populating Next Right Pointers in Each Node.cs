using System;
using System.Collections.Generic;
using System.Text;

namespace Comp_Coding
{
    class Populating_Next_Right_Pointers_in_Each_Node
    {
        //This same solution will work for Populating Next Right Pointers in Each Node II , Question 117 on LeetCode.
        public Node Connect(Node root)
        {
            if (root == null)
                return null;

            Node dummy = new Node(int.MaxValue);
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(root);
            queue.Enqueue(dummy);
            while (queue.Count > 0)
            {
                Node temp = queue.Dequeue();
                if (temp == dummy && queue.Count > 0)
                {
                    queue.Enqueue(dummy);
                }

                else if (temp != dummy)
                {
                    if (queue.Peek() == dummy)
                    {
                        temp.next = null;
                    }
                    else
                    {
                        temp.next = queue.Peek();
                    }

                    if (temp.left != null)
                    {
                        queue.Enqueue(temp.left);
                    }
                    if (temp.right != null)
                    {
                        queue.Enqueue(temp.right);
                    }
                }
            }
            return root;
        }
    }

    public class Node
    {
        public int val;
        public Node left;
        public Node right;
        public Node next;

        public Node() { }

        public Node(int _val)
        {
            val = _val;
        }

        public Node(int _val, Node _left, Node _right, Node _next)
        {
            val = _val;
            left = _left;
            right = _right;
            next = _next;
        }
    }
}
