using System;

namespace LightHTML.Features.TemplateMethod
{
    public abstract class LightElementWithLifecycle
    {
        public void Create()
        {
            OnCreated();
            OnInserted();
            OnRemoved();
        }

        protected virtual void OnCreated() { Console.WriteLine("Element Created"); }
        protected virtual void OnInserted() { Console.WriteLine("Element Inserted"); }
        protected virtual void OnRemoved() { Console.WriteLine("Element Removed"); }
    }

    public class LightElement : LightElementWithLifecycle
    {
        protected override void OnCreated()
        {
            base.OnCreated();
            Console.WriteLine("LightElement: Custom Created");
        }

        protected override void OnInserted()
        {
            base.OnInserted();
            Console.WriteLine("LightElement: Custom Inserted");
        }

        protected override void OnRemoved()
        {
            base.OnRemoved();
            Console.WriteLine("LightElement: Custom Removed");
        }
    }
}
