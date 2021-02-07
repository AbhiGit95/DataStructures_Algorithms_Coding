using System;
using System.Collections.Generic;
using System.Text;

namespace Comp_Coding
{
    public class BSTIterator
    {
        List<int> lst;
        int pointer;
        public BSTIterator(TreeNode root)
        {
            lst= new List<int>();
            pointer = 0;
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

        public int Next()
        {
            int ans = 0;
            if (pointer >= lst.Count)
                return -1;
            else
            {
                ans = lst[pointer];
                pointer++;
            }
            return ans;
        }

        public bool HasNext()
        {
            if (pointer < lst.Count)
                return true;
            else
                return false;
        }
    }

}
