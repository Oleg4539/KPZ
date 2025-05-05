using System;

namespace LightHTML.Features.Visitor
{
    public class LightNodeVisitor : IVisitor
    {
        public void Visit(LightNode node)
        {
            Console.WriteLine($"Visiting {node.TagName} node.");
        }
    }
}
