using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        var div = new LightElementNode("div", DisplayType.Block, ClosingType.Pair);
        div.AddClass("container");

        var h1 = new LightElementNode("h1", DisplayType.Block, ClosingType.Pair);
        h1.AddChild(new LightTextNode("Заголовок"));

        var p = new LightElementNode("p", DisplayType.Block, ClosingType.Pair);
        p.AddChild(new LightTextNode("Це абзац."));

        div.AddChild(h1);
        div.AddChild(p);

        Console.WriteLine("➡️ Outer HTML:");
        Console.WriteLine(div.OuterHTML);

        Console.WriteLine("\n➡️ Inner HTML:");
        Console.WriteLine(div.InnerHTML);

        Console.WriteLine("\nНатисніть Enter для завершення...");
        Console.ReadLine();
    }
}