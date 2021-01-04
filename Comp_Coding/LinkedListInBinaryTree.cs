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

        public bool IsSubPath(ListNode head, TreeNode root)
        {
                if (head == null && root == null)
                    return true;
                List<TreeNode> list = new List<TreeNode>();
                DFS(root, head.val, list);
                
            foreach(TreeNode node in list)
            {
                bool res = helper(node, head);
                if (res)
                    return true;
            }
            return false;
        }

        public void DFS(TreeNode root, int head_val, List<TreeNode> list)
        {
            if (root == null)
                return;

            if (root.val == head_val)
                list.Add(root);

            DFS(root.left, head_val, list);
            DFS(root.right, head_val, list);
        }


        public bool helper(TreeNode root, ListNode head)
        {
            if (root == null && head == null)
                return true;

            else if (root == null)
                return false;

            else if (head == null)
                return true;

            else if (root.val == head.val)
            {
                return helper(root.left, head.next) || helper(root.right, head.next);
            }
            else
                return false;
        }

      }
    }
