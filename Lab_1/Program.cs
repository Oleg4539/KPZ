using System;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        var price1 = new Money(120, 50);
        var price2 = new Money(85, 75);

        var product1 = new Product("Кава", price1);
        var product2 = new Product("Чай", price2);
        var warehouse = new Warehouse();
        var reporting = new Reporting(warehouse);
        reporting.ReceiveProduct(product1, "шт", 30);
        reporting.ReceiveProduct(product2, "шт", 20);
        Console.WriteLine("\nІнвентаризація після надходження:");
        reporting.InventoryReport();
        reporting.ShipProduct("Кава", 10);
        product2.DecreasePrice(5, 0);
        Console.WriteLine("\nІнвентаризація після відвантаження і знижки:");
        reporting.InventoryReport();
    }
}
