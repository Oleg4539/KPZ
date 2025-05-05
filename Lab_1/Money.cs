public class Money
{
    public int Major { get; set; }
    public int Minor { get; set; }

    public Money(int major, int minor)
    {
        Major = major;
        Minor = minor;
        Normalize();
    }

    private void Normalize()
    {
        if (Minor >= 100)
        {
            Major += Minor / 100;
            Minor %= 100;
        }
    }

    public void Display()
    {
        Console.WriteLine($"{Major}.{Minor:D2} грн");
    }

    public void SetAmount(int major, int minor)
    {
        Major = major;
        Minor = minor;
        Normalize();
    }

    public decimal ToDecimal() => Major + Minor / 100m;
}
