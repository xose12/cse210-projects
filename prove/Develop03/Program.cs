using System;

class Program
{
    static void Main()
    {
        // Initialize the scripture
        var reference = new Reference("John", 3, 16);
        var scripture = new Scripture(reference, "For God so loved the world that he gave his only begotten Son");

        // Display the full scripture
        scripture.DisplayScripture();

        // Game loop
        while (!scripture.AllWordsHidden())
        {
            Console.WriteLine("\nPress Enter to hide a word, or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }
            else
            {
                // Hide a random word and display the scripture again
                scripture.HideRandomWord();
                Console.Clear();
                scripture.DisplayScripture();
            }
        }

        // End the game
        Console.WriteLine("\nAll words are hidden! Memorization complete.");
    }
}
