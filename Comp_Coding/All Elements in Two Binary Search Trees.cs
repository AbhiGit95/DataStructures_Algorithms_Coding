using System;
using System.Collections.Generic;
using System.Text;

namespace Comp_Coding
{
    class All_Elements_in_Two_Binary_Search_Trees
    {
        public IList<int> GetAllElements(TreeNode root1, TreeNode root2)
        {
            if (root1 == null && root2 == null)
            {
                return new List<int>();
            }

            else
            {
                List<int> list = new List<int>();
                if (root1 == null)
                {
                    get_elements(root2, list);
                }

                else if (root2 == null)
                {
                    get_elements(root1, list);
                }
                else
                {
                    get_elements(root1, list);
                    get_elements(root2, list);
                }
                list.Sort();
                //IList<int> res = list;
                return list;
            }
        }

        public List<int> get_elements(TreeNode root1, List<int> list)
        {
            if (root1 != null)
            {
                list.Add(root1.val);
                get_elements(root1.left, list);
                get_elements(root1.right, list);
            }
            return list;
        }
    }
}
