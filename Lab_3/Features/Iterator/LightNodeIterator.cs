using System;
using System.Collections.Generic;

namespace LightHTML.Features.Iterator
{
    public class LightNodeIterator
    {
        private List<LightNode> nodes;
        private int position = 0;

        public LightNodeIterator(List<LightNode> nodes)
        {
            this.nodes = nodes;
        }

        public bool HasNext() => position < nodes.Count;

        public LightNode Next() => nodes[position++];
    }
}
