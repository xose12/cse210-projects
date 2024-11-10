using System;

class Program
{
    static void Main(string[] args)
    {
        // DisplayWelcome function
        DisplayWelcome();

        // PromptUserName function and store the result
        string userName = PromptUserName();

        // PromptUserNumber function and store the result
        int userNumber = PromptUserNumber();

        // SquareNumber function to get the squared result
        int squaredNumber = SquareNumber(userNumber);

        // DisplayResult function to show the final message
        DisplayResult(userName, squaredNumber);
    }

    // To display a welcome message
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    // To prompt the user for their name and return it
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    // To prompt the user for their favorite number and return it as an integer
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }

    // To square the user's number and return the result
    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }

    // To display the final message with the user's name and squared number
    static void DisplayResult(string name, int squaredNumber)
    {
        Console.WriteLine($"{name}, the square of your number is {squaredNumber}");
    }
}
