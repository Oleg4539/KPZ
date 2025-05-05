using System.Collections.Generic;
using System;

namespace LightHTML.Features.Command
{
    public class LightNode
    {
        public string TagName { get; set; }
        public List<LightNode> Children { get; set; } = new List<LightNode>();

        public void AddChild(LightNode child) => Children.Add(child);

        // Додано метод Render
        public void Render()
        {
            Console.WriteLine($"Rendering: {TagName}");
        }
    }
}