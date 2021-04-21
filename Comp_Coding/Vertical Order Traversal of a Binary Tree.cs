using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Comp_Coding
{
    class Vertical_Order_Traversal_of_a_Binary_Tree
    {
        public IList<IList<int>> VerticalTraversal(TreeNode root)
        {
            IList<IList<int>> result = new List<IList<int>>();

            if (root == null)
                return result;

            Dictionary<int, List<(int, int)>> map = new Dictionary<int, List<(int, int)>>();
            Queue<(TreeNode, int, int)> bfs = new Queue<(TreeNode, int, int)>();

            bfs.Enqueue((root, 0, 0));

            while (bfs.Count > 0)
            {
                var temp = bfs.Dequeue();

                if (!map.ContainsKey(temp.Item2))
                {
                    map.Add(temp.Item2, new List<(int, int)>() { (temp.Item1.val, temp.Item3) });
                }
                else
                {
                    map[temp.Item2].Add((temp.Item1.val, temp.Item3));
                }

                if (temp.Item1.left != null)
                    bfs.Enqueue((temp.Item1.left, temp.Item2 - 1, temp.Item3 + 1));

                if (temp.Item1.right != null)
                    bfs.Enqueue((temp.Item1.right, temp.Item2 + 1, temp.Item3 + 1));

            }

            int min = map.Keys.Min();
            int max = map.Keys.Max();

            while (min <= max)
            {
                if (map[min].Count > 1)
                    map[min].Sort(new TreeComparator());

                IList<int> tempres = new List<int>(map[min].Select(x => x.Item1));
                result.Add(tempres);
                min++;
            }

            return result;
        }

        public class TreeComparator : IComparer<(int, int)>
        {
            public int Compare((int, int) x, (int, int) y)
            {
                if (x.Item2 == y.Item2)
                {
                    return x.Item1.CompareTo(y.Item1);
                }
                else
                    return x.Item2.CompareTo(y.Item2);
            }
        }
    }
}
