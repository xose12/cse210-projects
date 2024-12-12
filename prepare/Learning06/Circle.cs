public class Circle : Shape
{
    private double _radius;

    // Constructor that accepts color and radius, and calls base constructor
    public Circle(string color, double radius) : base(color)
    {
        _radius = radius;
    }

    // Override GetArea to calculate the area of the circle
    public override double GetArea()
    {
        return Math.PI * _radius * _radius;
    }
}
