using System;
using System.Collections.Generic;

public class Virus : ICloneable
{
    public string Name { get; set; }
    public string Type { get; set; }
    public double Weight { get; set; }
    public int Age { get; set; }

    public List<Virus> Children { get; set; } = new List<Virus>();

    public Virus(string name, string type, double weight, int age)
    {
        Name = name;
        Type = type;
        Weight = weight;
        Age = age;
    }

    public void AddChild(Virus child)
    {
        Children.Add(child);
    }

    public object Clone()
    {
        var clonedVirus = new Virus(Name, Type, Weight, Age);

        foreach (var child in Children)
        {
            clonedVirus.Children.Add((Virus)child.Clone());
        }

        return clonedVirus;
    }

    public void Print(int level = 0)
    {
        string indent = new string(' ', level * 2);
        Console.WriteLine($"{indent}- {Name} ({Type}), Age: {Age}, Weight: {Weight}g");

        foreach (var child in Children)
        {
            child.Print(level + 1);
        }
    }
}
