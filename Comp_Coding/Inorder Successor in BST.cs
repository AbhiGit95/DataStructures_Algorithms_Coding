using System;
using System.Collections.Generic;
using System.Text;

namespace Comp_Coding
{
    class Inorder_Successor_in_BST
    {
        public TreeNode InorderSuccessor(TreeNode root, TreeNode p)
        {
            TreeNode res = null;
            TreeNode node = root;

            while (node != null)
            {
                if (node.val > p.val)
                {
                    res = node;
                    node = node.left;
                }

                else
                {
                    node = node.right;
                }
            }
            return res;
        }
    }
}
