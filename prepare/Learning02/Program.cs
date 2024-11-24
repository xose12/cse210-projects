using System;

class Program
{
    static void Main()
    {
        // Create instances using each constructor
        Fraction fraction1 = new Fraction(); // 1/1
        Fraction fraction2 = new Fraction(6); // 6/1
        Fraction fraction3 = new Fraction(6, 7); // 6/7

        // Display the fractions and their decimal values
        Console.WriteLine(fraction1.GetFractionString()); // 1/1
        Console.WriteLine(fraction1.GetDecimalValue());  // 1

        Console.WriteLine(fraction2.GetFractionString()); // 6/1
        Console.WriteLine(fraction2.GetDecimalValue());  // 6

        Console.WriteLine(fraction3.GetFractionString()); // 6/7
        Console.WriteLine(fraction3.GetDecimalValue());  // 0.857142857...

        // You can also modify the fraction using setters
        fraction1.SetTop(3);
        fraction1.SetBottom(4);
        Console.WriteLine(fraction1.GetFractionString()); // 3/4
        Console.WriteLine(fraction1.GetDecimalValue());  // 0.75
    }
}
