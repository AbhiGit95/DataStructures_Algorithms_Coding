using System;
using System.Collections.Generic;
using System.Text;

namespace Comp_Coding
{
    class TwoSumBSTs
    {
        public bool TwoSumBSTS(TreeNode root1, TreeNode root2, int target)
        {
            if (root1 == null || root2 == null)
                return false;

            HashSet<int> r1_set = new HashSet<int>();
            HashSet<int> r2_set = new HashSet<int>();

            DFS(root1, r1_set); DFS(root2, r2_set);

            IEnumerator<int> itr = r1_set.GetEnumerator();
            
            while(itr.MoveNext())
            {
                if (r2_set.Contains(target - itr.Current))
                    return true;
            }
            return false;
        }

        public void DFS(TreeNode root, HashSet<int> set)
        {
            if (root == null)
                return;
            else
                set.Add(root.val);

            DFS(root.left, set);
            DFS(root.right, set);
        }
    }
}
