using System;
using System.Collections.Generic;
using System.Text;

namespace Comp_Coding
{
    class Convert_Binary_Search_Tree_to_Sorted_Doubly_Linked_List
    {
        List<Node> nodes = new List<Node>();
        public Node TreeToDoublyList(Node root)
        {
            if (root == null)
                return null;

            inorder(root);

            Node dummy = new Node(-1);
            Node current = dummy;

            foreach (Node n in nodes)
            {
               // Console.WriteLine(n.val);
                if (current == dummy)
                {
                    dummy.right = n;
                    n.left = dummy;
                    n.right = dummy;
                    current = current.right;
                    dummy.left = n;
                    //Console.WriteLine("Done");
                }
                else
                {
                    dummy.left = n;
                    n.right = current.right;
                    current.right = n;
                    n.left = current;
                    current = current.right;
                    //Console.WriteLine("done2");
                }
            }


            
            Node head = dummy.right;
            Node tail = dummy.left;
            head.left = tail;
            tail.right = head;
            return head;
        }

        public void inorder(Node root)
        {
            if (root == null)
                return;
            inorder(root.left);
            nodes.Add(root);
            inorder(root.right);
        }
    }
}
