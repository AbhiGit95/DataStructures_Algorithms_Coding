using System;
using System.Collections.Generic;
using System.Text;

namespace Comp_Coding
{
    class Sum_of_Nodes_with_Even_Valued_Grandparent
    {
        public int SumEvenGrandparent(TreeNode root)
        {
            List<TreeNode> even_nodes = new List<TreeNode>();
            DFS(root, even_nodes);
            int result = 0;
            HashSet<TreeNode> visited = new HashSet<TreeNode>();
            foreach (TreeNode node in even_nodes)
            {
                result += Sum_even(node, visited);
            }
            return result;
        }

        public void DFS(TreeNode root, List<TreeNode> list)
        {
            if (root == null)
                return;

            if (root.val % 2 == 0)
                list.Add(root);

            DFS(root.left, list);
            DFS(root.right, list);
        }

        public int Sum_even(TreeNode root, HashSet<TreeNode> set)
        {
            Queue<TreeNode> q = new Queue<TreeNode>();
            TreeNode dummy = new TreeNode(-1);
            q.Enqueue(root); q.Enqueue(dummy);
            int count = 0; int result = 0;
            while (q.Count > 0 && count < 2)
            {
                TreeNode node = q.Dequeue();

                if (node.val == -1)
                {
                    count += 1;
                    if (count < 2)
                        q.Enqueue(dummy);
                }

                else
                {
                    if (node.left != null)
                        q.Enqueue(node.left);

                    if (node.right != null)
                        q.Enqueue(node.right);
                }
            }

            while (q.Count > 0)
            {
                TreeNode node = q.Dequeue();
                if (!set.Contains(node))
                {
                    result += node.val;
                    set.Add(node);
                }
            }

            return result;
        }
    }
}
