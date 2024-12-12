public class Square : Shape
{
    private double _side;

    // Constructor that accepts color and side, and calls base constructor
    public Square(string color, double side) : base(color)
    {
        _side = side;
    }

    // Override GetArea to calculate the area of the square
    public override double GetArea()
    {
        return _side * _side;
    }
}
