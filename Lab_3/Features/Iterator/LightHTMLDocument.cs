using System;
using System.Collections.Generic;

namespace LightHTML.Features.Iterator
{
    public class LightHTMLDocument
    {
        private List<LightNode> nodes = new List<LightNode>();

        public void AddNode(LightNode node) => nodes.Add(node);

        public LightNodeIterator GetIterator() => new LightNodeIterator(nodes);
    }
}
