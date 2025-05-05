public class Reporting
{
    private Warehouse warehouse;

    public Reporting(Warehouse warehouse)
    {
        this.warehouse = warehouse;
    }

    public void ReceiveProduct(Product product, string unit, int quantity)
    {
        var item = warehouse.GetItem(product.Name);
        if (item != null)
        {
            item.Quantity += quantity;
            item.LastSupplyDate = DateTime.Now;
        }
        else
        {
            warehouse.AddItem(new WarehouseItem(product, unit, quantity, DateTime.Now));
        }
    }

    public void ShipProduct(string productName, int quantity)
    {
        var item = warehouse.GetItem(productName);
        if (item != null && item.Quantity >= quantity)
        {
            item.Quantity -= quantity;
            Console.WriteLine($"Відвантажено {quantity} од. товару {productName}");
        }
        else
        {
            Console.WriteLine($"Неможливо відвантажити {quantity} од. товару {productName}");
        }
    }

    public void InventoryReport()
    {
        warehouse.ShowInventory();
    }
}
