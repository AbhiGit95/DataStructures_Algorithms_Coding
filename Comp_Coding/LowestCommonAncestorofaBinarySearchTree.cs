﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Comp_Coding
{
      public class TreeNode
    {
      public int val;
      public TreeNode left;
      public TreeNode right;
      public TreeNode(int x) { val = x; }
  }
    class LowestCommonAncestorofaBinarySearchTree
    {
        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            if (root == null)
                return null;
            
            if(p.val < root.val && q.val < root.val )
            {
                return LowestCommonAncestor(root.left, p, q);
            }
            else if(p.val > root.val && q.val > root.val)
            {
                return LowestCommonAncestor(root.right, p, q);
            }
            else
            {
                return root;
            }
        }
    }
}
