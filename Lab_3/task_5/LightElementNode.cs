using System.Collections.Generic;
using System.Text;

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

    public void AddClass(string className) => CssClasses.Add(className);

    public void AddChild(LightNode child) => Children.Add(child);

    public override string InnerHTML
    {
        get
        {
            StringBuilder sb = new StringBuilder();
            foreach (var child in Children)
                sb.Append(child.OuterHTML);
            return sb.ToString();
        }
    }

    public override string OuterHTML
    {
        get
        {
            string classAttr = CssClasses.Count > 0 ? $" class=\"{string.Join(" ", CssClasses)}\"" : "";

            if (Closing == ClosingType.SelfClosing)
                return $"<{TagName}{classAttr} />";

            return $"<{TagName}{classAttr}>{InnerHTML}</{TagName}>";
        }
    }
}