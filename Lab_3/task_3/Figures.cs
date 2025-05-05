public class Circle : Shape
{
    public Circle(IRenderer renderer) : base(renderer) { }

    public override void Draw()
    {
        _renderer.Render("Коло");
    }
}

public class Square : Shape
{
    public Square(IRenderer renderer) : base(renderer) { }

    public override void Draw()
    {
        _renderer.Render("Квадрат");
    }
}

public class Triangle : Shape
{
    public Triangle(IRenderer renderer) : base(renderer) { }

    public override void Draw()
    {
        _renderer.Render("Трикутник");
    }
}