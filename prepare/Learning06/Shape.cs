public class Shape
{
    private string _color;

    // Constructor that accepts a color
    public Shape(string color)
    {
        _color = color;
    }

    // Getter and setter for the color
    public string GetColor()
    {
        return _color;
    }

    public void SetColor(string color)
    {
        _color = color;
    }

    // Virtual method for getting the area
    public virtual double GetArea()
    {
        return 0.0;
    }
}
