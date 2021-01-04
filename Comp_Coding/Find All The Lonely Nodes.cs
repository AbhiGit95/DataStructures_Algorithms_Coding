using System;
using System.Collections.Generic;
using System.Text;

namespace Comp_Coding
{
    class Find_All_The_Lonely_Nodes
    {
        public IList<int> GetLonelyNodes(TreeNode root)
        {
            IList<int> result = new List<int>();
            lonelyfind(root, result, false);
            return result;
        }

        public void lonelyfind(TreeNode root, IList<int> lst, bool lonely)
        {
            if (root.left == null && root.right == null)
            {
                if (lonely)
                {
                    lst.Add(root.val);
                }

                return;
            }

            else if (root.left == null)
            {
                if (lonely)
                {
                    lst.Add(root.val);
                }
                lonelyfind(root.right, lst, true);
            }

            else if (root.right == null)
            {
                if (lonely)
                {
                    lst.Add(root.val);
                }
                lonelyfind(root.left, lst, true);
            }

            else
            {
                if (lonely)
                {
                    lst.Add(root.val);
                }
                lonelyfind(root.left, lst, false);
                lonelyfind(root.right, lst, false);
            }
        }
    }
}
