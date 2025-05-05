using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        IHero hero1 = new Warrior();
        hero1 = new Sword(hero1);
        hero1 = new Armor(hero1);
        hero1 = new Artifact(hero1);

        Console.WriteLine(hero1.GetDescription());
        Console.WriteLine("Сила: " + hero1.GetPower());

        Console.WriteLine();

        IHero hero2 = new Mage();
        hero2 = new Artifact(hero2);
        hero2 = new Artifact(hero2);

        Console.WriteLine(hero2.GetDescription());
        Console.WriteLine("Сила: " + hero2.GetPower());

        Console.WriteLine("\nНатисніть Enter для завершення...");
        Console.ReadLine();
    }
}
