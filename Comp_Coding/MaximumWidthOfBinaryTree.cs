using System;
using System.Collections.Generic;
using System.Text;

namespace Comp_Coding
{
    class MaximumWidthOfBinaryTree
    {
        public int WidthOfBinaryTree(TreeNode root)
        {
            if (root == null)
                return 0;

            Queue<(TreeNode, int)> bfs = new Queue<(TreeNode, int)>();

            TreeNode dummy = new TreeNode(101);
            //TreeNode nullNode = new TreeNode(102);

            bfs.Enqueue((root, 0));
            bfs.Enqueue((dummy, -1));

            int max = 0;
            List<(int, int)> nodes = new List<(int, int)>();

            while (bfs.Count > 0)
            {
                var node = bfs.Dequeue();
                if (node.Item1.val == 101 && bfs.Count == 0)
                {
                    int width = nodes[nodes.Count - 1].Item2 - nodes[0].Item2;
                    max = Math.Max(width, max);
                    nodes.Clear();
                    break;
                }


                if (node.Item1.val == 101)
                {
                    int width = nodes[nodes.Count - 1].Item2 - nodes[0].Item2;
                    max = Math.Max(width, max);
                    nodes.Clear();
                    bfs.Enqueue((dummy, -1));
                }
                else
                {
                    nodes.Add((node.Item1.val, node.Item2));

                    if (node.Item1.left != null)
                    {
                        bfs.Enqueue((node.Item1.left, 2 * node.Item2));
                    }
                    if (node.Item1.right != null)
                    {
                        bfs.Enqueue((node.Item1.right, 2 * node.Item2 + 1));
                    }
                }
            }
            return max + 1;
        }
    }
}
