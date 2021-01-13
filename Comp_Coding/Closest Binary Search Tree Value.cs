using System;
using System.Collections.Generic;
using System.Text;

namespace Comp_Coding
{
    class Closest_Binary_Search_Tree_Value
    {
        //Using Inorder Traversal and linear search
        public int ClosestValue(TreeNode root, double target)
        {
            List<int> nodes = new List<int>();
            inorder(root, nodes);

            int result = 0; double diff = double.MaxValue;

            foreach (int n in nodes)
            {
                if (Math.Abs(n - target) < diff)
                {
                    diff = Math.Abs(n - target);
                    result = n;
                }
            }
            return result;
        }

        public void inorder(TreeNode root, List<int> nodes)
        {
            if (root == null)
                return;

            inorder(root.left, nodes);
            nodes.Add(root.val);
            inorder(root.right, nodes);
        }

        //Faster Method - Using Binary Search

        public int ClosestValue2(TreeNode root, double target)
        {
            double diff = Math.Abs(root.val - target);
            int result = root.val;
            while(root != null)
            {
                if(Math.Abs(root.val - target) < diff)
                {
                    diff = Math.Abs(root.val - target);
                    result = root.val;
                }

                if(root.val > target)
                {
                    root = root.left;
                }
                else
                {
                    root = root.right;
                }
            }

            return result;
        }
    }
}
