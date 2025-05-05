using System;
using System.Collections.Generic;

public class LightElementNode : LightNode
{
    public string TagName { get; }
    public DisplayType Display { get; }
    public ClosingType Closing { get; }
    public List<string> CssClasses { get; } = new List<string>();
    public List<LightNode> Children { get; } = new List<LightNode>();

    public LightElementNode(string tagName, DisplayType display, ClosingType closing)
    {
        TagName = tagName;
        Display = display;
        Closing = closing;
    }

    public void AddChild(LightNode child)
    {
        Children.Add(child);
    }

    public override string OuterHTML
    {
        get
        {
            string inner = string.Join("", Children.ConvertAll(c => c.OuterHTML));
            string classes = string.Join(" ", CssClasses);
            string closeTag = Closing == ClosingType.Pair ? $"</{TagName}>" : "";
            return $"<{TagName} class=\"{classes}\">{inner}{closeTag}";
        }
    }

    public override string InnerHTML
    {
        get
        {
            return string.Join("", Children.ConvertAll(c => c.OuterHTML));
        }
    }
}