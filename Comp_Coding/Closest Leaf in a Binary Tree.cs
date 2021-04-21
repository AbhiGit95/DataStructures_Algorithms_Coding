using System;
using System.Collections.Generic;
using System.Text;

namespace Comp_Coding
{
    class Closest_Leaf_in_a_Binary_Tree
    {
        List<TreeNode> path;
        Dictionary<TreeNode, Result> map;
        public int FindClosestLeaf(TreeNode root, int k)
        {
            if (root == null)
                return 0;

            path = new List<TreeNode>();
            map = new Dictionary<TreeNode, Result>();
            dfs(root, k);
            var distanceFromRoot = path.Count - 1;
            var dist = int.MaxValue;

            TreeNode leaf = null;

            foreach(TreeNode node in path)
            {
                var leafDist = closestLeafNode(node);
                if(leafDist.distance + distanceFromRoot < dist )
                {
                    dist = leafDist.distance + distanceFromRoot;
                    leaf = leafDist.node;
                }
                distanceFromRoot--;
            }

            return leaf.val;
        }

        public bool dfs(TreeNode root, int k)
        {
            if (root == null)
                return false;

            else if(root.val == k)
            {
                path.Add(root);
                return true;
            }

            else
            {
                path.Add(root);
                bool left = dfs(root.left, k);
                if (left)
                    return true;
                bool right = dfs(root.right, k);
                if (right)
                    return true;
                path.RemoveAt(path.Count - 1);
                return false;
            }
        }

        public Result closestLeafNode(TreeNode root)
        {
            if (root == null)
                return new Result(null, int.MaxValue);

            else if (root.left == null && root.right == null)
                return new Result(root, 0);

            else if (map.ContainsKey(root))
                return map[root];

            else
            {
                var left = closestLeafNode(root.left);
                var right = closestLeafNode(root.right);
                var ans = new Result(left.distance <= right.distance ? left.node : right.node, Math.Min(left.distance, right.distance) + 1);
                map.Add(root, ans);
                return ans;
            }
        }
    }

    public class Result
    {
        public TreeNode node;
        public int distance;

        public Result(TreeNode n, int d)
        {
            this.node = n;
            this.distance = d;
        }
    }
}
