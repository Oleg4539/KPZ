using LightHTML.Features.Iterator;

namespace LightHTML.Features.Command
{
    public class AddChildCommand : ICommand
    {
        private LightNode parent;
        private LightNode child;

        public AddChildCommand(LightNode parent, LightNode child)
        {
            this.parent = parent;
            this.child = child;
        }

        public void Execute() => parent.AddChild(child);
    }
}
