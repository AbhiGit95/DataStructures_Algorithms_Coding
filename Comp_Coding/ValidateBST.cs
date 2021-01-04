using System;
using System.Collections.Generic;
using System.Text;

namespace Comp_Coding
{
    class ValidateBST
    {
        //Method 1 : check using range 
        public bool IsValidBST(TreeNode root)
        {
            int? min = 0; int? max = 0;
            if (min == 0 && max == 0)
            {
                min = null; max = null;
            }

            bool left = helper(root.left, min, root.val);
            bool right = helper(root.right, root.val, max);
            return left && right;
        }

        public bool helper(TreeNode root, int? min, int? max)
        {
            if (root == null)
                return true;

            if ((min != null && root.val <= min) || (max != null && root.val >= max))
                return false;

            return (helper(root.left, min, root.val) && helper(root.right, root.val, max));
        }

        //Approach 2 using Inorder Traversal
        int? prev = 0;
        public bool IsValidBST2(TreeNode root)
        {
            prev = null;
            return Inorder(root);

        }

        public bool Inorder(TreeNode root)
        {
            if (root == null)
                return true;

            if (!Inorder(root.left))
                return false;

            if (prev != null && root.val <= prev)
                return false;

            prev = root.val;

            return Inorder(root.right);

        }
    }
}
