using System;
using System.Collections.Generic;
using System.Text;

namespace Comp_Coding
{
    class Smallest_String_Starting_From_Leaf
    {
        List<string> list;
        public string SmallestFromLeaf(TreeNode root)
        {
            if (root == null)
                return "";

            list = new List<string>();

            StringBuilder sb = new StringBuilder();
            Stack<char> stack = new Stack<char>();

            DFS(root, sb);

            list.Sort();

            return list[0];
        }

        public void DFS(TreeNode node, StringBuilder sb)
        {
            if (node == null)
                return;

            sb.Insert(0,Convert.ToChar(node.val +'a'));

            if (node.left == null && node.right == null)
            {
                var temp = sb.ToString();
                list.Add(temp);
            }

            DFS(node.left, sb);
            DFS(node.right, sb);

            sb.Remove(0, 1);
        }
    }
}
