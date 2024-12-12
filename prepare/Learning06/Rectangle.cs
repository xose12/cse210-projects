public class Rectangle : Shape
{
    private double _length;
    private double _width;

    // Constructor that accepts color, length, and width, and calls base constructor
    public Rectangle(string color, double length, double width) : base(color)
    {
        _length = length;
        _width = width;
    }

    // Override GetArea to calculate the area of the rectangle
    public override double GetArea()
    {
        return _length * _width;
    }
}
