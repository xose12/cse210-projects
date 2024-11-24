// Program.cs
using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();

        // Add some entries to the journal
        journal.AddEntry(new Entry("2024-11-23", "John 3:16", "God’s love is everlasting."));
        journal.AddEntry(new Entry("2024-11-22", "Psalm 23:1", "The Lord is my shepherd."));

        // Display the journal entries
        journal.DisplayJournal();
    }
}
