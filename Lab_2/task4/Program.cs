using System;

class Program
{
    static void Main(string[] args)
    {
        var parent = new Virus("COVID", "Coronavirus", 150, 2);
        var child1 = new Virus("Omicron", "Mutation", 80, 1);
        var child2 = new Virus("Delta", "Mutation", 90, 1);

        var grandchild = new Virus("Delta+Plus", "Sub-Mutation", 45, 0);

        child2.AddChild(grandchild);
        parent.AddChild(child1);
        parent.AddChild(child2);

        Console.WriteLine("Оригінал:");
        parent.Print();

        Console.WriteLine("\nКлон:");
        var clone = (Virus)parent.Clone();
        clone.Print();

        Console.ReadLine();
    }
}
