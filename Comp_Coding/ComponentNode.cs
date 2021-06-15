using System;
using System.Collections.Generic;
using System.Text;

namespace Comp_Coding
{
    public class ComponentNode
    {
        public int value;
        public List<ComponentNode> components;

        public ComponentNode()
        {
            components = new List<ComponentNode>();
        }

        public ComponentNode(int val)
        {
            this.value = val;
            this.components = new List<ComponentNode>();
        }
    }
}
