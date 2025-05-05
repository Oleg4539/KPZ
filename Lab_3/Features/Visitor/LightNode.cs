namespace LightHTML.Features.Visitor
{
    public class LightNode
    {
        public string TagName { get; set; }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
