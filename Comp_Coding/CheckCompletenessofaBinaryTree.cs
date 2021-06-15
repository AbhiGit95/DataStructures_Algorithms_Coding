using System;
using System.Collections.Generic;
using System.Text;

namespace Comp_Coding
{
    class CheckCompletenessofaBinaryTree
    {
        public bool IsCompleteTree(TreeNode root)
        {
            if (root == null)
                return true;

            List<List<int>> levels = new List<List<int>>();

            Queue<(TreeNode, int)> bfs = new Queue<(TreeNode, int)>();

            TreeNode dummy = new TreeNode(1001);

            bfs.Enqueue((root, 0));
            bfs.Enqueue((dummy, -1));

            List<int> list = new List<int>();

            while (bfs.Count > 0)
            {
                var node = bfs.Dequeue();

                if (node.Item1.val == 1001 && bfs.Count == 0)
                {
                    levels.Add(new List<int>(list));
                    list.Clear();
                    break;
                }

                else if (node.Item1.val == 1001)
                {
                    levels.Add(new List<int>(list));
                    list.Clear();
                    bfs.Enqueue((dummy, -1));
                }
                else
                {
                    list.Add(node.Item2);

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

            for (int i = 0; i < levels.Count; i++)
            {
                if (levels[i].Count < Convert.ToInt32(Math.Pow(2, i)) && i != levels.Count - 1)
                    return false;

                else if (i == levels.Count - 1)
                {
                    return isValid(levels[i]);
                }

            }

            return true;
        }

        public bool isValid(List<int> lst)
        {
            for (int i = 0; i < lst.Count; i++)
            {
                if (i != lst[i])
                    return false;
            }
            return true;
        }
    }
}
