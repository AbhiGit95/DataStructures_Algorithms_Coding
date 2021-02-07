using System;
using System.Collections.Generic;
using System.Text;

namespace Comp_Coding
{
    class BSTIteratorII
    {
        List<int> lst;
        int pointer;

        public BSTIteratorII(TreeNode root)
        {
            lst = new List<int>();
            pointer = -1;
            inorder(root);
        }

        public void inorder(TreeNode node)
        {
            if (node == null)
            {
                return;
            }

            inorder(node.left);
            lst.Add(node.val);
            inorder(node.right);
        }

        public bool HasNext()
        {
            if (pointer < lst.Count - 1)
                return true;
            else
                return false;
        }

        public int Next()
        {

            pointer++;
            if (pointer >= lst.Count)
                return -1;
            else
            {
                return lst[pointer];

            }
        }

        public bool HasPrev()
        {
            if (pointer <= 0)
                return false;
            else
                return true;
        }

        public int Prev()
        {
            pointer--;
            return lst[pointer];
        }
    }
}
