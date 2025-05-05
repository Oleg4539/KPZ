public class Product
{
    public string Name { get; set; }
    public Money Price { get; set; }

    public Product(string name, Money price)
    {
        Name = name;
        Price = price;
    }

    public void DecreasePrice(int amountMajor, int amountMinor)
    {
        decimal currentPrice = Price.ToDecimal();
        decimal decrease = amountMajor + amountMinor / 100m;
        decimal newPrice = Math.Max(0, currentPrice - decrease);
        int major = (int)newPrice;
        int minor = (int)((newPrice - major) * 100);
        Price.SetAmount(major, minor);
    }

    public void Display()
    {
        Console.Write($"{Name}: ");
        Price.Display();
    }
}
