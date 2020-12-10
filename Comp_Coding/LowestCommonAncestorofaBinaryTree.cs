using System;
using System.Collections.Generic;
using System.Text;

namespace Comp_Coding
{
    class LowestCommonAncestorofaBinaryTree
    {

        public TreeNode node = null;
        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            if (root == null)
                return null;
            DFS_helper(root, p, q);
            return node;
            
        }

        public bool DFS_helper(TreeNode root, TreeNode p, TreeNode q)
        {
            if (root == null)
                return false;

            //recurse on left side
            int left = DFS_helper(root.left, p, q) ? 1 : 0;

            //recurse on right side
            int right = DFS_helper(root.right, p, q) ? 1 : 0;

            int mid = (root == p || root == q) ? 1 : 0;

            if(mid + left + right >= 2)
            {
                node = root;
            }

            return (mid + left + right > 0);
        }


        //Iterative method
        public TreeNode LowestCommonAncestor2(TreeNode root, TreeNode p, TreeNode q)
        {
            if (root == null)
                return null;

            Stack<TreeNode> stack = new Stack<TreeNode>();
            Dictionary<TreeNode, TreeNode> parent_map = new Dictionary<TreeNode, TreeNode>();

            stack.Push(root); parent_map.Add(root, null);

            //until both the nodes have been captured.
            while(!parent_map.ContainsKey(p) || !parent_map.ContainsKey(q))
            {
                TreeNode temp = stack.Pop();
                if(temp.left != null)
                {
                    parent_map.Add(temp.left, temp);
                    stack.Push(temp.left);
                }

                if(temp.right != null)
                {
                    parent_map.Add(temp.right, temp);
                    stack.Push(temp.right);
                }

            }

            HashSet<TreeNode> set = new HashSet<TreeNode>();
            while(p != null)
            {
                set.Add(p);
                p = parent_map.GetValueOrDefault(p,null);
            }

            while(!set.Contains(q))
            {
                set.Add(q);
                q = parent_map[q];
            }

            return q;
        }

    }
}
