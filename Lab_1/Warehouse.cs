public class WarehouseItem
{
    public Product Product { get; set; }
    public string Unit { get; set; }
    public int Quantity { get; set; }
    public DateTime LastSupplyDate { get; set; }

    public WarehouseItem(Product product, string unit, int quantity, DateTime lastSupplyDate)
    {
        Product = product;
        Unit = unit;
        Quantity = quantity;
        LastSupplyDate = lastSupplyDate;
    }

    public void Display()
    {
        Product.Display();
        Console.WriteLine($"Кількість: {Quantity} {Unit}");
        Console.WriteLine($"Дата останнього завозу: {LastSupplyDate.ToShortDateString()}");
        Console.WriteLine();
    }
}

public class Warehouse
{
    private List<WarehouseItem> items = new List<WarehouseItem>();

    public void AddItem(WarehouseItem item)
    {
        items.Add(item);
    }

    public void ShowInventory()
    {
        Console.WriteLine("=== Інвентаризація складу ===");
        foreach (var item in items)
        {
            item.Display();
        }
    }
    public WarehouseItem? GetItem(string productName)
    {
        return items.FirstOrDefault(i => i.Product.Name == productName);
    }

}
