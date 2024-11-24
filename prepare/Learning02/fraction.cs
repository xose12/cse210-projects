using System;

public class Fraction
{
    // Private attributes for top (numerator) and bottom (denominator)
    private int top;
    private int bottom;

    // Default constructor - initializes the fraction to 1/1
    public Fraction()
    {
        top = 1;
        bottom = 1;
    }

    // Constructor with one parameter for the numerator, denominator defaults to 1
    public Fraction(int top)
    {
        this.top = top;
        bottom = 1;
    }

    // Constructor with two parameters, one for the numerator and one for the denominator
    public Fraction(int top, int bottom)
    {
        this.top = top;
        this.bottom = bottom;
    }

    // Getter and setter for the top (numerator)
    public int GetTop()
    {
        return top;
    }

    public void SetTop(int top)
    {
        this.top = top;
    }

    // Getter and setter for the bottom (denominator)
    public int GetBottom()
    {
        return bottom;
    }

    public void SetBottom(int bottom)
    {
        this.bottom = bottom;
    }

    // Method to return the fraction as a string (e.g., "3/4")
    public string GetFractionString()
    {
        return $"{top}/{bottom}";
    }

    // Method to return the decimal value of the fraction (e.g., 0.75)
    public double GetDecimalValue()
    {
        return (double)top / bottom;
    }
}
