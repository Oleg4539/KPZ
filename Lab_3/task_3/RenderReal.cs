using System;

public class VectorRenderer : IRenderer
{
    public void Render(string shapeName)
    {
        Console.WriteLine($"Малюємо {shapeName} як векторну графіку.");
    }
}

public class RasterRenderer : IRenderer
{
    public void Render(string shapeName)
    {
        Console.WriteLine($"Малюємо {shapeName} як растрову графіку.");
    }
}