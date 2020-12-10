using System;
using System.Collections.Generic;
using System.Text;

namespace Comp_Coding
{
    class LinkedListInBinaryTree
    {
         public class ListNode
        {
         public int val;
         public ListNode next;
         public ListNode(int val = 0, ListNode next = null)
         {
            this.val = val;
            this.next = next;
         }
    }
 

  public class TreeNode 
  {
      public int val;
      public TreeNode left;
      public TreeNode right;
      public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) 
      {
          this.val = val;
          this.left = left;
          this.right = right;
      }
  }

            bool left; bool right;
            public bool IsSubPath(ListNode head, TreeNode root)
            {
                if (head == null && root == null)
                    return true;
                return helper_subpath(head, root, head);
            }

            public bool helper_subpath(ListNode head, TreeNode root, ListNode head_original)
            {
                if (head == null && root == null)
                    return true;
                else if (head == null)
                    return true;
                else if (root == null && head != null)
                    return false;

                else if ((head.val == root.val))
                {
                    left = helper_subpath(head.next, root.left, head_original);
                    right = helper_subpath(head.next, root.right, head_original);
                }
                else
                {
                    helper_subpath(head_original, root.left, head_original);
                    helper_subpath(head_original, root.right, head_original);
                }
                return left || right;
            }

        }
    }
