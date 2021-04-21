using System;
using System.Collections.Generic;
using System.Text;

namespace Comp_Coding
{
    class Sum_Root_to_Leaf_Numbers
    {
        List<string> list;
        public int SumNumbers(TreeNode root)
        {
            if (root == null)
                return 0;

            list = new List<string>();

            StringBuilder sb = new StringBuilder();

            DFS(root, sb);

            int res = 0;

            foreach(var v in list)
            {
                res += Convert.ToInt32(v);
            }

            return res;
        }


        public void DFS(TreeNode node, StringBuilder sb)
        {
            if (node == null)
                return;

            sb.Append(node.val);

            if (node.left == null && node.right == null)
            {
                list.Add(sb.ToString());
            }

            DFS(node.left, sb);
            DFS(node.right, sb);

            sb.Remove(sb.Length, 1);
        }
    }
}
