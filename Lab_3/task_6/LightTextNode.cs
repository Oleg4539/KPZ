public class LightTextNode : LightNode
{
    public string Text { get; }

    public LightTextNode(string text)
    {
        Text = text;
    }

    public override string OuterHTML
    {
        get { return Text; }
    }

    public override string InnerHTML
    {
        get { return Text; }
    }
}