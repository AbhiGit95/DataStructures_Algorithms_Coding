using System;
using System.Collections.Generic;
using System.Text;

namespace Comp_Coding
{
    public class AmazonOA2
    {
       // public List<NodeWrapper> lisOfNodes = new List<NodeWrapper>();
        ComponentNode MaxNode = null;
        int maxValue = -1;
        public ComponentNode getFastestComponent(ComponentNode rootComponent)
        {
            if (rootComponent == null)
                return null;

            DFS(rootComponent);

           // lisOfNodes = new List<NodeWrapper>();

            //var max = 0;
            //ComponentNode result = null;
            //foreach(var node in lisOfNodes)
            //{
            //    if(node.numberOfComponents > 1)
            //    {
            //        var avg = node.totalSum / node.numberOfComponents;
            //        if(avg > max)
            //        {
            //            max = avg;
            //            result = node.node;
            //        }
            //    }
            //}

            return MaxNode;
        }

        public (int,int) DFS(ComponentNode root)
        {
            if (root == null)
                return (0,0);

            int comp = 0;
            int totalSum = 0;

            foreach(var n in root.components)
            {
                var ret = DFS(n);
                comp += ret.Item1 + 1;
                totalSum += ret.Item2 + n.value;
            }

            if(comp > 1)
            {
                var avg = totalSum / comp;
                if(avg > maxValue)
                {
                    maxValue = avg;
                    MaxNode = root;
                }
            }

            //NodeWrapper node = new NodeWrapper(root, comp, totalSum);
            //lisOfNodes.Add(node);
            return (comp, totalSum);
        }

        public class NodeWrapper
        {
            public ComponentNode node;
            public int numberOfComponents;
            public int totalSum;

            public NodeWrapper(ComponentNode node, int noOfComponents, int sum)
            {
                this.node = node;
                this.numberOfComponents = noOfComponents;
                this.totalSum = sum;
            }
        }
    }
}
