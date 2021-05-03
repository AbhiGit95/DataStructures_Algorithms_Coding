using System;
using System.Collections.Generic;
using System.Text;

namespace Comp_Coding
{
    class Delete_Leaves_With_a_Given_Value
    {
        public TreeNode RemoveLeafNodes(TreeNode root, int target)
        {
            var opt = Helper(root, target);

            if (opt)
                return null;
            else
                return root;
        }

        public bool Helper(TreeNode node, int target)
        {
            if (node == null)
                return true;

            if (node.left == null && node.right == null && node.val == target)
                return true;

            else if (node.left == null && node.right == null)
                return false;

            bool left = Helper(node.left, target);
            bool right = Helper(node.right, target);

            if (left)
                node.left = null;

            if (right)
                node.right = null;

            return (node.val == target) && (node.left == null && node.right == null);
        }
    }
}
