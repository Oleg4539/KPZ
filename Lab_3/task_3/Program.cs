using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        IRenderer vectorRenderer = new VectorRenderer();
        IRenderer rasterRenderer = new RasterRenderer();

        Shape circle = new Circle(vectorRenderer);
        Shape square = new Square(rasterRenderer);
        Shape triangle = new Triangle(vectorRenderer);

        circle.Draw();
        square.Draw();
        triangle.Draw();

        Console.WriteLine("\nНатисніть Enter для завершення...");
        Console.ReadLine();
    }
}