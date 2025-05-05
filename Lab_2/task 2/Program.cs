using System;

class Program
{
    static void Main(string[] args)
    {
        IDeviceFactory factory = new IProneFactory();

        var laptop = factory.CreateLaptop();
        var netbook = factory.CreateNetbook();
        var ebook = factory.CreateEBook();
        var smartphone = factory.CreateSmartphone();

        laptop.ShowInfo();
        netbook.ShowInfo();
        ebook.ShowInfo();
        smartphone.ShowInfo();

        Console.WriteLine("Натисніть Enter для завершення...");
        Console.ReadLine();
    }
}
