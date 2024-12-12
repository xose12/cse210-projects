using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a Square instance
        Square mySquare = new Square("red", 5);

        // Output the color and area
        Console.WriteLine($"Square Color: {mySquare.GetColor()}");
        Console.WriteLine($"Square Area: {mySquare.GetArea()}");
    }
}
