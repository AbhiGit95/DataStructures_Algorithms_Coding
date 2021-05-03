using System;
using System.Collections.Generic;
using System.Text;

namespace Comp_Coding
{
    class BinaryTreeUpsideDown
    {
        TreeNode newNode = null;

        public TreeNode UpsideDownBinaryTree(TreeNode root)
        {
            if (root == null)
                return null;

            UpsideDown(root);
            return newNode;
        }

        public TreeNode UpsideDown(TreeNode node)
        {
            //newRoot's left child will be it's parent's right child.
            //newRoot's right child will be it's parent.

            if (node == null)
                return null;

            var newRoot = UpsideDown(node.left);
            if (newRoot == null)
            {
                newRoot = node;
                Console.WriteLine(newRoot.val);
                if (newNode == null)
                    newNode = node;
            }

            else
            {
                newRoot.right = node;
                newRoot.left = node.right;
                node.right = null;
                node.left = null;
            }

            return node;
        }
    }
}
