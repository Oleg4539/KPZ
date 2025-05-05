// Program.cs
using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        string[] lines = {
            "Моя книга",
            "Глава 1",
            " Це важлива думка",
            "Це звичайний абзац про те, як ми вчимо шаблони проєктування.",
            "Дякую за увагу."
        };

        var factory = new LEFF();
        var body = new LightElementNode("div", DisplayType.Block, ClosingType.Pair);

        foreach (string line in lines)
        {
            LightElementNode tag;

            if (line == lines[0])
                tag = factory.GetElement("h1", DisplayType.Block, ClosingType.Pair);
            else if (line.Length < 20)
                tag = factory.GetElement("h2", DisplayType.Block, ClosingType.Pair);
            else if (line.StartsWith(" "))
                tag = factory.GetElement("blockquote", DisplayType.Block, ClosingType.Pair);
            else
                tag = factory.GetElement("p", DisplayType.Block, ClosingType.Pair);

            tag.AddChild(new LightTextNode(line.Trim()));
            body.AddChild(tag);
        }

        Console.WriteLine("Згенерований HTML:");
        Console.WriteLine(body.OuterHTML);

        Console.WriteLine($"\nКількість унікальних тегів у фабриці: {factory.CachedCount}");
        Console.WriteLine($"\nКількість елементів у дереві: {body.Children.Count}");
        Console.WriteLine("\nНатисніть Enter для завершення...");
        Console.ReadLine();
    }
}
