using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("\nJournal Menu:");
            Console.WriteLine("1. Add New Entry");
            Console.WriteLine("2. Display All Entries");
            Console.WriteLine("3. Exit");
            Console.Write("Select an option (1-3): ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    // Add new journal entry
                    Console.Write("Enter the date (YYYY-MM-DD): ");
                    string date = Console.ReadLine();

                    Console.Write("Enter the scripture reference (e.g., John 3:16): ");
                    string scripture = Console.ReadLine();

                    Console.Write("Enter your reflection: ");
                    string reflection = Console.ReadLine();

                    journal.AddEntry(new Entry(date, scripture, reflection));
                    Console.WriteLine("Journal entry added!");
                    break;

                case "2":
                    // Display all entries
                    journal.DisplayEntries();
                    break;

                case "3":
                    // Exit the program
                    exit = true;
                    Console.WriteLine("Exiting the program. Goodbye!");
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please select a valid option.");
                    break;
            }
        }
    }
}
