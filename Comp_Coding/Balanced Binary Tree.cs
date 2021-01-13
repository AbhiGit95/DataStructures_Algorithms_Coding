using System;
using System.Collections.Generic;
using System.Text;

namespace Comp_Coding
{
    class Balanced_Binary_Tree
    {
        public bool IsBalanced(TreeNode root)
        {
            return helperbalanced(root) == -1 ? false : true;
        }

        public int helperbalanced(TreeNode root)
        {
            if (root == null)
                return 0;

            int left = helperbalanced(root.left);
            if (left == -1)
                return -1;
            int right = helperbalanced(root.right);
            if (right == -1)
                return -1;

            if (Math.Abs(left - right) > 1)
                return -1;
            else
                return Math.Max(left, right) + 1;
        }
    }
}
