using System;
using System.Collections.Generic;
using System.Text;

namespace Comp_Coding
{
    class LowestCommonAncestorOfaBinaryTreeII
    {
        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            if (root == null || p == null || q == null)
                return null;

            if (!DFS_helper(root, p) || !DFS_helper(root, q))
                return null;

            Stack<TreeNode> stack = new Stack<TreeNode>();
            stack.Push(root);
            Dictionary<TreeNode, TreeNode> parent_map = new Dictionary<TreeNode, TreeNode>();
            parent_map.Add(root, null);
            while(!parent_map.ContainsKey(p) || !parent_map.ContainsKey(q))
            {
                TreeNode temp = stack.Pop();

                if(temp.left != null)
                {
                    stack.Push(temp.left);
                    parent_map.Add(temp.left, temp);
                }

                if(temp.right != null)
                {
                    stack.Push(temp.right);
                    parent_map.Add(temp.right, temp);
                }
            }

            HashSet<TreeNode> set = new HashSet<TreeNode>();
            while(p != null)
            {
                set.Add(p);
                p = parent_map.GetValueOrDefault(p, null);
            }

            while(!set.Contains(q))
            {
                set.Add(q);
                q = parent_map.GetValueOrDefault(q, null);
            }

            return q;
        }

        public bool DFS_helper(TreeNode root, TreeNode target)
        {
            if (root == null)
                return false;

            if (root == target)
                return true;

            return (DFS_helper(root.left, target) || DFS_helper(root.right, target));
        }
    }
}
